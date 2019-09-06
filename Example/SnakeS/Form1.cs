using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnakeS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.AppendText( Properties.Resources.snake );
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Select(0,0);
        }
        private Game game;
        private bool SpeededUp = false;
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (game == null) return;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                game.MoveUp();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                game.MoveDown();
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                game.MoveRight();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                game.MoveLeft();
            }
            else if (e.KeyCode == Keys.Space && !SpeededUp)
            {
                game.SpeedUp();
                SpeededUp = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            options.Hide();
            game = new Game((int)numericUpDown1.Value, (int)numericUpDown2.Value, difficulty.Value, GamePanel, checkBox1.Checked);
            button2.Show();
            GamePanel.Show();
            GamePanel.BringToFront();
            GamePanel.BackColor = Settings.StageColor;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            game.Stop();
            options.Show();
            button2.Hide();
            GamePanel.Hide();
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (game == null) return;

            if (e.KeyCode == Keys.Space && SpeededUp)
            {
                SpeededUp = false;
                game.SpeedDown();
            }
                
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                Settings.BlockStyle = BorderStyle.FixedSingle;
            else
                Settings.BlockStyle = BorderStyle.None;
        }
    }
}

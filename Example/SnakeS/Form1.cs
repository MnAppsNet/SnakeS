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
        }
        Game game;
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                game.MoveUp();
            }
            else if (e.KeyCode == Keys.Down)
            {
                game.MoveDown();
            }
            else if (e.KeyCode == Keys.Right)
            {
                game.MoveRight();
            }
            else if (e.KeyCode == Keys.Left)
            {
                game.MoveLeft();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            options.Hide();
            game = new Game((int)numericUpDown1.Value, (int)numericUpDown2.Value, difficulty.Value, GamePanel);
            button2.Show();
            GamePanel.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            game.Stop();
            options.Show();
            button2.Hide();
            GamePanel.Hide();
        }
    }
}

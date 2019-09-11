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

            //Text Art :
            textArt.ReadOnly = true;
            changeTextArt();

            //Load best Score :
            best_score.Text = "Best Score: " + Properties.Settings.Default.score.ToString();

            //Load settings
            setColors();
            loadSettings();
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
            else if (e.KeyCode == Keys.P)
            {
                if (!game.isPaused)
                    game.Pause();
                else
                    game.Resume();
            }
        }
        private void changeTextArt()
        {
            textArt.Text = (Properties.Resources.snake.Split('+').GetValue((new Random()).Next(0, Properties.Resources.snake.Split('+').Length)).ToString());
            textArt.SelectAll();
            textArt.SelectionAlignment = HorizontalAlignment.Center;
            textArt.Select(0, 0);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            options.Hide();
            game = new Game((int)numericUpDown1.Value, (int)numericUpDown2.Value, difficulty.Value, GamePanel, wallCheckbox.Checked, score);
            game.GameOver += GameOver;
            button2.Show();
            GamePanel.Show();
            GamePanel.BringToFront();
            GamePanel.BackColor = Settings.StageColor;
            score.Show();
            score_label.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            changeTextArt();
            game.Stop();
            options.Show();
            button2.Hide();
            GamePanel.Hide();
            score.Hide();
            score_label.Hide();
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
        private void GameOver(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.score < uint.Parse(score.Text))
            {
                Properties.Settings.Default.score = uint.Parse(score.Text);
                Properties.Settings.Default.Save();
                best_score.Text = "Best Score: " + Properties.Settings.Default.score.ToString();
            }
            score.Text = "0";
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (gridCheckbox.Checked)
                Settings.BlockStyle = BorderStyle.FixedSingle;
            else
                Settings.BlockStyle = BorderStyle.None;
            Properties.Settings.Default.grid = gridCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topMostCheckbox.Checked;
        }

        private void Color_Choose(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.BackColor = cd.Color;
                Properties.Settings.Default[p.Tag.ToString()] = cd.Color;
                Properties.Settings.Default.Save();
                setColors();
            }
        }
        private void setColors()
        {
            //Change Game Colors :
            bg_color_panel.BackColor = Settings.StageColor = Properties.Settings.Default.bg_color;
            player_color_panel.BackColor = Settings.PlayerColor = Properties.Settings.Default.player_color;
            head_color_panel.BackColor = Settings.HeadColor = Properties.Settings.Default.head_color;
            power_color_panel.BackColor = Settings.PowerUpColor = Properties.Settings.Default.power_color;

            //Change UI colors :
            this.BackColor = bg_color_panel.BackColor;
            this.ForeColor = player_color_panel.BackColor;
            foreach (Control c in this.Controls)
            {
                if (c.Name.EndsWith("_color_panel")) continue;
                c.ForeColor = player_color_panel.BackColor;
                c.BackColor = bg_color_panel.BackColor;
                if (c.HasChildren)
                    foreach (Control c2 in c.Controls)
                    {
                        c2.ForeColor = player_color_panel.BackColor;
                        c2.BackColor = bg_color_panel.BackColor;
                    }
            }
        }
        private void loadSettings()
        {
            gridCheckbox.Checked = Properties.Settings.Default.grid;
            wallCheckbox.Checked = Properties.Settings.Default.wall;
            difficulty.Value = Properties.Settings.Default.difficulty;
        }

        private void WallCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.wall = wallCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Difficulty_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.difficulty = difficulty.Value;
            Properties.Settings.Default.Save();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnakeS
{
    class Game
    {
        #region ------------ Variables -------------
        private Control controller; //The controller that displays the Game
        private Label   scoreLabel; //Label where the score will be displayed

        //Events
        public event EventHandler GameOver;
        public event EventHandler Paused;
        public event EventHandler Resumed;
        public event EventHandler PowerUp;

        //Construction Variables :
        private int blockNumberX;  // Number of blocks on the X axis
        private int blockNumberY;  // Number of blocks on the Y axis
        private int width;         // Blocks width
        private int height;        // Blocks height
        private bool wall;
        private Blocks blocks;     // Blocks list
        private Timer timer;       // Timer for the stage updates

        //Player Variables :
        private List<int[]> Player; // Player properties ( 0: X Block , 1: Y Block , 2: X Movement, 3: Y Movement )
        private int xMove = 0;      // X Movement of Player
        private int yMove = 0;      // Y Movement of Player
        private uint score = 0;     // Player score
        private uint score_increasement = 1;
        private bool paused = false;
        public uint Score
        {
            get { return score; }
        }
        public bool isPaused
        {
            get { return paused; }
        }
        #endregion -------------------------


        public Game(int BlockNumberX, int BlockNumberY, int refreshRate, Control Controller, bool Walls = false, Label ScoreLabel = null)
        { //Constructor
            Player = new List<int[]>();
            blockNumberX = BlockNumberX;
            blockNumberY = BlockNumberY;
            controller = Controller;
            scoreLabel = ScoreLabel;
            score = 0;
            wall = Walls;
            blocks = new Blocks();
            timer = new Timer();
            timer.Interval = refreshRate;
            score_increasement = 2000 / (uint)refreshRate;
            timer.Tick += update;
            controller.Hide();
            createGame();
        }


        #region   -------- Player Movements ----------
        public void MoveUp()
        {
            if (Player[0][3] != 1)
            {
                xMove = 0;
                yMove = -1;
            }
        }
        public void MoveDown()
        {
            if (Player[0][3] != -1)
            {
                xMove = 0;
                yMove = 1;
            }
        }
        public void MoveLeft()
        {
            if (Player[0][2] != 1)
            {
                xMove = -1;
                yMove = 0;
            }
        }
        public void MoveRight()
        {
            if (Player[0][2] != -1)
            {
                xMove = 1;
                yMove = 0;
            }
        }
        public void SpeedUp()
        {
            timer.Interval = timer.Interval / 2;
        }
        public void SpeedDown()
        {
            timer.Interval = timer.Interval * 2;
        }
        #endregion -----------------------------------

        #region   -------- Game Flow Control ---------
        public void Stop()
        {
            timer.Stop();
            Player.Clear();
            blocks.Clear();
            blocks.Items.Clear();
            xMove = 0;
            yMove = 0;
            if (scoreLabel != null) scoreLabel.Text = "0";
        }
        public void Pause()
        {
            if (Paused != null) Paused(this, null);
            paused = true;
            timer.Stop();
        }
        public void Resume()
        {
            if (Resumed != null) Resumed(this, null);
            paused = false;
            timer.Start();
        }
        public void Reset()
        {
            timer.Stop();
            Player.Clear();
            foreach (Block b in blocks.Items)
            {
                b.Color = Settings.StageColor;
                b.Power = false;
            }
            xMove = 0;
            yMove = 0;
            if (scoreLabel != null) scoreLabel.Text = "0";
        }
        #endregion -------------------------------

        #region -------- Private Methodes ----------
        private void createGame() //Creates the Games
        {
            Reset(); //Resets everything in case of previous game

            //Get blocks width and height based on controller size :
            width = controller.Width / blockNumberX;   
            height = controller.Height / blockNumberY;

            //Get a random location for the power up block :
            int x_power = 0;
            int y_power = 0;
            try
            {
                x_power = (new Random()).Next(0, blockNumberX / 2 - 1);
                y_power = (new Random()).Next(0, blockNumberY / 2 - 1);
            }
            catch
            {
                MessageBox.Show("Can not create game");
                return;
            }

            //Put player in the middle of the arena :
            Player.Add(new int[] { blockNumberX / 2, blockNumberY / 2, 0, 0 });
            
            //Create blocks and build the arena :
            for (int i = 0; i < blockNumberX; i++)
            {
                for (int j = 0; j < blockNumberY; j++)
                {
                    foreach (int[] player in Player)
                    {
                        if (j == player[1] && i == player[0])
                        {
                            if (blocks.Get(i * width, j * height) != null)
                            {
                                blocks.Get(i * width, j * height).Color = Settings.HeadColor;
                            }
                            else
                            {
                                blocks.Add(Settings.HeadColor, width, height, i * width, j * height);
                            }
                        }
                        else if (j == y_power && i == x_power)
                        {
                            if (blocks.Get(i * width, j * height) != null)
                            {
                                blocks.Get(i * width, j * height).Color = Settings.PowerUpColor;
                                blocks.Get(i * width, j * height).Power = true;
                            }
                            else
                            {
                                blocks.Add(Settings.PowerUpColor, width, height, i * width, j * height, true);
                                blocks.Get(i * width, j * height).Power = true;
                            }
                        }
                        else
                        {
                            if (blocks.Get(i * width, j * height) != null)
                            {
                                blocks.Get(i * width, j * height).Color = Settings.StageColor;
                            }
                            else
                            {
                                blocks.Add(Settings.StageColor, width, height, i * width, j * height);
                            }
                        }
                    }
                }
            }
            displayBlocks();
            timer.Start();
        }
        private void displayBlocks()
        {
            foreach(Block b in blocks.Items)
            {
                b.Object.Parent = controller;
            }
            controller.Show();
        }
        private void update(object sender, EventArgs e)
        {
            int loop = Player.Count;
            bool powerup = false;

            //Prepare Movements :
            for (int j = loop - 1; j > 0; j--)
            {
                Player[j][2] = Player[j - 1][2];
                Player[j][3] = Player[j - 1][3];
            }
            Player[0][2] = xMove;
            Player[0][3] = yMove;

            //Make Movements :
            for (int i = 0; i < loop; i++)
            {
                Block tmp = blocks.Get(Player[i][0] * width, Player[i][1] * height);
                tmp.Color = Settings.StageColor;
                Player[i][0] += Player[i][2];
                Player[i][1] += Player[i][3];
                tmp = blocks.Get(Player[i][0] * width, Player[i][1] * height);
                if (tmp == null)
                {
                    if (wall)
                    {
                        gameOver();
                        return;
                    }
                    checkOutOrArena(i);
                }
                tmp = blocks.Get(Player[i][0] * width, Player[i][1] * height);
                if (tmp.Color == Settings.PlayerColor)
                {
                    Player[i][0] -= Player[i][2];
                    Player[i][1] -= Player[i][3];
                    checkOutOrArena(i);
                    tmp = blocks.Get(Player[i][0] * width, Player[i][1] * height);
                    tmp.Color = Settings.CollisionColor;
                    gameOver();
                    return;
                }
                if (i == 0)
                    tmp.Color = Settings.HeadColor;
                else
                    tmp.Color = Settings.PlayerColor;
                if (tmp.Power)
                {
                    powerup = true;
                    tmp.Power = false;
                }
            }
            if (powerup)
            {
                powerup = false;
                powerUp();
            }


        }
        private void gameOver()
        {
            if (GameOver != null) GameOver(this, EventArgs.Empty);
            timer.Stop();
            MessageBox.Show(Settings.LostMessage);
            controller.Hide();
            createGame();
        }
        private void powerUp()
        {
            Player.Add(new int[]
            {
                Player[Player.Count - 1][0] - Player[Player.Count - 1][2],
                Player[Player.Count - 1][1] - Player[Player.Count - 1][3],
                Player[Player.Count - 1][2],
                Player[Player.Count - 1][3]
            }
           );
            Block tmpBlock = blocks.Get(Player[Player.Count - 1][0] * width, Player[Player.Count - 1][1] * height);
            if (tmpBlock == null)
            {
                checkOutOrArena(Player.Count - 1, -1);
                tmpBlock = blocks.Get(Player[Player.Count - 1][0] * width, Player[Player.Count - 1][1] * height);
            }
            tmpBlock.Color = Settings.PlayerColor;
            if (blocks.Items.Exists(item => item.Color == Settings.StageColor))
            {
                List<Block> tmp = blocks.Items.FindAll(item => item.Color == Settings.StageColor);
                int R = (new Random()).Next(0, tmp.Count);
                tmp[R].Color = Settings.PowerUpColor;
                tmp[R].Power = true;
            }else
            {
                timer.Stop();
                MessageBox.Show(Settings.WonMessage);
                createGame();
            }
            //Increase score in case there is a label provided to display it
            if (scoreLabel != null)
            {
                score += score_increasement;
                scoreLabel.Text = score.ToString();
            }
            if (PowerUp != null) PowerUp(this, null);
        }
        private void checkOutOrArena(int blockID , int arrow = 1) //Checks whether the block is out of arena and if it is move it on the other side
        {
            if (Player[blockID][0] <  0            || 
                Player[blockID][0] >= blockNumberX || //Check if out of arena
                Player[blockID][1] >= blockNumberY || 
                Player[blockID][1] <  0)
            {
                //Put block on the other side of the arena
                if (Player[blockID][2] == 1 * arrow)
                {
                    Player[blockID][0] = 0;
                }
                else if (Player[blockID][2] == -1 * arrow)
                {
                    Player[blockID][0] = blockNumberX - 1;
                }
                else if (Player[blockID][3] == 1 * arrow)
                {
                    Player[blockID][1] = 0;
                }
                else if (Player[blockID][3] == -1 * arrow)
                {
                    Player[blockID][1] = blockNumberY - 1;
                }

            }
        }
        #endregion ----------------------------------------------
    }
}
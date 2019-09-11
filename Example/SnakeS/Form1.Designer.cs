namespace SnakeS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.difficulty = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Panel();
            this.topMostCheckbox = new System.Windows.Forms.CheckBox();
            this.gridCheckbox = new System.Windows.Forms.CheckBox();
            this.wallCheckbox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.textArt = new System.Windows.Forms.RichTextBox();
            this.score = new System.Windows.Forms.Label();
            this.best_score = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.bg_color_panel = new System.Windows.Forms.Panel();
            this.player_color_panel = new System.Windows.Forms.Panel();
            this.head_color_panel = new System.Windows.Forms.Panel();
            this.power_color_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficulty
            // 
            this.difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficulty.Location = new System.Drawing.Point(-3, 29);
            this.difficulty.Maximum = 1000;
            this.difficulty.Minimum = 10;
            this.difficulty.Name = "difficulty";
            this.difficulty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.difficulty.RightToLeftLayout = true;
            this.difficulty.Size = new System.Drawing.Size(824, 69);
            this.difficulty.TabIndex = 0;
            this.difficulty.TickStyle = System.Windows.Forms.TickStyle.None;
            this.difficulty.Value = 400;
            this.difficulty.Scroll += new System.EventHandler(this.Difficulty_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grid :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(65, 76);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 26);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Location = new System.Drawing.Point(181, 76);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(88, 26);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-3, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(824, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // options
            // 
            this.options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.options.Controls.Add(this.topMostCheckbox);
            this.options.Controls.Add(this.gridCheckbox);
            this.options.Controls.Add(this.wallCheckbox);
            this.options.Controls.Add(this.button1);
            this.options.Controls.Add(this.label1);
            this.options.Controls.Add(this.numericUpDown2);
            this.options.Controls.Add(this.numericUpDown1);
            this.options.Controls.Add(this.label3);
            this.options.Controls.Add(this.label2);
            this.options.Controls.Add(this.difficulty);
            this.options.Location = new System.Drawing.Point(0, 350);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(821, 149);
            this.options.TabIndex = 8;
            // 
            // topMostCheckbox
            // 
            this.topMostCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topMostCheckbox.AutoSize = true;
            this.topMostCheckbox.ForeColor = System.Drawing.Color.White;
            this.topMostCheckbox.Location = new System.Drawing.Point(571, 74);
            this.topMostCheckbox.Name = "topMostCheckbox";
            this.topMostCheckbox.Size = new System.Drawing.Size(97, 24);
            this.topMostCheckbox.TabIndex = 9;
            this.topMostCheckbox.Text = "TopMost";
            this.topMostCheckbox.UseVisualStyleBackColor = true;
            this.topMostCheckbox.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // gridCheckbox
            // 
            this.gridCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCheckbox.AutoSize = true;
            this.gridCheckbox.ForeColor = System.Drawing.Color.White;
            this.gridCheckbox.Location = new System.Drawing.Point(674, 74);
            this.gridCheckbox.Name = "gridCheckbox";
            this.gridCheckbox.Size = new System.Drawing.Size(65, 24);
            this.gridCheckbox.TabIndex = 8;
            this.gridCheckbox.Text = "Grid";
            this.gridCheckbox.UseVisualStyleBackColor = true;
            this.gridCheckbox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // wallCheckbox
            // 
            this.wallCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wallCheckbox.AutoSize = true;
            this.wallCheckbox.ForeColor = System.Drawing.Color.White;
            this.wallCheckbox.Location = new System.Drawing.Point(745, 74);
            this.wallCheckbox.Name = "wallCheckbox";
            this.wallCheckbox.Size = new System.Drawing.Size(73, 24);
            this.wallCheckbox.TabIndex = 7;
            this.wallCheckbox.Text = "Walls";
            this.wallCheckbox.UseVisualStyleBackColor = true;
            this.wallCheckbox.CheckedChanged += new System.EventHandler(this.WallCheckbox_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(745, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.BackColor = System.Drawing.Color.Black;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GamePanel.Location = new System.Drawing.Point(5, 38);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(813, 414);
            this.GamePanel.TabIndex = 9;
            this.GamePanel.Visible = false;
            // 
            // textArt
            // 
            this.textArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArt.BackColor = System.Drawing.Color.Black;
            this.textArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textArt.ForeColor = System.Drawing.Color.Red;
            this.textArt.Location = new System.Drawing.Point(12, 38);
            this.textArt.Name = "textArt";
            this.textArt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textArt.Size = new System.Drawing.Size(797, 310);
            this.textArt.TabIndex = 10;
            this.textArt.Text = "";
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.score.ForeColor = System.Drawing.Color.Red;
            this.score.Location = new System.Drawing.Point(94, 463);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(27, 29);
            this.score.TabIndex = 11;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score.Visible = false;
            // 
            // best_score
            // 
            this.best_score.AutoSize = true;
            this.best_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.best_score.ForeColor = System.Drawing.Color.Red;
            this.best_score.Location = new System.Drawing.Point(7, 3);
            this.best_score.Name = "best_score";
            this.best_score.Size = new System.Drawing.Size(205, 32);
            this.best_score.TabIndex = 12;
            this.best_score.Text = "Best Score : 0";
            // 
            // score_label
            // 
            this.score_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.score_label.ForeColor = System.Drawing.Color.Red;
            this.score_label.Location = new System.Drawing.Point(0, 463);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(96, 29);
            this.score_label.TabIndex = 13;
            this.score_label.Text = "Score: ";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_label.Visible = false;
            // 
            // bg_color_panel
            // 
            this.bg_color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bg_color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg_color_panel.Location = new System.Drawing.Point(775, 250);
            this.bg_color_panel.Name = "bg_color_panel";
            this.bg_color_panel.Size = new System.Drawing.Size(34, 17);
            this.bg_color_panel.TabIndex = 14;
            this.bg_color_panel.Tag = "bg_color";
            this.bg_color_panel.Click += new System.EventHandler(this.Color_Choose);
            // 
            // player_color_panel
            // 
            this.player_color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.player_color_panel.BackColor = System.Drawing.Color.LightGreen;
            this.player_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player_color_panel.Location = new System.Drawing.Point(775, 273);
            this.player_color_panel.Name = "player_color_panel";
            this.player_color_panel.Size = new System.Drawing.Size(34, 17);
            this.player_color_panel.TabIndex = 15;
            this.player_color_panel.Tag = "player_color";
            this.player_color_panel.Click += new System.EventHandler(this.Color_Choose);
            // 
            // head_color_panel
            // 
            this.head_color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.head_color_panel.BackColor = System.Drawing.Color.Green;
            this.head_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head_color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.head_color_panel.Location = new System.Drawing.Point(775, 296);
            this.head_color_panel.Name = "head_color_panel";
            this.head_color_panel.Size = new System.Drawing.Size(34, 17);
            this.head_color_panel.TabIndex = 16;
            this.head_color_panel.Tag = "head_color";
            this.head_color_panel.Click += new System.EventHandler(this.Color_Choose);
            // 
            // power_color_panel
            // 
            this.power_color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.power_color_panel.BackColor = System.Drawing.Color.LightSalmon;
            this.power_color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.power_color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.power_color_panel.Location = new System.Drawing.Point(775, 319);
            this.power_color_panel.Name = "power_color_panel";
            this.power_color_panel.Size = new System.Drawing.Size(34, 17);
            this.power_color_panel.TabIndex = 17;
            this.power_color_panel.Tag = "power_color";
            this.power_color_panel.Click += new System.EventHandler(this.Color_Choose);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Background";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Player";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Player Head";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Player Up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(821, 499);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.power_color_panel);
            this.Controls.Add(this.head_color_panel);
            this.Controls.Add(this.player_color_panel);
            this.Controls.Add(this.bg_color_panel);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.best_score);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.options);
            this.Controls.Add(this.textArt);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SnakeS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar difficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel options;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.CheckBox wallCheckbox;
        private System.Windows.Forms.CheckBox gridCheckbox;
        private System.Windows.Forms.RichTextBox textArt;
        private System.Windows.Forms.CheckBox topMostCheckbox;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label best_score;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Panel bg_color_panel;
        private System.Windows.Forms.Panel player_color_panel;
        private System.Windows.Forms.Panel head_color_panel;
        private System.Windows.Forms.Panel power_color_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


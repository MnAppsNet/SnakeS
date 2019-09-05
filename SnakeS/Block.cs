using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeS
{
    class Block
    {
        private int id;
        private int width;
        private int height;
        private int x = 0;
        private int y = 0;
        private System.Drawing.Color color;
        private System.Windows.Forms.Panel panel;

        public bool Power = false;

        public Block(int ID, int Width, int Height, System.Drawing.Color Color, int X = 0, int Y = 0, bool power = false)
        {
            id = ID;
            width = Width;
            height = Height;
            Power = power;
            x = X;
            y = Y;
            if (Color != null)
                color = Color;
            else
                color = System.Drawing.Color.White;
            createBlock();
        }
        public System.Windows.Forms.Panel Object
        {
            get { return panel; }
        }
        public int ID
        {
            get { return id;  }
            set { id = value; }
        }
        public System.Drawing.Color Color
        {
            get { return color;  }
            set { color = value; panel.BackColor = color; }
        }
        public System.Drawing.Point Location
        {
            get { return new System.Drawing.Point(x, y); }
            set { panel.Location = value; x = panel.Location.X; y = panel.Location.Y; }
        }
        private void createBlock()
        {
            panel = new System.Windows.Forms.Panel();
            panel.Name = "block_" + id.ToString();
            panel.Width = width;
            panel.Height = height;
            panel.BackColor = color;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Location = new System.Drawing.Point(x, y);
            panel.Tag = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeS
{
    class Settings
    {

        public static System.Drawing.Color PlayerColor = System.Drawing.Color.Black;
        public static System.Drawing.Color StageColor = System.Drawing.Color.White;
        public static System.Drawing.Color PowerUpColor = System.Drawing.Color.Orange;
        public static System.Drawing.Color CollisionColor = System.Drawing.Color.DarkRed;

        public static System.Windows.Forms.BorderStyle BlockStyle = System.Windows.Forms.BorderStyle.None;

        public static string LostMessage = "Be careful dude!";
        public static string WonMessage  = "You are a fucking legend!";

    }
}

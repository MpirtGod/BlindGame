using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2._0
{
    class Player
    {
        public int x;
        public int y;

        public Image playerSteps;

        public int speed;

        public int sizeX;
        public int sizeY;

        public Player(int x, int y)
        {
            playerSteps = new Bitmap(Properties.Resources.white_steps);
            this.x = x;
            this.y = y;
            sizeY = 20;
            sizeX = 23;
            speed = 12;
        }
    }
}

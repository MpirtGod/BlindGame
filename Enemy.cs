using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2._0
{
    class Enemy
    {
        public int x;
        public int y;
        public Image enemyPNG;
        public int speed;

        public int sizeX;
        public int sizeY;

        public Enemy(int x, int y)
        {
            enemyPNG = new Bitmap(Properties.Resources.enemy);
            this.x = x;
            this.y = y;
            sizeX = 28;
            sizeY = 28;
            speed = 10;
        }
    }
}

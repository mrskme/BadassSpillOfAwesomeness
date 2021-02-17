using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Enemy : BaseBox
    {
        private int _speed;
        public Enemy(int speed ,int width, int height, string name, int startX, int startY, Color color) : base(width, height, name, startX, startY, color)
        {
            _speed = speed;
        }

        public void MoveEnemy()
        {
            Left -= _speed;
        }
    }
}

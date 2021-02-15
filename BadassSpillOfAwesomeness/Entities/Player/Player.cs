using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Player : BaseBox
    {
        public Player(int width, int height, string name, int startX, int startY, Color color) : base(width, height, name, startX, startY, color)
        {
        }
    }
}

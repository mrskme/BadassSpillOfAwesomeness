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
        //hva skal en enemy ha? 
        public Enemy(int width, int height, string name, int startX, int startY, Color color) : base(width, height, name, startX, startY, color)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Enemies
    {
        public List<Enemy> Level1Enemies;
        public Enemies()
        {
            Level1Enemies = new List<Enemy>
            {
                new Enemy(20, 20, "bobby", 540, 420, Color.Black),
            };

        }
    }
}

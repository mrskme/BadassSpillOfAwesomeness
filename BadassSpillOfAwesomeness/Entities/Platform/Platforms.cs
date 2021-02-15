using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Platforms
    {
        public List<Platform> LevelOne;
        public List<Platform> LevelTwo;

        public Platforms()
        {
            LevelOne = new List<Platform>
            {
                new Platform(20,50,"Grass",21,62,Color.ForestGreen),
            };
        }

    }
}

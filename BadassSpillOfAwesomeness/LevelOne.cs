using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class LevelOne : Level
    {
        public List<Platform> Platforms;
        public LevelOne()
        {
            Platforms = platforms.LevelOne;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Levels
    {
        public List<Level> All;
        public LevelOne LevelOne;

        public Levels()
        {
            LevelOne = new LevelOne();

            All = new List<Level>
            {
                LevelOne,
            };
        }

    }
}

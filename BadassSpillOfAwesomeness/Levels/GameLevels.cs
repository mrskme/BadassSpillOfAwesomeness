using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class GameLevels
    {
        public List<GameLevel> All;
        public GameLevelOne GameLevelOne;

        public GameLevels()
        {
            GameLevelOne = new GameLevelOne();

            All = new List<GameLevel>
            {
                GameLevelOne,
            };
        }

    }
}

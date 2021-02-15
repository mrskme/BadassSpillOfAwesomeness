using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Game
    {
        public GameLevel CurrentGameLevel;
        public GameLevels GameLevels;

        public Game()
        {
            GameLevels = new GameLevels();
            CurrentGameLevel = GameLevels.All[0];

            CurrentGameLevel.SpawnLevel();
        }

        public void NextLevel()
        {
            CurrentGameLevel = GameLevels.All[/*NextLevelIndex*/0];
        }
    }
}

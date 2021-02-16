using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BadassSpillOfAwesomeness
{
    class Game
    {
        private GameLevel _currentGameLevel;
        private readonly GameLevels _gameLevels;
        private UpgradePanel _upgradePanel;


        public Game()
        {
            _gameLevels = new GameLevels();
            _currentGameLevel = _gameLevels.All[0];

            _currentGameLevel.SpawnLevel();
        }

        public GameLevel NextLevel() =>
        _gameLevels.All[/*NextLevelIndex*/0];
        
    }
}

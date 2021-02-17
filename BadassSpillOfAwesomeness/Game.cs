using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BadassSpillOfAwesomeness
{
    class Game
    {
        private readonly GameLevels _gameLevels;
        private UpgradePanel _upgradePanel;
        private readonly PlayerChoserPanel _playerChoserPanel;
        private Player Player => PlayerChoserPanel.ChosenPlayer;
        private GameLevel Current => _gameLevels.Current;
        private readonly Timers _timers;



        public Game()
        {
            _gameLevels = new GameLevels();
            _playerChoserPanel = new PlayerChoserPanel();
            _upgradePanel = new UpgradePanel();
            _timers = new Timers();
        }
        public void Run()
        {
            _timers.GameTimer.Start();
            _playerChoserPanel.AddPanelToWindow();
            _timers.SpawnLevelIfCharacterIsPicked.Start();
        }
    }
}

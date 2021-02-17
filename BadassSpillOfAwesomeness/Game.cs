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
        private readonly PlayerChoserPanel _playerChoserChoserPanel;
        private Player Player => _playerChoserChoserPanel.ChosenPlayer;
        private static System.Windows.Forms.Timer _timer;
        private static System.Windows.Forms.Timer _checkAndSpawnLevelTick;

        public Game()
        {
            _gameLevels = new GameLevels();
            _playerChoserChoserPanel = new PlayerChoserPanel();
            _upgradePanel = new UpgradePanel();
            _timer  = new System.Windows.Forms.Timer();
            _checkAndSpawnLevelTick = new System.Windows.Forms.Timer();
        }
        public void Run()
        {
            SetGameTimeTick();
            _playerChoserChoserPanel.AddPanelToWindow();
        }
        private void GameTimerTick(Object myObject, EventArgs myEventArgs)
        {
            if (Player != null)
            {
                _gameLevels.Current.AddPanelToWindow(Player);
            }
        }
        private void SetGameTimeTick()
        {
            _timer.Tick += new EventHandler(GameTimerTick);
            _timer.Interval = 50;
            _timer.Start();
        }

        private void SetCheckAndSpawnLevelTick()
        {
            _checkAndSpawnLevelTick.Tick += new EventHandler(CheckAndSpawnLevelTick);
            _timer.Interval = 50;
            _timer.Start();
        }

        private void CheckAndSpawnLevelTick(Object myObject, EventArgs myEventArgs)
        {
            if (Player != null)
            {
                _gameLevels.Current.AddPanelToWindow(Player);
                _checkAndSpawnLevelTick.Stop();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Timers
    {
        private readonly GameLevels _gamelevels;
        private Player _player => PlayerChoserPanel.ChosenPlayer;

        public readonly Timer GameTimer;
        public readonly Timer SpawnLevelIfCharacterIsPicked;
        public Timers()
        {
            _gamelevels = new GameLevels();
            GameTimer = new Timer(GameTimerTick, 50);
            SpawnLevelIfCharacterIsPicked = new Timer(CheckAndSpawnLevelTick, 50);
        }
        private void GameTimerTick(Object myObject, EventArgs myEventArgs)
        {
            if (_player != null) _gamelevels.Current.MoveEverything();
        }

        private void CheckAndSpawnLevelTick(Object myObject, EventArgs myEventArgs)
        {
            if (_player != null)
            {
                _gamelevels.Current.AddPanelToWindow();
                SpawnLevelIfCharacterIsPicked.Stop();
            }
        }
    }
}

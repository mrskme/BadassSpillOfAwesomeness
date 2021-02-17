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

        public readonly Timer GameTimer;
        public Timers()
        {
            _gamelevels = new GameLevels();
            GameTimer = new Timer(GameTimerTick, 50);
        }
        private void GameTimerTick(Object myObject, EventArgs myEventArgs)
        {
            _gamelevels.Current.MoveEverything();
        }
    }
}

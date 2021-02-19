using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BadassSpillOfAwesomeness
{
    class Game
    {
        private readonly GameLevels _gameLevels;
        public GameLevel Current => _gameLevels.Current;
        public readonly Timer GameTimer;

        public Game()
        {
            _gameLevels = new GameLevels(); 
            GameTimer = new Timer(GameTimerTick, 20);
        }
        private void GameTimerTick(Object myObject, EventArgs myEventArgs)
        {
            Current.MoveEverything();
        }
    }
}

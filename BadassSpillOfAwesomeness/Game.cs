using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BadassSpillOfAwesomeness
{
    class Game
    {
        private readonly GameLevels _gameLevels;
        public GameLevel Current => _gameLevels.Current;

        public Game()
        {
            _gameLevels = new GameLevels();
        }
    }
}

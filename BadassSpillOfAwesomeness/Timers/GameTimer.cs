using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class GameTimer : System.Windows.Forms.Timer
    {
        public GameTimer(EventHandler onTick, int interval)
        {
            Tick += onTick;
            Interval = interval;
        }
    }
}

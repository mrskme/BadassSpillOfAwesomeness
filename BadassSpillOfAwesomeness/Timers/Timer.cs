using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class Timer : System.Windows.Forms.Timer
    {
        public Timer(EventHandler onTick, int interval)
        {
            Tick += onTick;
            Interval = interval;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Button : System.Windows.Forms.Button
    {
        public Button(Color color,string text, int x, int y, int width, int height, EventHandler onClick)
        {
            BackColor = color;
            Text = text;
            Size = new Size(width, height);
            Click += onClick;
            Location = new Point(x,y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class BaseBox : PictureBox
    {
        private int _width;
        private int _height;
        private string _name;
        private readonly int _startX;
        private readonly int _startY;
        private readonly Color _color;
        public BaseBox( int width, int height, string name, int startX, int startY, Color color)
        {
            _width = width;
            _height = height;
            _name = name;
            _startX = startX;
            _startY = startY; 
            _color = color;

            Size = new Size(_height, _width);
            Location = new Point(_startX, _startY);
            BackColor = _color;
        }
    }
}

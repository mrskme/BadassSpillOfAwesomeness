using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class BaseBox
    {
        private readonly PictureBox _rectangle;
        private readonly int Width;
        private int Height;
        private string Name;
        private int StartX;
        private int StartY;
        private Color Color;
        //private int SpawnLevel;
        public BaseBox( int width, int height, string name, int startX, int startY, Color color)
        {
            Width = width;
            Height = height;
            Name = name;
            StartX = startX;
            StartY = startY; 
            Color = color;


            _rectangle = new PictureBox();
            _rectangle.Size = new Size(Height, Width);
            _rectangle.Location = new Point(StartX, StartY);
            _rectangle.BackColor = Color;
        }

        public void SpawnRectangle()
        {
            Form2.form2.Controls.Add(_rectangle);
        } 
    }
}

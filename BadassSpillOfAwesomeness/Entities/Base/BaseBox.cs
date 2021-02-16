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
        private readonly int Width;
        private int Height;
        private string Name;
        private int StartX;
        private int StartY;
        private Color Color;
        public BaseBox( int width, int height, string name, int startX, int startY, Color color)
        {
            Width = width;
            Height = height;
            Name = name;
            StartX = startX;
            StartY = startY; 
            Color = color;


            Size = new Size(Height, Width);
            Location = new Point(StartX, StartY);
            BackColor = Color;
        }

        public void SpawnRectangle()
        {
            Form2.form.Controls.Add(this);
        } 
    }
}

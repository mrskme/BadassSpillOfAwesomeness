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
        private PictureBox Rectangle;
        private int Width;
        private int Height;
        private string Name;
        private int StartX;
        private int StartY;
        private Color Color;
        private int SpawnLevel;
        public BaseBox( int width, int height, string name, int startX, int startY, Color color)
        {
            Width = width;
            Height = height;
            Name = name;
            StartX = startX;
            StartY = startY; 
            Color = color;


            Rectangle = new PictureBox();
            Rectangle.Size = new Size(Height, Width);
            Rectangle.Location = new Point(StartX, StartY);
            Rectangle.BackColor = Color;
        }

        public void SpawnRectangle()
        {
            Form2.form2.Controls.Add(Rectangle);
        } 
    }
}

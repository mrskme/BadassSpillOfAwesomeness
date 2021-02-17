using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BadassSpillOfAwesomeness
{
    class Player : BaseBox
    {
        private int _walkingSpeed;
        public Player(int walkingSpeed, int width, int height, string name, int startX, int startY, Color color) : base(width, height, name, startX, startY, color)
        {
            _walkingSpeed = walkingSpeed;
        }
        public void MovePlayer()
        {
            //var oldTop = Top;
            //var oldLeft = Left;

            if (Keyboard.IsKeyDown(Key.A)) Left -= _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.D)) Left += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.S)) Top += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.W)) Top -= _walkingSpeed;

            //if (IsObjectColliding(this))
            //{
            //    NewRectangle.Top = oldTop;
            //    NewRectangle.Left = oldLeft;
            //}
        }
    }
}

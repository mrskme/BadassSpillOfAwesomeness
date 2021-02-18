using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using Color = System.Drawing.Color;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace BadassSpillOfAwesomeness
{
    class Player : BaseBox
    {
        private int _walkingSpeed;
        private bool _moveUp, _moveDown, _moveLeft, _moveRight;

        public Player(int walkingSpeed, int width, int height, string name, int startX, int startY, Color color) : base(width, height, name, startX, startY, color)
        {
            _walkingSpeed = walkingSpeed;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
        }
        public void MovePlayer()
        {
            //var oldTop = Top;
            //var oldLeft = Left;

            //Keyboard.IsKeyDown() er the culprit 

            //if (Keyboard.IsKeyDown(Key.A) && Left > 0) Left -= _walkingSpeed;
            //if (Keyboard.IsKeyDown(Key.D) && Right < Window.window.Size.Width) Left += _walkingSpeed;
            //if (Keyboard.IsKeyDown(Key.S) && Bottom < Window.window.Size.Height) Top += _walkingSpeed;
            //if (Keyboard.IsKeyDown(Key.W) && Top > 0) Top -= _walkingSpeed;

            //if (IsObjectColliding(this))
            //{
            //    NewRectangle.Top = oldTop;
            //    NewRectangle.Left = oldLeft;
            //}
        }

        public void AlternateMovePlayer()
        {
            if (_moveLeft) Left -= _walkingSpeed;
            if (_moveRight) Left += _walkingSpeed;
            if (_moveUp) Top -= _walkingSpeed;
            if (_moveDown) Top += _walkingSpeed;
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _moveLeft = true;
            }
            if (e.KeyCode == Keys.D) 
            {
                _moveRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                _moveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                _moveDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                _moveRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                _moveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                _moveDown = false;
            }
        }
    }
}

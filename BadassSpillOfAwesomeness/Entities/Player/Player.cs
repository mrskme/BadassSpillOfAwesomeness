using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Input;
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
            if (_moveLeft)
            {
                Left -= _walkingSpeed;
                BackColor = Color.Red;
            }
            if (_moveRight) Left += _walkingSpeed;
            if (_moveUp) Top -= _walkingSpeed;
            if (_moveDown) Top += _walkingSpeed;
        }
        public void KeyIsDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.A)
            {
                _moveLeft = true;
            }
            if (key.KeyCode == Keys.D) 
            {
                _moveRight = true;
            }
            if (key.KeyCode == Keys.W)
            {
                _moveUp = true;
            }
            if (key.KeyCode == Keys.S)
            {
                _moveDown = true;
            }
        }
        public void KeyIsUp(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.A)
            {
                _moveLeft = false;
            }
            if (key.KeyCode == Keys.D)
            {
                _moveRight = false;
            }
            if (key.KeyCode == Keys.W)
            {
                _moveUp = false;
            }
            if (key.KeyCode == Keys.S)
            {
                _moveDown = false;
            }
        }
    }
}

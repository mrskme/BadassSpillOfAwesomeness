using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    public class Window : Form
    {
        //private IContainer components;
        public static Window window { get; private set; }
        private readonly GameView _gameView;
        public Window()
        {
            window = this;
            _gameView = new GameView();
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            SetWindowSpesifications();
            _gameView.View();
        }

        public void SetWindowSpesifications()
        {
            //FormBorderStyle = FormBorderStyle.None; //Bruk til å få fram top bar på hover top

            //components = new Container();
            //AutoScaleMode = AutoScaleMode.Font;
            Size = MaximumSize;
            WindowState = FormWindowState.Maximized;
            Text = "Badass Spill of Awesomeness";
        }
    }
}

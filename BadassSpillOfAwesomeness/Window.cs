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
        //private Timers _timers;

        public Window()
        {
            //_timers = new Timers();
            window = this;
            _gameView = new GameView();
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            SetWindowSpesifications();
            Controls.Add(_gameView);
            //StartGameTimer();
        }

        public void SetWindowSpesifications()
        {
            //FormBorderStyle = FormBorderStyle.None; //Bruk til å få fram top bar på hover top
            //components = new Container();
            //AutoScaleMode = AutoScaleMode.Font;
            //AutoSizeMode = AutoSizeMode.GrowOnly;
            //AutoScaleMode = AutoScaleMode.None;
            ////AutoSizeMode =
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            //MinimumSize = new Size(1400, 1400);
            //Size = new Size(20000, 20000);
            //Size = MaximumSize;
            //Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
            Text = "Badass Spill of Awesomeness";
        }
        //public void StartGameTimer()
        //{
        //    _timers.GameTimer.Start();
        //}
    }
}

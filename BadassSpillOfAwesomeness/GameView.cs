using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class GameView : Panel
    {
        private Game _game;
        private UpgradePanel _upgradePanel;
        private readonly PlayerChoserPanel _playerChoserPanel;
        private Timers _timers;

        //public event EventHandler<Player> CheckHasChosenCharacter;

        public GameView()
        {
            _game = new Game();
            _upgradePanel = new UpgradePanel();
            _playerChoserPanel = new PlayerChoserPanel();
            _timers = new Timers();
            View();
        }
        public void View()
        {
            Size = new Size(4000, 2000); //sus
            Controls.Add(_playerChoserPanel);
            UpdatePanels();
        }

        public void UpdatePanels()
        {
            _playerChoserPanel.CheckHasChosenCharacter += HasChosenCharacter;
        }

        private void HasChosenCharacter(object sender, Player e)
        {
            _playerChoserPanel.CheckHasChosenCharacter -= HasChosenCharacter;
            Controls.Remove(_playerChoserPanel);
            Controls.Add(_game.Current);
            StartGameTimer();
        }
        public void StartGameTimer()
        {
            _timers.GameTimer.Start();
        }
    }
}

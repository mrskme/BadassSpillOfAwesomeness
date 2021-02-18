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

        public GameView()
        {
            _upgradePanel = new UpgradePanel();
            _playerChoserPanel = new PlayerChoserPanel();
            View();
        }
        public void View()
        {
            Dock = DockStyle.Fill;
            /*Size = new Size(Window.window.Width, Window.window.Height); *///sus
            Controls.Add(_playerChoserPanel);
            UpdatePanels();
        }

        public void UpdatePanels()
        {
            _playerChoserPanel.UpdatePanelsEvent += UpdatePanelsEvent;
        }

        private void UpdatePanelsEvent(object sender, Player e)
        {
            _playerChoserPanel.UpdatePanelsEvent -= UpdatePanelsEvent;
            _game = new Game();
            Controls.Remove(_playerChoserPanel);
            Controls.Add(_game.Current);
            StartGameTimer();
        }
        public void StartGameTimer()
        {
            _game.GameTimer.Start();
            //Denne som fucker den med vindustørrelse
        }
    }
}

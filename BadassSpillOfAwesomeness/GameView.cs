using System;
using System.CodeDom;
using System.Collections.Generic;
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
            _game = new Game();
            _upgradePanel = new UpgradePanel();
            _playerChoserPanel = new PlayerChoserPanel();
        }
        public void View()
        {
            //_playerChoserPanel.AddPanelToWindow();
            Controls.Add(_playerChoserPanel);
        }

        public void AddComponentsToGame()
        {
            Controls.Add(_game.Current);
        }
    }
}

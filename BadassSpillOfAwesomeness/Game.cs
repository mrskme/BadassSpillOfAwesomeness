using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BadassSpillOfAwesomeness
{
    class Game
    {
        private readonly GameLevels _gameLevels;
        private UpgradePanel _upgradePanel;
        private readonly PlayerChoserPanel _playerChoserChoserPanel;
        private Player Player => _playerChoserChoserPanel.ChosenPlayer;
        private GameLevel CurrentLevel => _gameLevels.Current;

        public Game()
        {
            _gameLevels = new GameLevels();
            _playerChoserChoserPanel = new PlayerChoserPanel();
            _upgradePanel = new UpgradePanel();
        }

        public void Run()
        {
            //CurrentLevel.AddPanelToWindow();
            //CurrentLevel.RemovePanelFromWindow();
            _playerChoserChoserPanel.AddPanelToWindow();
            CurrentLevel.AddPanelToWindow(Player);
        }
    }
}

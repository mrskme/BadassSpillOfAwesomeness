using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class GameLevels
    {
        public List<GameLevel> All;
        public GameLevel LevelOne;

        private int _currentLevelIndex = 0;
        public GameLevel Current => All[_currentLevelIndex];

        public GameLevels()
        {
            LevelOne = CreateLevel1();
            All = new List<GameLevel>
            {
                LevelOne,
            };
        }
        private static GameLevel CreateLevel1()
        {
            var platforms = new List<Platform>
            {

            };
            var enemies = new List<Enemy>
            {
                new Enemy(15,20,20,"Henning",256,343, Color.Black),
                new Enemy(15,50,20,"hoho",50,50, Color.Gold),
                new Enemy(15,50,20,"haha",736,543, Color.Blue),
                new Enemy(15,50,20,"SirMuchAlot",300,300, Color.BlueViolet),
            };
            var levelOne = new GameLevel(platforms, enemies, Color.Aqua);
            return levelOne;
        }
        public GameLevel NextLevel() =>
            All[_currentLevelIndex+1];

        
    }
}

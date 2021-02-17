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


        private int _currentGameIndex = 0;
        public GameLevel Current => All[_currentGameIndex];

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
                new Enemy(20,20,"Henning",0,0, Color.Black),
                new Enemy(50,20,"hoho",50,50, Color.Blue),
                new Enemy(50,20,"haha",736,543, Color.Blue),
                new Enemy(50,20,"SirMuchAlot",300,300, Color.Blue),
            };
            var levelOne = new GameLevel(platforms, enemies) {BackColor = Color.Aqua};
            levelOne.AddEnemiesToLevel(enemies);
            levelOne.AddPlatformsToLevel(platforms);
            return levelOne;
        }
        public GameLevel NextLevel() =>
            All[_currentGameIndex+1];
    }
}

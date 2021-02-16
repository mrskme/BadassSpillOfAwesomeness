using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class GameLevelOne : GameLevel
    {
        public List<Platform> Platforms { get; }
        public List<Enemy> Enemies { get; }

        public GameLevelOne()
        {
            Platforms = new Platforms().LevelOne;
            Enemies = new Enemies().LevelOne;

            Entities = new List<List<BaseBox>>
            {
                Platforms,
                Enemies,
            };
        }
    }
}

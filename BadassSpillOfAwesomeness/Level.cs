using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class Level
    {
        //Skal ha alt som hører til bare et level
        public Platforms platforms;
        public Enemies enemies;

        public Level()
        {
            platforms = new Platforms();
        }
        public void SpawnLevel()
        {

        }
    }
}

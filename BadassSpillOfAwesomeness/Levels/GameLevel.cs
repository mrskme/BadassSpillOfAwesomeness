using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadassSpillOfAwesomeness
{
    class GameLevel
    {
        protected List<List<BaseBox>> Entities;

        public void SpawnLevel()
        {
            foreach (var List in Entities)
            {
                foreach (var box in List)
                {
                    box.SpawnRectangle();
                }
            }
        }
    }
}

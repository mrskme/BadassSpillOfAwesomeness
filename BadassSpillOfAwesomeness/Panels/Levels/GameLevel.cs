using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class GameLevel : Panel
    {
        public Platforms Platforms { get; }
        public Enemies Enemies { get; }
        public Player Player { get; private set; }

        public GameLevel(List<Platform> platforms, List<Enemy> enemies, Color color)
        {
            BackColor = color;
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            Platforms = new Platforms(platforms);
            Enemies = new Enemies(enemies);
            AddPlatformsToLevel(platforms);
            AddEnemiesToLevel(enemies);

            //ADD game level to window
        }
        //public void MoveEnemies()
        //{
        //    Enemies.Move();
        //}

        public void AddPanelToWindow()
        {
            Window.window.Controls.Add(this);
            Window.window.Controls.Add(Player);
        }

        public void RemovePanelFromWindow()
        {
            Window.window.Controls.Remove(this);
            Window.window.Controls.Remove(Player);
        }

        public void AddEnemiesToLevel(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                Controls.Add(enemy);
            }
        }
        public void AddPlatformsToLevel(List<Platform> platforms)
        {
            foreach (var platform in platforms)
            {
                Controls.Add(platform);
            }
        }//addPlatformsInConstructor? 

        //var plist = new List<Platform>();
        //List<BaseBox> blist;
        ////b = p;
        //blist = plist.Select(p => (BaseBox) p).ToList();
    }
}

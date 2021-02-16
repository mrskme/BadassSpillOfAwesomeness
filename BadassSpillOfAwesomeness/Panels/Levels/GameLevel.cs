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
        private Player _player;

        public GameLevel(List<Platform> platforms, List<Enemy> enemies)
        {
            Platforms = new Platforms(platforms);
            Enemies = new Enemies(enemies);
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            //ADD game level to window
        }
        //public void MoveEnemies()
        //{
        //    Enemies.Move();
        //}

        public void AddPanelToWindow(Player player)
        {
            _player = player;
            Form2.form.Controls.Add(this);
            Form2.form.Controls.Add(_player);
        }

        public void RemovePanelFromWindow()
        {
            Form2.form.Controls.Remove(this);
            Form2.form.Controls.Remove(_player);
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
        }
        //var plist = new List<Platform>();
        //List<BaseBox> blist;
        ////b = p;
        //blist = plist.Select(p => (BaseBox) p).ToList();
    }
}

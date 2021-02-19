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
        public Player Player => PlayerChoserPanel.ChosenPlayer;
        

        public GameLevel(List<Platform> platforms, List<Enemy> enemies, Color color)
        {
            BackColor = color;
            Dock = DockStyle.Fill;
            Platforms = new Platforms(platforms);
            Enemies = new Enemies(enemies);
            AddPlatformsToPanel(platforms);
            AddEnemiesToPanel(enemies);
            AddPlayerToPanel();


            //Show();
            //ADD game level to GameView
        }
        public void MoveEverything()
        {
            Player.AlternateMovePlayer();
            //Player?.MovePlayer();
            Enemies?.MoveEnemies();
        }
        public void AddEnemiesToPanel(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                Controls.Add(enemy);
            }
        }
        public void AddPlatformsToPanel(List<Platform> platforms)
        {
            foreach (var platform in platforms)
            {
                Controls.Add(platform);
            }
        }

        public void AddPlayerToPanel()
        {
            Controls.Add(Player);
        }
        //var plist = new List<Platform>();
        //List<BaseBox> blist;
        ////b = p;
        //blist = plist.Select(p => (BaseBox) p).ToList();
    }
}

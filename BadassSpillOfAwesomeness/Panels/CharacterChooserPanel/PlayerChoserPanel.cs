using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    class PlayerChoserPanel : Panel
    {
        private Player player1;
        private Player player2;
        private Player player3;

        public static Player ChosenPlayer = null;
        public PlayerChoserPanel()
        {
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.Aquamarine;
            player1 = new Player(200, 20, "Kåre", 530, 200, Color.Coral);
            player2 = new Player(200, 20, "Bobby", 530, 200, Color.BlueViolet);
            player3 = new Player(200, 20, "Bobbern", 530, 200, Color.DarkOrange);
            CreateButtons();
        }

        public void CreateButtons()
        {
            Button[] buttons =
            {
                new Button(Color.Aqua, "Kåre", 300, 200, 150,100, Player1ButtonOnClick),
                new Button(Color.Brown,"Bobby", 600, 200,150, 100, Player2ButtonOnClick),
                new Button(Color.CadetBlue,"Bobbern",900, 200, 150, 100, Player3ButtonOnClick),
            };
            AddButtonsToPanel(buttons);
        }

        public void AddButtonsToPanel(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                Controls.Add(button);
            } 
        }
        private void Player1ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player1;
            RemovePanelFromWindow();
        }
        private void Player2ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player2;
            RemovePanelFromWindow();
        }
        private void Player3ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player3;
            RemovePanelFromWindow();
        }

        public void AddPanelToWindow()
        {
            Window.window.Controls.Add(this);
        }

        public void RemovePanelFromWindow()
        {
            Window.window.Controls.Remove(this);
        }
    }
}

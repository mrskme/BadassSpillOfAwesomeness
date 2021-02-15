using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadassSpillOfAwesomeness
{
    public class Form2 : Form
    {
        //private IContainer components;
        public static Form2 form2 { get; private set; }
        public Form2()
        {
            form2 = this;
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            //FormBorderStyle = FormBorderStyle.None; Bruk til å få fram top bar på hover top

            //components = new Container();
            //AutoScaleMode = AutoScaleMode.Font;
            SetWindowSpesifications();
            TestSpawnBox();
        }

        public void SetWindowSpesifications()
        {
            WindowState = FormWindowState.Maximized;
            ClientSize = new Size(1344, 756);
            Text = "Badass Spill of Awesomeness";
        }
        public void TestSpawnBox()
        {
            var box = new BaseBox(200, 500, "kåre", 500, 500, Color.Blue);
            box.SpawnRectangle();
        }
    }
}

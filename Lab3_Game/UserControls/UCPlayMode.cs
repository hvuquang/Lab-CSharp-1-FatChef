using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Game.UserControls
{
    public partial class UCPlayMode : UserControl
    {
        private string _type;

        public UCPlayMode()
        {
            InitializeComponent();
        }

        public UCPlayMode(string type)
        {
            InitializeComponent();
            _type = type;
        }

        private void ucPlayingScreen2_back_click(object sender, EventArgs e)
        {
            // Handle the back_click event
            // Perform any desired actions
            this.Controls.Clear();
            UCHomeScreen screen = new UCHomeScreen();
            screen.Show();
            screen.BringToFront();
            screen.lbExit_click += Screen_lbExit_click;
            screen.lbColor_click += Screen_lbColor_click;
            screen.lbAnimal_click += Screen_lbAnimal_click;
            screen.lbFruit_click += Screen_lbFruit_click;
            this.Controls.Add(screen);
        }

        private void Screen_lbFruit_click(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayMode ucPlayMode = new UCPlayMode("fruit");
            ucPlayMode.Show();
            ucPlayMode.BringToFront();
            this.Controls.Add(ucPlayMode);
        }

        private void Screen_lbAnimal_click(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayMode ucPlayMode = new UCPlayMode("animal");
            ucPlayMode.Show();
            ucPlayMode.BringToFront();
            this.Controls.Add(ucPlayMode);
        }

        private void Screen_lbColor_click(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayMode ucPlayMode = new UCPlayMode("color");
            ucPlayMode.Show();
            ucPlayMode.BringToFront();
            this.Controls.Add(ucPlayMode);
        }

        private void Screen_lbExit_click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Screen_lbExit_click(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            
        }

        private void pbEasy_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayingScreen ucPlayingScreen2 = new UserControls.UCPlayingScreen(_type, "easy");
            ucPlayingScreen2.Show();
            ucPlayingScreen2.BringToFront();
            ucPlayingScreen2.back_click += ucPlayingScreen2_back_click;
            this.Controls.Add(ucPlayingScreen2);
        }

        private void pbMedium_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayingScreen ucPlayingScreen2 = new UserControls.UCPlayingScreen(_type, "medium");
            ucPlayingScreen2.Show();
            ucPlayingScreen2.BringToFront();
            ucPlayingScreen2.back_click += ucPlayingScreen2_back_click;
            this.Controls.Add(ucPlayingScreen2);
        }

        private void pbHard_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayingScreen ucPlayingScreen2 = new UserControls.UCPlayingScreen(_type, "hard");
            ucPlayingScreen2.Show();
            ucPlayingScreen2.BringToFront();
            ucPlayingScreen2.back_click += ucPlayingScreen2_back_click;
            this.Controls.Add(ucPlayingScreen2);
        }
    }
}

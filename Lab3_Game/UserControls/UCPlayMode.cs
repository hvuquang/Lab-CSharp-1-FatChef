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
            this.Controls.Add(screen);
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
            this.Controls.Add(ucPlayingScreen2);
        }

        private void pbHard_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayingScreen ucPlayingScreen2 = new UserControls.UCPlayingScreen(_type, "hard");
            ucPlayingScreen2.Show();
            ucPlayingScreen2.BringToFront();
            this.Controls.Add(ucPlayingScreen2);
        }
    }
}

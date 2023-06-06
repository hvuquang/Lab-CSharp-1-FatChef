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

        private void pbEasy_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCPlayingScreen ucPlayingScreen2 = new UserControls.UCPlayingScreen(_type, "easy");
            ucPlayingScreen2.Show();
            ucPlayingScreen2.BringToFront();
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

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
    public partial class UCPlayingScreen : UserControl
    {
        public event EventHandler<EventArgs> back_click;

        public UCPlayingScreen()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (back_click != null)
            {
                back_click.Invoke(this, e);
            }
        }
    }
}

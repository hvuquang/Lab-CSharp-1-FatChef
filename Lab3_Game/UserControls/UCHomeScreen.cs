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
    public partial class UCHomeScreen : UserControl
    {
        public event EventHandler<EventArgs> label2_click;
        public UCHomeScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2_click != null)
            {
                label2_click.Invoke(this, e);
            }
        }
    }
}

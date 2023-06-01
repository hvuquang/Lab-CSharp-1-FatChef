using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Game.UserControls
{
    public partial class UCDictionary : UserControl
    {
        public event EventHandler<EventArgs> lbback_click;
        public UCDictionary()
        {
            InitializeComponent();
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            if (lbback_click != null) { lbback_click.Invoke(sender, e); }
        }
    }
}

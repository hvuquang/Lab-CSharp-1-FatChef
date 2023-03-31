using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class UCLogIn : UserControl
    {
        Bitmap _view = Properties.Resources.view;
        Bitmap _hide = Properties.Resources.hide;
        public event EventHandler<EventArgs> LogInButton;
        public UCLogIn()
        {
            InitializeComponent();
            pbEye.Image = _view;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pbEye.Image == _view)
            {
                tbPass.UseSystemPasswordChar = false;
                pbEye.Image = _hide;
            } else if (pbEye.Image == _hide)
            {
                tbPass.UseSystemPasswordChar = true;
                pbEye.Image = _view;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogInButton != null)
            {
                LogInButton.Invoke(this, e);
            }
        }
    }
}

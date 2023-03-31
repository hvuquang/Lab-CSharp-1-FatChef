using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.UserControls
{

    public partial class UCRegister : UserControl
    {
        Bitmap _view = Properties.Resources.view;
        Bitmap _hide = Properties.Resources.hide;
        public UCRegister()
        {
            InitializeComponent();
            pbEye.Image = _view;
            pbEye1.Image = _view;
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (pbEye.Image == _view)
            {
                tbPass.UseSystemPasswordChar = false;
                pbEye.Image = _hide;
            }
            else if (pbEye.Image == _hide)
            {
                tbPass.UseSystemPasswordChar = true;
                pbEye.Image = _view;
            }
        }

        private void pbEye1_Click(object sender, EventArgs e)
        {
            if (pbEye1.Image == _view)
            {
                tbPass1.UseSystemPasswordChar = false;
                pbEye1.Image = _hide;
            }
            else if (pbEye1.Image == _hide)
            {
                tbPass1.UseSystemPasswordChar = true;
                pbEye1.Image = _view;
            }
        }
    }
}

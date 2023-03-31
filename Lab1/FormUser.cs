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
    public partial class FormUser : Form
    {
        Bitmap _view = Properties.Resources.view;
        Bitmap _hide = Properties.Resources.hide;

        public FormUser()
        {
            InitializeComponent();
            pbEye.Image = _view;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(255, 150, 64), ButtonBorderStyle.Solid);
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
            else
            { MessageBox.Show("Error"); }    
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form f = new FormHistory();
            f.ShowDialog();
        }
    }
}

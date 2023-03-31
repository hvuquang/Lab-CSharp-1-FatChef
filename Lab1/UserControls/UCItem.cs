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
    public partial class UCItem : UserControl
    {
        public event EventHandler UCItem_Click1;
        public event EventHandler btnOrder_Click1;
        public UCItem()
        {
            InitializeComponent();
        }

        private void UCItem_Click(object sender, EventArgs e)
        {
            if (UCItem_Click1 != null)
            {
                UCItem_Click1.Invoke(this, e);
            }
        }

        public void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder_Click1 != null)
            {
                btnOrder_Click1.Invoke(this, e);
            }
        }
        #region Getter & Setter for Labels, PictureBox
        private Image _icon;
        private string _title;
        private string _rate;
        private float _price;

        [Category("Custom Props")]
        public Image Icon { 
            get { return _icon; }
            set { _icon = value; pbIcon.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Rate
        {
            get { return _rate; }
            set { _rate = value; lbRate.Text = value; }
        }

        [Category("Custom Props")]
        public float Price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value.ToString(); }
        }

        #endregion

        private void btnOrder_MouseHover(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(255,209,76);
            btnOrder.ForeColor = Color.FromArgb(14, 23, 49);
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(255, 150, 64);
            btnOrder.ForeColor = Color.FromArgb(10, 15, 33);
        }
    }
}

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
    public partial class UCCartItem : UserControl
    {
        public UCCartItem()
        {
            InitializeComponent();
        }

        public event EventHandler UCCartItem_btnAdd_Hover;
        public event EventHandler UCCartItem_btnAdd_Leave;
        public event EventHandler UCCartItem_btnRemove_Hover;
        public event EventHandler UCCartItem_btnRemove_Leave;

        private string _title;
        private int _quantity;
        private float _price;
        private string _reference;
        private Image _image;

        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }
        public int Quantity { get { return _quantity; } set { _quantity = value; lbQuantity.Text = value.ToString(); } }
        public float Price { get { return _price; } set { _price = value; lbPrice.Text = value.ToString(); } }
         
        public string Reference { get { return _reference; } set { _reference = value; lbRef.Text = value; } }

        public Image Image { get { return _image; } set { _image = value; pbIcon.Image = value; } }


        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Image = Properties.Resources.add;
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Image = Properties.Resources.plus;
        }

        private void pbMinus_MouseLeave(object sender, EventArgs e)
        {
            pbMinus.Image = Properties.Resources.minus;
        }

        private void pbMinus_MouseHover(object sender, EventArgs e)
        {
            pbMinus.Image = Properties.Resources.minus_1_;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

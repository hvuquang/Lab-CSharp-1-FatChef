using Lab1.UserControls;
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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCCartItem[] listItems = new UCCartItem[5];

            string[] title = new string[5] { "The Other Woman", "HighKing", "StarDust", "Royal Daiquiri", "Hawaiian Ice Tea" };
            Image[] icons = new Image[5] { Properties.Resources.cock1, Properties.Resources.cock2, Properties.Resources.cock3, Properties.Resources.cock4, Properties.Resources.cock5 };
            float[] price = new float[5] { 30, 30, 30, 30, 30 };
            string[] refer = new string[5] { "Ref 10000000", "Ref 10000001", "Ref 10000002", "Ref 10000003", "Ref 10000004" };
            int[] quan = new int[5] { 3, 5, 9, 1, 2 };

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new UCCartItem();

                listItems[i].Image = icons[i];
                listItems[i].Title = title[i];
                listItems[i].Price = price[i];
                listItems[i].Reference = refer[i];
                listItems[i].Quantity = quan[i];

                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            #endregion
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lbName.Text = tbName.Text.Trim();
            if (lbName.Text == "")
            {
                lbName.Text = "Name";
            }
        }

        private void tbCard_TextChanged(object sender, EventArgs e)
        {
            string num = tbCard.Text.Trim();
            if (num.Length <= 0)
            {
                tbCard.BackColor = Color.White;
                pnCard.BackColor = Color.White;
                lbCard1.Text = ". . . .";
                lbCard2.Text = ". . . .";
                lbCard3.Text = ". . . .";
                lbCard4.Text = ". . . .";
            }
            else if (num.Length > 0 && num.Length <= 16)
            {
                tbCard.BackColor = Color.White;
                pnCard.BackColor = Color.White;
                if (num.Length > 0 && num.Length <= 4)
                {
                    lbCard1.Text = tbCard.Text;
                }
                else if (num.Length > 4 && num.Length <= 8)
                {
                    lbCard2.Text = num.Substring(4);
                }
                else if (num.Length > 8 && num.Length <= 12)
                {
                    lbCard3.Text = num.Substring(8);
                }
                else if (num.Length > 12 && num.Length <= 16)
                {
                    lbCard4.Text = num.Substring(12);
                }
            }
            else
            {
                tbCard.BackColor = Color.FromArgb(210, 4, 45);
                pnCard.BackColor = Color.FromArgb(210, 4, 45);
                MessageBox.Show("Number on Card must be 16 digits");
            }
        }

        private void dtpExpiredDate_ValueChanged(object sender, EventArgs e)
        {
            int m = dtpExpiredDate.Value.Month;
            int y = dtpExpiredDate.Value.Year;
            lbExpiredDate.Text = m + " / " + y;
        }

        private void tbCVV_TextChanged(object sender, EventArgs e)
        {
            string str = tbCVV.Text;
            if (str.Length > 3)
            {
                tbCard.BackColor = Color.FromArgb(210, 4, 45);
                pnCard.BackColor = Color.FromArgb(210, 4, 45);
                MessageBox.Show("Number on Card must have 3 digits");
            }
            else
            {
                tbCard.BackColor = Color.White;
                pnCard.BackColor = Color.White;
                lbCVV.Text = str;
            }
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}

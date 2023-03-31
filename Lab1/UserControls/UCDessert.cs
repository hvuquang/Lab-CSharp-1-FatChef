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
    public partial class UCDessert : UserControl
    {
        public UCDessert()
        {
            InitializeComponent();
        }

        public event EventHandler? ucDessert_Load;

        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCItem[] listItems = new UCItem[5];

            string[] title = new string[5] { "PASTEIS DE NATA", "TIRAMISU", "GULAB JAMUN", "LAMINGTONS", "RUM CAKE" };
            Image[] icons = new Image[5] { Properties.Resources.des1, Properties.Resources.des2, Properties.Resources.des3, Properties.Resources.des4, Properties.Resources.des5 };
            float[] price = new float[5] { 15, 17, 11, 20, 22 };
            string[] rate = new string[5] { "10", "9.5", "8.6", "8.1", "10" };

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new UCItem();

                listItems[i].Icon = icons[i];
                listItems[i].Title = title[i];
                listItems[i].Price = price[i];
                listItems[i].Rate = rate[i];

                listItems[i].btnOrder_Click1 += UCDessert_btnOrder_Click1;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            #endregion
        }

        private void UCDessert_btnOrder_Click1(object? sender, EventArgs e)
        {
            Form frm = new FormDetail();
            frm.ShowDialog();
        }

        private void UCDessert_Load(object sender, EventArgs e)
        {
            if (ucDessert_Load != null)
            {
                ucDessert_Load.Invoke(this, e);
                GenerateDynamicUserControl();
            }
        }
    }
}

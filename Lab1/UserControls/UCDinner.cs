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
    public partial class UCDinner : UserControl
    {
        public UCDinner()
        {
            InitializeComponent();
        }

        public event EventHandler? ucDinner_Load;

        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCItem[] listItems = new UCItem[9];

            string[] title = new string[9] { "Ramen", "Tom Yam Goong", "Kebab", "Pho", "Paella", "Apfelstrudel", "Pad Thai", "Chili crab", "Piri - piri chicken"};
            Image[] icons = new Image[9] { Properties.Resources.dinner1, Properties.Resources.dinner2, Properties.Resources.dinner3, Properties.Resources.dinner4,
            Properties.Resources.dinner5, Properties.Resources.dinner6, Properties.Resources.dinner7, Properties.Resources.dinner8, Properties.Resources.dinner9};
            float[] price = new float[9] { 30, 24, 35, 30, 40, 36, 18, 26, 29 };
            string[] rate = new string[9] { "10", "9.5", "8.6", "8.1", "10", "8.7", "6.5", "8.4", "5.8" };

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new UCItem();

                listItems[i].Icon = icons[i];
                listItems[i].Title = title[i];
                listItems[i].Price = price[i];
                listItems[i].Rate = rate[i];

                listItems[i].btnOrder_Click1 += UCDinner_btnOrder_Click1;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            #endregion
        }

        private void UCDinner_btnOrder_Click1(object? sender, EventArgs e)
        {
            Form frm = new FormDetail();
            frm.ShowDialog();
        }

        private void UCDinner_Load(object sender, EventArgs e)
        {
            if (ucDinner_Load != null)
            {
                ucDinner_Load.Invoke(this, e);
                GenerateDynamicUserControl();
            }
        }
    }
}

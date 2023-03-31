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
    public partial class UCGolden : UserControl
    {
        public event EventHandler? ucGolden_Load;
        public UCGolden()
        {
            InitializeComponent();
        }

        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCItem[] listItems = new UCItem[1];

            string[]title = new string[1] {"Combo 1"};
            Image[]icons = new Image[1] { Properties.Resources.Dame_credit_Evan_Sung };
            float[]price = new float[1] {100};
            string[] rate = new string[1] { "10"};

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new UCItem();

                listItems[i].Icon = icons[i];
                listItems[i].Title = title[i];
                listItems[i].Price = price[i];
                listItems[i].Rate = rate[i];

                listItems[i].btnOrder_Click1 += UCCocktail_btnOrder_Click1; ;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            #endregion
        }

        private void UCCocktail_btnOrder_Click1(object? sender, EventArgs e)
        {
            Form frm = new FormDetail();
            frm.ShowDialog();
        }

        private void UCGolden_Load(object sender, EventArgs e)
        {
            if (ucGolden_Load != null)
            {
                ucGolden_Load.Invoke(this, e);
                GenerateDynamicUserControl();
            }
        }
    }
}

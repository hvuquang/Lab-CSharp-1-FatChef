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
    public partial class UCCocktail : UserControl
    {
        public event EventHandler? ucCockTail_Load;
        public UCCocktail()
        {
            InitializeComponent();
        }

        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCItem[] listItems = new UCItem[5];

            string[]title = new string[5] {"The Other Woman", "HighKing", "StarDust", "Royal Daiquiri","Hawaiian Ice Tea"};
            Image[]icons = new Image[5] {Properties.Resources.cock1, Properties.Resources.cock2, Properties.Resources.cock3, Properties.Resources.cock4, Properties.Resources.cock5 };
            float[]price = new float[5] { 10, 8, 11, 15, 10 };
            string[] rate = new string[5] { "10", "9.5", "8.6", "8.1", "10" };

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

        private void UCCocktail_Load(object sender, EventArgs e)
        {
            if (ucCockTail_Load != null)
            {
                ucCockTail_Load.Invoke(this, e);
                GenerateDynamicUserControl();
            }

        }
    }
}

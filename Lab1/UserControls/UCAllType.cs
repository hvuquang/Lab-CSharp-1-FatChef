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
    public partial class UCAllType : UserControl
    {
        public event EventHandler? ucAllType_Load;
        public UCAllType()
        {
            InitializeComponent();

        }


        #region Function To Generate Dynamic UserControl
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UCItem[] listItems = new UCItem[20];

            string[] title = new string[20] { "The Other Woman", "HighKing", "StarDust", "Royal Daiquiri", "Hawaiian Ice Tea", "Ramen", "Tom Yam Goong", "Kebab", "Pho", "Paella", "Apfelstrudel", "Pad Thai", "Chili crab", "Piri - piri chicken",
            "PASTEIS DE NATA", "TIRAMISU", "GULAB JAMUN", "LAMINGTONS", "RUM CAKE", "Combo 1"};
            Image[] icons = new Image[20] { Properties.Resources.cock1, Properties.Resources.cock2, Properties.Resources.cock3, Properties.Resources.cock4, Properties.Resources.cock5,
            Properties.Resources.dinner1, Properties.Resources.dinner2, Properties.Resources.dinner3, Properties.Resources.dinner4,
            Properties.Resources.dinner5, Properties.Resources.dinner6, Properties.Resources.dinner7, Properties.Resources.dinner8, Properties.Resources.dinner9,
             Properties.Resources.des1, Properties.Resources.des2, Properties.Resources.des3, Properties.Resources.des4, Properties.Resources.des5, Properties.Resources.Dame_credit_Evan_Sung};
            float[] price = new float[20] { 10, 8, 11, 15, 10, 30, 24, 35, 30, 40, 36, 18, 26, 29, 15, 17, 11, 20, 22, 100 };
            string[] rate = new string[20] { "10", "9.5", "8.6", "8.1", "10", "10", "9.5", "8.6", "8.1", "10", "8.7", "6.5", "8.4", "5.8" , "10", "9.5", "8.6", "8.1", "10", "10" };

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new UCItem();

                listItems[i].Icon = icons[i];
                listItems[i].Title = title[i];
                listItems[i].Price = price[i];
                listItems[i].Rate = rate[i];

                listItems[i].btnOrder_Click1 += UCAllType_btnOrder_Click1;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            #endregion
        }

        private void UCAllType_btnOrder_Click1(object? sender, EventArgs e)
        {
            Form frm = new FormDetail();
            frm.ShowDialog();
        }

        private void UCAllType_Load(object sender, EventArgs e)
        {
            if (ucAllType_Load != null)
            {
                ucAllType_Load.Invoke(this, e);
                GenerateDynamicUserControl();
            }
        }
    }

}

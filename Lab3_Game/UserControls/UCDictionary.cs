using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Game.UserControls
{
    public partial class UCDictionary : UserControl
    {
        public event EventHandler<EventArgs> lbback_click;
        public event EventHandler<EventArgs> ucDictionary_load;
        public UCDictionary()
        {
            InitializeComponent();
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            if (lbback_click != null) { lbback_click.Invoke(sender, e); }
        }

        private void UCDictionary_Load(object sender, EventArgs e)
        {
            if (ucDictionary_load != null) { ucDictionary_load.Invoke(sender, e); ReadFile(); }
        }

        private void ReadFile()
        {
            //Image image1 = Properties.Resources._1;
            //Image image2 = Properties.Resources._22;
            //Image image3 = Properties.Resources._3;
            //Image image4 = Properties.Resources._4;
            //Image image5 = Properties.Resources._5;
            //Image image6 = Properties.Resources._6;
            //Image image7 = Properties.Resources._7;
            String str = File.ReadAllText("fruit.txt");

            //var imageList = new ImageList();
            //imageList.ImageSize = new Size(120, 120);
            //imageList.Images.Add(image1);
            //imageList.Images.Add(image2);
            //imageList.Images.Add(image3);
            //imageList.Images.Add(image4);
            //imageList.Images.Add(image5);
            //imageList.Images.Add(image6);
            //imageList.Images.Add(image7);
            //listView1.LargeImageList = imageList;
            if (str != "")
            {
                String[] items = str.Split('\n');
                MessageBox.Show(items.Length.ToString());
                for (int i = 0; i < items.Length; i++)
                {
                        UCWord UCWord = new UCWord(items[i]);
                        flowLayoutPanel1.Controls.Add(UCWord);
                }
            }
        }

    }
}

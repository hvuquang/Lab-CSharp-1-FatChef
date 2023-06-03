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

        private string type;
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
            String str = "";
            flowLayoutPanel1.Controls.Clear();
            if (type == "fruit")
            {
                str = File.ReadAllText("fruit.txt");
            }
            else if (type == "color")
            {
                str = File.ReadAllText("color.txt");
            }
            else if (type == "animal")
            {
                str = File.ReadAllText("animal.txt");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            type = "fruit";
            ReadFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = "color";
            ReadFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = "animal";
            ReadFile();
        }
    }
}

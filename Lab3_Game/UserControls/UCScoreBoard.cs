using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Game.UserControls
{
    public partial class UCScoreBoard : UserControl
    {
        private int stt = 1;
        //chưa click


        public UCScoreBoard()
        {
            InitializeComponent();
        }

        private void btnFruitScoreBoard_Click(object sender, EventArgs e)
        {
            lvScoreboard.Items.Clear();
            string str = File.ReadAllText("fruitscoreboard.txt");
            string[] itemsInFile = str.Split("\n");
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(stt.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }
        }

        private void btnColorScoreboard_Click(object sender, EventArgs e)
        {
            lvScoreboard.Items.Clear();
            string str = File.ReadAllText("colorscoreboard.txt");
            string[] itemsInFile = str.Split("\n");
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(stt.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }

        }

        private void btnAnimalScoreboard_Click(object sender, EventArgs e)
        {
            lvScoreboard.Items.Clear();
            string str = File.ReadAllText("animalscoreboard.txt");
            string[] itemsInFile = str.Split("\n");
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(stt.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }

        }
    }
}

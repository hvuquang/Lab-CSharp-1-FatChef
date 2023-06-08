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
            if (str == null) return;
            string[] itemsInFile = str.Split("\n");
            itemsInFile = BubbleSort(itemsInFile);
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(i.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }
        }

        private void btnColorScoreboard_Click(object sender, EventArgs e)
        {
            lvScoreboard.Items.Clear();
            string str = File.ReadAllText("colorscoreboard.txt");
            if (str == null) return;
            string[] itemsInFile = str.Split("\n");
            itemsInFile = BubbleSort(itemsInFile);
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(i.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }

        }

        private void btnAnimalScoreboard_Click(object sender, EventArgs e)
        {
            lvScoreboard.Items.Clear();
            string str = File.ReadAllText("animalscoreboard.txt");
            if (str == null) return;
            string[] itemsInFile = str.Split("\n");
            itemsInFile = BubbleSort(itemsInFile);
            for (int i = 0; i < itemsInFile.Length; i++)
            {
                if (itemsInFile[i] == "") break;
                string[] itemInItems = itemsInFile[i].Split("\t");
                ListViewItem item = new ListViewItem(i.ToString()); // Create a new ListViewItem with the value of Property1
                stt++;
                // Add sub-items for each property to populate the columns
                item.SubItems.Add(itemInItems[1]); // Add sub-item with the value of Property2
                item.SubItems.Add(itemInItems[0]); // Add sub-item with the value of Property3
                item.SubItems.Add(itemInItems[2]); // Add sub-item with the value of Property4
                // Add the item to the ListView
                lvScoreboard.Items.Add(item);
            }

        }

        public static string[] BubbleSort(string[] array)
        {
            int length = array.Length;
            bool swapped;

            for (int i = 0; i < length - 1; i++)
            {
                swapped = false;
                // Compare adjacent elements and swap them if they are in the wrong order
                for (int j = 0; j < length - i - 1; j++)
                {
                    string[] itemInItems1 = array[j].Split("\t");
                    int score1 = Int32.Parse(itemInItems1[0]);
                    if (j + 1 >= length - i - 1) break;
                    string[] itemInItems2 = array[j + 1].Split("\t");
                    int score2 = Int32.Parse(itemInItems2[0].Trim());
                    if (score1 < score2)
                    {
                        MessageBox.Show(score1.ToString());
                        // Swap array[j] and array[j+1]
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                    break;
            }
            return array;

        }

    }
}

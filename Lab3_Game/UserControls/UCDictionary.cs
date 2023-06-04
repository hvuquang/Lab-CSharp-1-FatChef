using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private string type = "fruit";
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

        private void WriteFile(String str)
        {
            if (type == "animal")
            {
                File.AppendAllText("animal.txt", "\n" + str);
            }
            else if (type == "fruit")
            {
                File.AppendAllText("fruit.txt", "\n" + str);
            }
            else if (type == "color")
            {
                File.AppendAllText("color.txt", "\n" + str);
            }
            MessageBox.Show("Tạo thành công");
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

        private void button4_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //DialogResult result = openFileDialog.ShowDialog();
            //string destinationFolder = @"C:\Users\HP\Documents\GitHub\Lab-CSharp-1-FatChef\Lab3_Game\bin\Debug\Animals";
            //if (result == DialogResult.OK)
            //{
            //    // Retrieve the selected file paths
            //    string selectedFilePath = @openFileDialog.FileName;

            //    // Get the file name from the selected file path
            //    string fileName = Path.GetFileName(selectedFilePath);

            //    //get type of image
            //    string[] typeImage = fileName.Split(".");
            //    //get the name from fileName textbox + type
            //    string newFileName = tbNewWord.Text + "." + typeImage[1];

                
            //    // Construct the destination file path
            //    string destinationFilePath = Path.Combine(destinationFolder, newFileName);

            //    // Copy the file to the destination folder
            //    File.Copy(selectedFilePath, destinationFilePath, true);

            //    WriteFile(destinationFilePath);

            //    MessageBox.Show("File copied successfully.");
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string destinationFolder = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if (type == "fruit")
            {
                destinationFolder = @"C:\Users\HP\Documents\GitHub\Lab-CSharp-1-FatChef\Lab3_Game\bin\Debug\Fruits";
            }
            else if (type == "animal")
            {
                destinationFolder = @"C:\Users\HP\Documents\GitHub\Lab-CSharp-1-FatChef\Lab3_Game\bin\Debug\Animals";
            }
            else if (type == "color")
            {
                destinationFolder = @"C:\Users\HP\Documents\GitHub\Lab-CSharp-1-FatChef\Lab3_Game\bin\Debug\Colors";
            }
            if (result == DialogResult.OK)
            {
                // Retrieve the selected file paths
                string selectedFilePath = @openFileDialog.FileName;

                // Get the file name from the selected file path
                string fileName = Path.GetFileName(selectedFilePath);

                //get type of image
                string[] typeImage = fileName.Split(".");
                //get the name from fileName textbox + type
                string newFileName = tbNewWord.Text + "." + typeImage[1];


                // Construct the destination file path
                string destinationFilePath = Path.Combine(destinationFolder, newFileName);

                // Copy the file to the destination folder
                File.Copy(selectedFilePath, destinationFilePath, true);

                WriteFile(destinationFilePath);

                MessageBox.Show("File copied successfully.");
            }
        }
    }
}

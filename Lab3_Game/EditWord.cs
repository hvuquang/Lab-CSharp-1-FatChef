using Lab3_Game.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Game
{
    public partial class EditWord : Form
    {
        private string _location;
        private string _typeOfImage;
        private string _file;
        private string _newName;

        public EditWord()
        {
            InitializeComponent();
        }

        public EditWord(string location, string file, string _typeOfImage)
        {
            InitializeComponent();
            button1.Visible = false;
            _location = location;
            this._typeOfImage = _typeOfImage;
            _file = file;
            ucDictionary1.Hide();
            ucHomeScreen1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Controls.Clear();
            editNewWord(_file);
            ucHomeScreen1.Hide();
            ucDictionary1.Show();
            ucDictionary1.BringToFront();
        }

        private void editNewWord(string file)
        {
            _newName = tbNewWord.Text;
            _newName += "." + _typeOfImage;
            deleteWord(file);
             string imagePath = _location;

            if (imagePath == "" || imagePath == "\n") return;
            else
            {
                imagePath = imagePath.Replace("\r", "");
                string imageDirectory = Path.GetDirectoryName(imagePath);
                imageDirectory = imageDirectory.Replace("\r", "");
                string newImagePath = Path.Combine(imageDirectory, _newName);
                newImagePath = newImagePath.Replace("\r", "");
                File.Move(imagePath, newImagePath);
                deleteWord(file);
                WriteFile(newImagePath);
                MessageBox.Show("Image renamed successfully.");
                this.Close();
            }
        }

        private void deleteWord(string file)
        {
            string str = "";
            str = File.ReadAllText(file);
            string newStr = "";
            String[] items = str.Split('\n');

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != _location)
                {
                    newStr += items[i] + "\n";
                    if (i == items.Length - 1)
                    {
                        newStr += items[i];
                    }
                }
                File.WriteAllText(file, newStr);
            }
        }

        private void WriteFile(String str)
        {
            if (_file == "animal.txt")
            {
                File.AppendAllText("animal.txt", "\n" + str);
            }
            else if (_file == "fruit.txt")
            {
                File.AppendAllText("fruit.txt", "\n" + str);
            }
            else if (_file == "color.txt")
            {
                File.AppendAllText("color.txt", "\n" + str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            editNewWord(_file);
            UCDictionary dictionary = new UCDictionary();
            dictionary.Show();
            dictionary.BringToFront();
            this.Controls.Add(dictionary);
        }

        private void ucDictionary1_lbback_click(object sender, EventArgs e)
        {
            MessageBox.Show("Run");
            ucDictionary1.Hide();
            ucHomeScreen1.Show();
            ucHomeScreen1.BringToFront();
        }
    }
}

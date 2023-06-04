using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Game.UserControls
{
    public partial class UCWord : UserControl
    {
        private string _word;
        private string _location;

        private string _type;

        public event EventHandler btnCancel_deleteWord;

        public string Word { get { return _word; } set { _word = value; lbTitle.Text = value; } }
        public string Location { get { return _location; } set { _location = value;} }

        public string Type { get { return _type; } set { _type = value; } }

        public UCWord()
        {
            InitializeComponent();
        }

        public UCWord(string location, string type)
        {
            InitializeComponent();
            //get the name, location of the Word
            string imagePath = @location;
            if (imagePath == "" || imagePath == "\n") return;
            else
            {
                string fileName = Path.GetFileName(imagePath);
                char delimiter = '.';
                string[] substrings = fileName.Split(delimiter);
                //set
                this.Location = location;
                this.Word = substrings[0];
                this.Type = type;
                //set  the image for pb
                imagePath = imagePath.Replace("\r", "");
                Image image = Image.FromFile(imagePath);
                pbTuVung.Image = image;
                pbTuVung.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string file = "";
            if (Type == "fruit")
            {
                deleteWord("fruit.txt");
            }
            else if (Type == "color")
            {
                deleteWord("color.txt");
            }
            else if (Type == "animal")
            {
                deleteWord("animal.txt");
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
                if (items[i] != Location)
                {
                    newStr += items[i] + "\n";
                    if (i == items.Length - 1)
                    {
                        newStr += items[i];
                    }
                }
                File.WriteAllText(file, newStr);
            }
            MessageBox.Show("Delete word successfully");
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

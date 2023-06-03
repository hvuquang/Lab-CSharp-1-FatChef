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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Game.UserControls
{
    public partial class UCWord : UserControl
    {
        private string _word;
        private string _location;


        public string Word { get { return _word; } set { _word = value; lbTitle.Text = value; } }
        public string Location { get { return _location; } set { _location = value;} }

        public UCWord()
        {
            InitializeComponent();
        }

        public UCWord(string location)
        {
            InitializeComponent();
            string imagePath = @location;
            string fileName = Path.GetFileName(imagePath);
            char delimiter = '.';
            string[] substrings = fileName.Split(delimiter);
            this.Location = location;
            this.Word = substrings[0];
            imagePath = imagePath.Replace("\r", "");
            Image image = Image.FromFile(imagePath);
            pbTuVung.Image = image;
            pbTuVung.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

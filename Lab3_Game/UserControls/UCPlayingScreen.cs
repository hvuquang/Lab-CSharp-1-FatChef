using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Game.UserControls
{
    public partial class UCPlayingScreen : UserControl
    {
        public event EventHandler<EventArgs> back_click;
        public bool isMute = false;

        private string _type;

        public string Type { get { return _type; } set { _type = value; } }

        private string[] questions;

        public UCPlayingScreen()
        {
            InitializeComponent();
        }

        public UCPlayingScreen(string type)
        {
            InitializeComponent();
            Type = type;
            questions = new string[5];
            ReadFile(Type);
        }
        private void ReadFile(string type)
        {
            String str = "";
            int j = 0;
            string file = "";

            if (type == "fruit")
            {
                file = "fruit.txt";

            }
            else if (type == "color")
            {
                file = "color.txt";
            }
            else if (type == "animal")
            {
                file = "animal.txt";
            }
            str = File.ReadAllText(file);
            if (str != "")
            {
                String[] items = str.Split('\n');
                int[] validStrInFile = new int[items.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == "\n" || items[i] == "") continue;
                    else
                    {
                        validStrInFile[j] = i;
                        j++;
                    }
                }
                Random random = new Random();
                int[] hasNumberInQuestions = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    //random biến chạy trong chuỗi
                    int randomItem = random.Next(0, validStrInFile.Length - 1);
                    //lấy random giá trị
                    int valueRandomItem = validStrInFile[randomItem];
                    //xóa giá trị đã lấy
                    validStrInFile = validStrInFile.Where(n => n != valueRandomItem).ToArray();
                    questions[i] = items[valueRandomItem];
                }
            }
            MessageBox.Show(questions[1]);
            MessageBox.Show(questions[2]);
            MessageBox.Show(questions[3]);
            MessageBox.Show(questions[4]);
            MessageBox.Show(questions[0]);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (back_click != null)
            {
                back_click.Invoke(this, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string soundFilePath = "C:\\Users\\HP\\Documents\\GitHub\\Lab-CSharp-1-FatChef\\nhacgame01.wav";
            SoundPlayer player = new SoundPlayer(soundFilePath);
            isMute = !isMute;
            if (isMute) // true
            {
                pictureBox2.Image = Properties.Resources.audio_speaker_on;
                player.Play();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.mute;
                player.Stop();
            }
        }
    }
}

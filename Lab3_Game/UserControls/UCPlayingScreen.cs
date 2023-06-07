using Microsoft.EntityFrameworkCore.Migrations;
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
        private string fileName = "";
        private int increImage = 0;
        private int score = 0;
        private int correctAnswer = 0;
        private string mode = "";
        private Image wrongImg = Properties.Resources.wrong;
        private int countdownSeconds = 60;
        private int remainingSeconds;
        private int[] hintChar;
        private int iOfHintChar = 0;
        public UCPlayingScreen()
        {
            InitializeComponent();
        }

        public UCPlayingScreen(string type)
        {
            InitializeComponent();
            Type = type;
            questions = new string[5];
            increImage = 0;
            pbIsCorrect1.Visible = false;
            pbIsCorrect2.Visible = false;
            pbIsCorrect3.Visible = false;
            pbIsCorrect4.Visible = false;
            pbIsCorrect5.Visible = false;
            ReadFile(Type);
            loadQuestion();
        }

        public UCPlayingScreen(string type, string mode)
        {
            InitializeComponent();
            Type = type;
            questions = new string[5];
            increImage = 0;
            pbIsCorrect1.Visible = false;
            pbIsCorrect2.Visible = false;
            pbIsCorrect3.Visible = false;
            pbIsCorrect4.Visible = false;
            pbIsCorrect5.Visible = false;
            remainingSeconds = countdownSeconds;
            playModeUI(mode);
            ReadFile(Type);
            loadQuestion();

        }

        private void updateCountDownLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingSeconds);
            string formattedTime = timeSpan.ToString(@"mm\:ss");

            countdownLabel.Text = formattedTime;
        }

        private void playModeUI(string mode)
        {
            pictureBox1.Hide();
            this.mode = mode;
            if (mode == "easy")
            {
                countdownLabel.Visible = false;
            }
            else if (mode == "medium")
            {
                lbHint.Visible = false;
                countdownLabel.Visible = false;
            }
            else if (mode == "hard")
            {
                MessageBox.Show("In this mode, you will have 60s for 5 questions.\nEach wrong answer will minus you 10 points");
                lbHint.Visible = false;
                countdownLabel.Visible = true;
                updateCountDownLabel();
                timer1_Tick.Start();
            }
        }

        private void ReadFile(string type)
        {
            String str = "";
            int j = 0;
            string file = "";
            string questionInFile = "";
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
                    questionInFile += questions[i] + "\n";
                }
            }
            File.WriteAllText("questions.txt", "");
            File.WriteAllText("questions.txt", questionInFile);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (back_click != null)
            {
                back_click.Invoke(this, e);
                pbWord.Image = null;
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

        private void loadQuestion()
        {
            if (increImage >= 5)
            {
                button1.Text = "DONE";
                CongratulationForm congratulationForm = new CongratulationForm(correctAnswer,score);
                congratulationForm.ShowDialog();
                return;
            }
            String str = "";
            str = File.ReadAllText("questions.txt");
            if (str != "")
            {
                String[] items = str.Split('\n');
                string filePath = items[increImage];
                filePath = filePath.Replace("\r", "");
                Image image = Image.FromFile(filePath);
                fileName = Path.GetFileName(filePath);
                string[] subStrings = fileName.Split(".");
                fileName = subStrings[0];
                if (mode == "easy")
                {
                    //hintChar = new int[fileName.Length];
                    displayHint(fileName);
                }
                pbWord.Image = image;
                pbWord.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void displayHint(string fileName)
        { 
            Random random = new Random();
            int ranChar = random.Next(0, fileName.Length);
            //if (hintChar != null)
            //{
            //    for (int i = 0; i < hintChar.Length; i++)
            //    {
            //        //so sánh thứ tự số gợi ý vs số random
            //        if (hintChar[i] == ranChar)
            //        {
            //            ranChar = random.Next(0, fileName.Length);
            //            i = 0;
            //        }
            //        else
            //        {
            //            hintChar[i + 1] = ranChar;
            //            break;
            //        }
            //    }
            //}
            //MessageBox.Show(hintChar[0].ToString());
            //MessageBox.Show(hintChar[1].ToString());
            lbHint.Text = "Hint: ";
            for (int i = 0; i < fileName.Length; i++)
            {
                if (iOfHintChar >= fileName.Length)
                {
                    MessageBox.Show("Out of hint");
                    lbHint.Text = fileName;
                    return;
                }
                else if (i == ranChar)
                {
                    lbHint.Text += fileName[i];
                    //gán số thứ tự đã gợi ý vào hintChar
                    //hintChar[iOfHintChar] = ranChar;
                    //iOfHintChar++;
                    continue;
                }
                lbHint.Text += " _ ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soundCorrectPath = @"C:\\Users\\HP\\Documents\\GitHub\\Lab-CSharp-1-FatChef\\correct.wav";
            string soundWrongPath = @"C:\\Users\\HP\\Documents\\GitHub\\Lab-CSharp-1-FatChef\\wrong.wav";
            SoundPlayer correctSound = new SoundPlayer(soundCorrectPath);
            SoundPlayer wrongSound = new SoundPlayer(soundWrongPath);
            if (increImage >= 5)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                UCHomeScreen screen = new UCHomeScreen();
                screen.Show();
                screen.BringToFront();
                f.Controls.Add(screen);
                return;
            }
            else
            if (tbAnswer.Text.ToLower() == fileName.ToLower())
            {
                correctSound.Play();
                score += 20;
                correctAnswer += 1;
                label2.Text = "Question: " + correctAnswer.ToString() + " / 5";
                label1.Text = "Score: " + score.ToString() + " / 100";
                MessageBox.Show("Correct Answer");
                if (increImage == 0)
                {
                    pbIsCorrect1.Visible = true;
                }
                else if (increImage == 1)
                {
                    pbIsCorrect2.Visible = true;
                }
                else if (increImage == 2)
                {
                    pbIsCorrect3.Visible = true;
                }
                else if (increImage == 3)
                {
                    pbIsCorrect4.Visible = true;
                }
                else if (increImage == 4)
                {
                    pbIsCorrect5.Visible = true;
                }
                tbAnswer.Text = "";
                increImage += 1;
                loadQuestion();
            }
            else
            {
                wrongSound.Play();
                if (mode =="hard")
                {
                    score -= 10;
                    label1.Text = "Score: " + score.ToString() + " / 100";
                }

                if (increImage == 0)
                {
                    pbIsCorrect1.Image = wrongImg;
                    pbIsCorrect1.Visible = true;
                }
                else if (increImage == 1)
                {
                    pbIsCorrect2.Image = wrongImg;
                    pbIsCorrect2.Visible = true;
                }
                else if (increImage == 2)
                {
                    pbIsCorrect3.Image = wrongImg;
                    pbIsCorrect3.Visible = true;
                }
                else if (increImage == 3)
                {
                    pbIsCorrect4.Image = wrongImg;
                    pbIsCorrect4.Visible = true;
                }
                else if (increImage == 4)
                {
                    pbIsCorrect5.Image = wrongImg;
                    pbIsCorrect5.Visible = true;
                }
                MessageBox.Show("Wrong answer");
                tbAnswer.Text = "";
                increImage += 1;
                loadQuestion();
            }
        }

        private void timer1_Tick_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            if (remainingSeconds >= 0)
            {
                updateCountDownLabel();
            }
            else
            {
                timer1_Tick.Stop();
                //countdown end
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayHint(fileName);
        }
    }
}

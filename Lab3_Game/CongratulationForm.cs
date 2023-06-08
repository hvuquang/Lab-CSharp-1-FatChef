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
    public partial class CongratulationForm : Form
    {
        private int correctAnswer = 0;
        private int score = 0;
        private string[] highscore;
        private string mode;
        private string type;
        public CongratulationForm()
        {
            InitializeComponent();
        }

        public CongratulationForm(int correctAnswer, int score)
        {
            InitializeComponent();
            this.correctAnswer = correctAnswer;
            this.score = score;
            label3.Text = correctAnswer.ToString() + " / 5";
            label4.Text = score.ToString() + " / 100";
        }

        public CongratulationForm(int correctAnswer, int score, string mode, string type)
        {
            InitializeComponent();
            this.correctAnswer = correctAnswer;
            this.score = score;
            label3.Text = correctAnswer.ToString() + " / 5";
            label4.Text = score.ToString() + " / 100";
            this.mode = mode;
            this.type = type;
            writeFile();
        }

        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1 f = new Form1();
            f.Show();
        }

        private void writeFile()
        {
            DateTime time = DateTime.Now;
            string result;
            if (type == "color")
            {
                result = score + "\t" + mode + "\t" + time + "\n";
                File.AppendAllText("colorscoreboard.txt", result);
            }
            else if (type == "animal")
            {
                result = score + "\t" + mode + "\t" + time + "\n";
                File.AppendAllText("animalscoreboard.txt", result);
            }
            else if (type == "fruit")
            {
                result = score + "\t" + mode + "\t" + time + "\n";
                File.AppendAllText("fruitscoreboard.txt", result);
            }
            result = score + "\t" + mode + "\t" + type + "\t" + time + "\n";
            File.AppendAllText("scoreboard.txt", result);
        }
    }
}

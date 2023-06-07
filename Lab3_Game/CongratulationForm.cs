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

        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1 f = new Form1();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Lab3_Game.UserControls
{
    public partial class UCHomeScreen : UserControl
    {
        public event EventHandler<EventArgs> label2_click;
        public event EventHandler<EventArgs> lbColor_click;
        public event EventHandler<EventArgs> lbFruit_click;
        public event EventHandler<EventArgs> lbAnimal_click;
        public event EventHandler<EventArgs> lbDictionary_click;
        public bool isMute = false;


        public UCHomeScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2_click != null)
            {
                label2_click.Invoke(this, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string soundFilePath = "C:\\Users\\HP\\Documents\\GitHub\\Lab-CSharp-1-FatChef\\nhacgame02.wav";
            SoundPlayer player = new SoundPlayer(soundFilePath);
            isMute = !isMute;
            if (isMute) // true
            {
                pictureBox1.Image = Properties.Resources.audio_speaker_on;
                player.Play();
            }
            else
            {
                pictureBox1.Image = Properties.Resources.mute;
                player.Stop();
            }
        }

        private void lbDictionary_Click(object sender, EventArgs e)
        {
            if (lbDictionary_click != null)
            {
                lbDictionary_click.Invoke(this, e);
            }
        }

        private void lbColor_Click(object sender, EventArgs e)
        {
            if (lbColor_click != null)
            {
                lbColor_click.Invoke(this, e);
            }
        }

        private void lbFruit_Click(object sender, EventArgs e)
        {
            if (lbFruit_click != null)
            {
                lbFruit_click.Invoke(this, e);
            }
        }

        private void lbAnimal_Click(object sender, EventArgs e)
        {
            if (lbAnimal_click != null)
            {
                lbAnimal_click.Invoke(this, e);
            }
        }

        private void lbAchievement_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UCScoreBoard board = new UCScoreBoard();
            board.Show();
            board.BringToFront();
            this.Controls.Add(board);
        }
    }
}

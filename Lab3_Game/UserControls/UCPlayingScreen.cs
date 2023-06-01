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
        public UCPlayingScreen()
        {
            InitializeComponent();
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

namespace Lab3_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucPlayingScreen1_back_click(object sender, EventArgs e)
        {
            ucPlayingScreen1.Hide();
            ucHomeScreen1.Show();
            ucHomeScreen1.BringToFront();
        }

        private void ucHomeScreen1_label2_click_1(object sender, EventArgs e)
        {
            ucPlayingScreen1.Show();
            ucPlayingScreen1.BringToFront();
        }

        private void ucHomeScreen1_lbDictionary_click(object sender, EventArgs e)
        {
            ucDictionary1.Show();
            ucDictionary1.BringToFront();
        }
    }
}
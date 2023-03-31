using Lab1.UserControls;

namespace Lab1
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucRegister1.Visible = false;
            ucLogIn1.Show();
            ucLogIn1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucLogIn1.Visible = false;
            ucRegister1.Show();
            ucRegister1.BringToFront();
        }

        private void ucLogIn1_LogInButton(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.ShowDialog();
        }
    }
}
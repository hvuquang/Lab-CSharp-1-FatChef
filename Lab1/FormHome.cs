using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            ucAllType1.Show();
            ucAllType1.BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            ucDinner1.Show();
            ucDinner1.BringToFront();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            ucDessert1.Show();
            ucDessert1.BringToFront();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            ucCocktail2.Show();
            ucCocktail2.BringToFront();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            ucGolden1.Show();
            ucGolden1.BringToFront();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new FormLogIn();
            f.ShowDialog();
        }

        private void ucCocktail2_ucCockTail_Load(object sender, EventArgs e)
        {
       
        }

        private void ucDessert1_ucDessert_Load(object sender, EventArgs e)
        {

        }

        private void ucDinner1_ucDinner_Load(object sender, EventArgs e)
        {

        }

        private void ucAllType1_ucAllType_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run");
        }

        private void ucGolden1_ucGolden_Load(object sender, EventArgs e)
        {

        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            Form f = new FormCart();
            f.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form f = new FormUser();
            f.ShowDialog();
        }
    }
}

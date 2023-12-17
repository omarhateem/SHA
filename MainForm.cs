using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Handle login button click
            new LoginForm().Show();
            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Handle register button click
            new SignUpForm().Show();
            this.Hide();

        }
    }
}

using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SignUpForm SignUp = new SignUpForm();
            this.Hide();
            SignUp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if(ID.Text == "")
            {

            }
            else { MessageBox.Show("Unknown Data"); }
        }
    }
}

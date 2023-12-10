using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project
{
    public partial class SignUpForm : Form
    {
        public int price = 0;
        public SignUpForm()
        {
            InitializeComponent();
            username.MouseClick += remove_placeholder;
            username.MouseLeave += placeholder_back;
            password.MouseClick += removePass_placeholder;
            textBox1.MouseClick += nameremove;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            Program.RoundControlCorners(button1, 7);
            Program.RoundControlCorners(button5, 8);
            Program.RoundControlCorners(password, 15);
            Program.RoundControlCorners(username, 15);
        }



        private void password_TextChanged(object sender, EventArgs e)
        {


            password.UseSystemPasswordChar = true;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }




        private void remove_placeholder(object sender, EventArgs e)
        {
            username.ForeColor = Color.Black;
            username.Text = string.Empty;
            username.MouseClick -= remove_placeholder;

        }
        private void nameremove(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = string.Empty;
            textBox1.MouseClick -= remove_placeholder;

        }



        private void removePass_placeholder(object sender, EventArgs e)
        {
            password.ForeColor = Color.Black;
            password.Text = string.Empty;


        }
        private void placeholder_back(object sender, EventArgs e)
        {
            if (username.Text == string.Empty)
            {
                username.Text = "🪪 ID";
                username.ForeColor = Color.FromArgb(203, 203, 205);
                username.MouseClick += remove_placeholder;


            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            if (username.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                //show the main page ya khatab


            }
            else
            {

                MessageBox.Show("Wrong Username or Password");
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

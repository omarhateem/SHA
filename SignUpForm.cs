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
            ID.MouseClick += remove_placeholder;
            ID.MouseLeave += placeholder_back;
            StudentName.MouseClick += removePass_placeholder;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            Program.RoundControlCorners(SignUpBtn, 7);
            Program.RoundControlCorners(button5, 8);
            Program.RoundControlCorners(StudentName, 15);
            Program.RoundControlCorners(ID, 15);
        }



        private void password_TextChanged(object sender, EventArgs e)
        {


            StudentName.UseSystemPasswordChar = true;
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
            ID.ForeColor = Color.Black;
            ID.Text = string.Empty;
            ID.MouseClick -= remove_placeholder;

        }



        private void removePass_placeholder(object sender, EventArgs e)
        {
            StudentName.ForeColor = Color.Black;
            StudentName.Text = string.Empty;


        }
        private void placeholder_back(object sender, EventArgs e)
        {
            if (ID.Text == string.Empty)
            {
                ID.Text = "🪪 ID";
                ID.ForeColor = Color.FromArgb(203, 203, 205);
                ID.MouseClick += remove_placeholder;


            }
        }



        private void Sign_Click(object sender, EventArgs e)
        {
            bool Flag;
            foreach(char c in StudentName.Text)
            {
                Flag = int.TryParse(c.ToString(), out int num);
                if(Flag)
                {
                    StudentName.Text = string.Empty;
                    MessageBox.Show("InValidName","Name contain numbers",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    StudentName.Focus();
                    break;
                }
            }
            foreach (char c in ID.Text)
            {
            Flag = int.TryParse(c.ToString(), out int num);
                if (!Flag)
                {
                    ID.Text = string.Empty;
                    MessageBox.Show("InValid ID", "ID contain char", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID.Focus();
                    break;
                }
            }
            if(ID.Text == string.Empty||StudentName.Text == string.Empty)
            {
                MessageBox.Show("Enter Data in all fields", "Data not Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Insert eladata ya hatem
            }
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

    }
}

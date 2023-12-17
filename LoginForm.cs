using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        public static LoginForm instant;
        public TextBox id2;

        public LoginForm()
        {
            InitializeComponent();
            instant = this;
            id2 = ID;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (ID.Text != "")
            {
                // Check the database connection
                string server = "localhost";
                string database = "el_Shorouk_Academy";
                string username = "root";
                string password = "";

                string constring = "SERVER=" + server + ";"
                    + "DATABASE=" + database + ";"
                    + "UID=" + username + ";"
                    + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);

                try
                {
                    conn.Open();

                    string query = "SELECT * FROM `student` WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", ID.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Access the retrieved data using reader
                            string studentId = reader["Id"].ToString();
                            string studentName = reader["Name"].ToString();
                            string section = reader["Section"].ToString();

                            // Do something with the data
                            // For example, display it in a MessageBox
                            MessageBox.Show($"Student ID: {studentId}\nStudent Name: {studentName}\nSection: {section}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //public int auth = double.Parse(ID.Text);
                            new EndForm().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given ID.", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

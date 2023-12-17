using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            const string TimeFormat = "HH:mm:00";
            string currentTime = DateTime.Now.ToString(TimeFormat);
            const string DateFormat = "dddd";
            string currentDate = DateTime.Now.ToString(DateFormat);
            string secnum = "";

            string idf = LoginForm.instant.id2.Text;
            string server = "localhost";
            string database = "el_Shorouk_Academy";
            string username = "root";
            string password = "";
            string constring = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                try
                {
                    conn.Open();

                    // Query for student information
                    string studentQuery = $"SELECT Name, Section FROM `student` WHERE Id = @studentId";
                    using (MySqlCommand studentCommand = new MySqlCommand(studentQuery, conn))
                    {
                        studentCommand.Parameters.AddWithValue("@studentId", idf);

                        using (MySqlDataReader studentReader = studentCommand.ExecuteReader())
                        {
                            if (studentReader.HasRows)
                            {
                                while (studentReader.Read())
                                {
                                    label7.Text = studentReader["Name"].ToString();
                                    secnum= studentReader["Section"].ToString();
                                    Sectionback.Text = studentReader["Section"].ToString();

                                }
                            }
                            else
                            {
                                label7.Text = "No student found with the specified ID";
                            }
                        }
                    }

                    // Query for schedule information
                    string scheduleQuery = $"SELECT Mentor_Name, Name FROM `schedule` WHERE `TIME` = @currentTime AND `Day`= @currentDate AND `Section_Num` = @secnum ";
                    using (MySqlCommand scheduleCommand = new MySqlCommand(scheduleQuery, conn))
                    {
                        scheduleCommand.Parameters.AddWithValue("@currentTime", currentTime);
                        scheduleCommand.Parameters.AddWithValue("@currentDate", currentDate);
                        scheduleCommand.Parameters.AddWithValue("@secnum", secnum);


                        using (MySqlDataReader scheduleReader = scheduleCommand.ExecuteReader())
                        {
                            if (scheduleReader.HasRows)
                            {
                                while (scheduleReader.Read())
                                {
                                    Subjectb.Text = scheduleReader["Name"].ToString();
                                    Instructorback.Text = scheduleReader["Mentor_Name"].ToString();
                                }
                            }
                            else
                            {
                                Instructorback.Text = "No schedule Now";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:00");
            DateLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Your painting logic here
        }

        public void LoadDataFromMySQL()
        {
            // You can implement loading data here if needed
        }
    }
}

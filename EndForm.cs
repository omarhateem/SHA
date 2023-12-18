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
            const string DateFormat = "dddd";
            string currentDate = DateTime.Now.ToString(DateFormat);
            string secnum = "";
            string idf = LoginForm.instant.id2.Text;
            //-------------------------------------------
            const string TimeFormat = "HH:mm:ss";
            string currentTime = DateTime.Now.ToString(TimeFormat);
            int period = 0; // Default value

            // Check the time range to determine the period
            TimeSpan currentSpan = DateTime.Now.TimeOfDay;

            if (currentSpan >= TimeSpan.Parse("09:15:00") && currentSpan <= TimeSpan.Parse("10:00:00"))
            {
                period = 1;
            }
            else if (currentSpan >= TimeSpan.Parse("10:00:00") && currentSpan <= TimeSpan.Parse("10:45:00"))
            {
                period = 2;
            }
            else if (currentSpan >= TimeSpan.Parse("10:55:00") && currentSpan <= TimeSpan.Parse("11:40:00"))
            {
                period = 3;
            }
            else if (currentSpan >= TimeSpan.Parse("11:40:00") && currentSpan <= TimeSpan.Parse("12:25:00"))
            {
                period = 4;
            }
            else if (currentSpan >= TimeSpan.Parse("12:45:00") && currentSpan <= TimeSpan.Parse("01:30:00"))
            {
                period = 5;
            }
            else if (currentSpan >= TimeSpan.Parse("01:30:00") && currentSpan <= TimeSpan.Parse("02:10:00"))
            {
                period = 6;
            }
            else if (currentSpan >= TimeSpan.Parse("02:20:00") && currentSpan <= TimeSpan.Parse("03:00:00"))
            {
                period = 7;
            }
            else if (currentSpan >= TimeSpan.Parse("03:00:00") && currentSpan <= TimeSpan.Parse("03:45:00"))
            {
                period = 8;
            }
            else
            {
                period = 9;

            }

            //-------------------------------------------
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
                                    secnum = studentReader["Section"].ToString();
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
                    if (period > 0 && period < 9)
                    {
                        string scheduleQuery = $"SELECT Mentor_Name, Name FROM `schedule` WHERE `period` = @period AND `Day`= @currentDate AND `Section_Num` = @secnum ";
                        using (MySqlCommand scheduleCommand = new MySqlCommand(scheduleQuery, conn))
                        {
                            scheduleCommand.Parameters.AddWithValue("@period", period);
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
                    else if (period == 9)
                    {
                        Instructorback.Text = "No schedule Now";
                        Subjectb.Text = "No schedule Now";
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
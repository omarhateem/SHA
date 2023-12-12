namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
            this.Hide();
        }
    }
}

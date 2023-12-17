namespace Project
{
    partial class SignUpForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxSections = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            LoginLabel = new Label();
            label4 = new Label();
            Exit = new Button();
            label1 = new Label();
            SignUpBtn = new Button();
            StudentName = new TextBox();
            ID = new TextBox();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 25.25F, FontStyle.Bold); // Change font to Arial
            label3.ForeColor = Color.FromArgb(255, 0, 0); // Change to Red
            label3.Location = new Point(160, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 59);
            label3.TabIndex = 0;
            label3.Text = "Sign Up";

            // panel1
            panel1.BackColor = Color.FromArgb(240, 240, 240); // Change to light gray
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxSections);

            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SignUpBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(StudentName);
            panel1.Controls.Add(ID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 702);
            panel1.TabIndex = 2;

            // comboBoxSections
            

            // LoginLabel
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Arial", 15F, FontStyle.Bold); // Change font to Arial
            LoginLabel.ForeColor = Color.FromArgb(0, 128, 0); // Change to Green
            LoginLabel.Location = new Point(228, 632);
            LoginLabel.Margin = new Padding(2, 0, 2, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(94, 30);
            LoginLabel.TabIndex = 21;
            LoginLabel.Text = "Log in";
            LoginLabel.Click += LoginLabel_Click;
            // comboBoxSections
            // 
            comboBoxSections.FormattingEnabled = true;
            comboBoxSections.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17" });
            comboBoxSections.Location = new Point(63, 403);
            comboBoxSections.Name = "comboBoxSections";
            comboBoxSections.Size = new Size(448, 28);
            comboBoxSections.TabIndex = 22;
            // 
            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(111, 581);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(362, 33);
            label4.TabIndex = 20;
            label4.Text = "Already have an Account ?";

            // Exit
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            Exit.ForeColor = Color.Black; // Change to White
            Exit.Location = new Point(500, 10);
            Exit.Margin = new Padding(2);
            Exit.Name = "Exit";
            Exit.Size = new Size(43, 34);
            Exit.TabIndex = 18;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.ForeColor = Color.Blue; // Change to Blue
            label1.Location = new Point(130, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";

            // SignUpBtn
            SignUpBtn.BackColor = Color.FromArgb(0, 0, 255); // Change to Blue
            SignUpBtn.Cursor = Cursors.Hand;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            SignUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            SignUpBtn.FlatStyle = FlatStyle.Popup;
            SignUpBtn.Font = new Font("Arial", 18F, FontStyle.Bold); // Change font to Arial
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(63, 489);
            SignUpBtn.Margin = new Padding(2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(448, 71);
            SignUpBtn.TabIndex = 9;
            SignUpBtn.Text = "Register";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += Sign_Click;

            // StudentName
            StudentName.BackColor = SystemColors.Menu;
            StudentName.Font = new Font("Arial", 16.25F, FontStyle.Bold); // Change font to Arial
            StudentName.ForeColor = Color.FromArgb(203, 203, 205);
            StudentName.Location = new Point(63, 300);
            StudentName.Margin = new Padding(2);
            StudentName.Multiline = true;
            StudentName.Name = "StudentName";
            StudentName.PlaceholderText = " Enter your name ";
            StudentName.Size = new Size(448, 72);
            StudentName.TabIndex = 10;

            // ID
            ID.BackColor = SystemColors.Menu;
            ID.Font = new Font("Arial", 16.25F, FontStyle.Bold); // Change font to Arial
            ID.ForeColor = SystemColors.ScrollBar;
            ID.Location = new Point(63, 204);
            ID.Margin = new Padding(2);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.PlaceholderText = " Enter your ID ";
            ID.Size = new Size(448, 72);
            ID.TabIndex = 6;

            // button5
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Sienna;
            button5.FlatAppearance.MouseOverBackColor = Color.Sienna;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(717, 110);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(14, 16);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;

            // SignUpForm
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 702);
            Controls.Add(panel1);
            Controls.Add(button5);
            Font = new Font("Arial", 8.25F); // Change font to Arial
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            TopMost = true;
            Load += SignUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Exit;
        private Label LoginLabel;
        private Label label4;
        private TextBox StudentName;
        private Button SignUpBtn;
        private TextBox ID;
        private ComboBox comboBoxSections;
    }
}

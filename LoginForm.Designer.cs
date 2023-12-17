namespace Project
{
    partial class LoginForm
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
            panel1 = new Panel();
            Exit = new Button();
            SignUpBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            LogInBtn = new Button();
            ID = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // panel1
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(SignUpBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LogInBtn);
            panel1.Controls.Add(ID);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 417);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;

            // Exit
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            Exit.Location = new Point(360, 6);
            Exit.Margin = new Padding(2, 2, 2, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(21, 31);
            Exit.TabIndex = 20;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button2_Click;

            // SignUpBtn
            SignUpBtn.BackColor = Color.Red;
            SignUpBtn.Cursor = Cursors.Hand;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            SignUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 150, 243);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(38, 323);
            SignUpBtn.Margin = new Padding(2, 2, 2, 2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(315, 43);
            SignUpBtn.TabIndex = 19;
            SignUpBtn.Text = "Don't have an account?";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += button3_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 22F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(150, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 57);
            label3.TabIndex = 0;
            label3.Text = "Login ";

            // LogInBtn
            LogInBtn.BackColor = Color.Blue;
            LogInBtn.Cursor = Cursors.Hand;
            LogInBtn.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            LogInBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            LogInBtn.FlatStyle = FlatStyle.Flat;
            LogInBtn.Font = new Font("Arial", 18F, FontStyle.Bold);
            LogInBtn.ForeColor = Color.White;
            LogInBtn.Location = new Point(38, 242);
            LogInBtn.Margin = new Padding(2, 2, 2, 2);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(315, 43);
            LogInBtn.TabIndex = 9;
            LogInBtn.Text = "Login";
            LogInBtn.UseVisualStyleBackColor = false;
            LogInBtn.Click += LogInBtn_Click;

            // ID
            ID.BackColor = Color.White;
            ID.Font = new Font("Arial", 13.25F, FontStyle.Bold);
            ID.ForeColor = Color.Black;
            ID.Location = new Point(39, 155);
            ID.Margin = new Padding(2, 2, 2, 2);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.PlaceholderText = "ID";
            ID.Size = new Size(315, 45);
            ID.TabIndex = 6;

            // LoginForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 417);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button Exit;
    }
}

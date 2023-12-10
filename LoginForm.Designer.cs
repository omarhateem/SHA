namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(SignUpBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LogInBtn);
            panel1.Controls.Add(ID);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 695);
            panel1.TabIndex = 3;
            // 
            // Exit
            // 
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(515, 10);
            Exit.Name = "Exit";
            Exit.Size = new Size(30, 52);
            Exit.TabIndex = 20;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button2_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(254, 161, 22);
            SignUpBtn.Cursor = Cursors.Hand;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(254, 161, 22);
            SignUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 161, 22);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(54, 538);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(450, 71);
            SignUpBtn.TabIndex = 19;
            SignUpBtn.Text = "Don't have an account?";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(137, 151);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Uighur", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 51);
            label3.Name = "label3";
            label3.Size = new Size(173, 85);
            label3.TabIndex = 0;
            label3.Text = "Login ";
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = Color.FromArgb(69, 130, 255);
            LogInBtn.Cursor = Cursors.Hand;
            LogInBtn.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            LogInBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            LogInBtn.FlatStyle = FlatStyle.Flat;
            LogInBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            LogInBtn.ForeColor = Color.White;
            LogInBtn.Location = new Point(54, 403);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(450, 71);
            LogInBtn.TabIndex = 9;
            LogInBtn.Text = "Login";
            LogInBtn.UseVisualStyleBackColor = false;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // ID
            // 
            ID.BackColor = SystemColors.Menu;
            ID.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold);
            ID.ForeColor = SystemColors.ScrollBar;
            ID.Location = new Point(56, 259);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.PlaceholderText = "\U0001faaa ID";
            ID.Size = new Size(448, 72);
            ID.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 695);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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
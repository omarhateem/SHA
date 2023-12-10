namespace Project
{
    partial class SignUpForm
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
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            password = new TextBox();
            button1 = new Button();
            username = new TextBox();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(118, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 59);
            label3.TabIndex = 0;
            label3.Text = "Sign Up";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(username);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 606);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(203, 203, 205);
            textBox1.Location = new Point(75, 354);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 48);
            textBox1.TabIndex = 19;
            textBox1.Text = "  Section";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(385, 11);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(43, 34);
            button2.TabIndex = 18;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(88, 109);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";
            // 
            // password
            // 
            password.BackColor = SystemColors.Menu;
            password.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            password.ForeColor = Color.FromArgb(203, 203, 205);
            password.Location = new Point(75, 280);
            password.Margin = new Padding(2);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(300, 48);
            password.TabIndex = 10;
            password.Text = "👤 Name";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 462);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(300, 67);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // username
            // 
            username.BackColor = SystemColors.Menu;
            username.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            username.ForeColor = SystemColors.ScrollBar;
            username.Location = new Point(75, 209);
            username.Margin = new Padding(2);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(300, 48);
            username.TabIndex = 6;
            username.Text = "\U0001faaa ID";
            // 
            // button5
            // 
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
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(439, 606);
            Controls.Add(panel1);
            Controls.Add(button5);
            Font = new Font("Microsoft Sans Serif", 8.25F);
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
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
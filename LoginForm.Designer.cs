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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            username = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(username);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 930);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(515, 10);
            button2.Name = "button2";
            button2.Size = new Size(30, 52);
            button2.TabIndex = 20;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(254, 161, 22);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(254, 161, 22);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 161, 22);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(54, 538);
            button3.Name = "button3";
            button3.Size = new Size(450, 71);
            button3.TabIndex = 19;
            button3.Text = "Don't have an account?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(128, 140);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 51);
            label3.Name = "label3";
            label3.Size = new Size(168, 59);
            label3.TabIndex = 0;
            label3.Text = "Login ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 130, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 403);
            button1.Name = "button1";
            button1.Size = new Size(450, 71);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            username.BackColor = SystemColors.Menu;
            username.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold);
            username.ForeColor = SystemColors.ScrollBar;
            username.Location = new Point(56, 259);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(448, 72);
            username.TabIndex = 6;
            username.Text = "\U0001faaa ID";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 931);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
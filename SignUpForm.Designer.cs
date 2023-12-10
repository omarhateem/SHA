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
            Section = new TextBox();
            Exit = new Button();
            label1 = new Label();
            StudentName = new TextBox();
            RegisterBtn = new Button();
            ID = new TextBox();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(187, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 59);
            label3.TabIndex = 0;
            label3.Text = "Sign Up";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Section);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(StudentName);
            panel1.Controls.Add(RegisterBtn);
            panel1.Controls.Add(ID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 711);
            panel1.TabIndex = 2;
            // 
            // Section
            // 
            Section.BackColor = SystemColors.Menu;
            Section.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            Section.ForeColor = Color.FromArgb(203, 203, 205);
            Section.Location = new Point(63, 440);
            Section.Margin = new Padding(2);
            Section.Multiline = true;
            Section.Name = "Section";
            Section.PlaceholderText = "  Section";
            Section.Size = new Size(448, 72);
            Section.TabIndex = 19;
            // 
            // Exit
            // 
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(500, 23);
            Exit.Margin = new Padding(2);
            Exit.Name = "Exit";
            Exit.Size = new Size(43, 34);
            Exit.TabIndex = 18;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(150, 131);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 11;
            label1.Text = "Welcome to our App";
            // 
            // StudentName
            // 
            StudentName.BackColor = SystemColors.Menu;
            StudentName.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            StudentName.ForeColor = Color.FromArgb(203, 203, 205);
            StudentName.Location = new Point(63, 325);
            StudentName.Margin = new Padding(2);
            StudentName.Multiline = true;
            StudentName.Name = "StudentName";
            StudentName.PlaceholderText = "👤 Name";
            StudentName.Size = new Size(448, 72);
            StudentName.TabIndex = 10;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.RoyalBlue;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderColor = Color.FromArgb(44, 105, 141);
            RegisterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 105, 141);
            RegisterBtn.FlatStyle = FlatStyle.Popup;
            RegisterBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(63, 568);
            RegisterBtn.Margin = new Padding(2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(448, 71);
            RegisterBtn.TabIndex = 9;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += button1_Click_1;
            // 
            // ID
            // 
            ID.BackColor = SystemColors.Menu;
            ID.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            ID.ForeColor = SystemColors.ScrollBar;
            ID.Location = new Point(63, 209);
            ID.Margin = new Padding(2);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.PlaceholderText = "\U0001faaa ID";
            ID.Size = new Size(448, 72);
            ID.TabIndex = 6;
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
            ClientSize = new Size(569, 711);
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
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox Section;
    }
}
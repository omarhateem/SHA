namespace Project
{
    partial class EndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndForm));
            panel1 = new Panel();
            LoginLabel = new Label();
            label4 = new Label();
            Exit = new Button();
            label3 = new Label();
            StudentName = new TextBox();
            ID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(StudentName);
            panel1.Controls.Add(ID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 630);
            panel1.TabIndex = 3;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.DeepSkyBlue;
            LoginLabel.Location = new Point(228, 632);
            LoginLabel.Margin = new Padding(2, 0, 2, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(65, 20);
            LoginLabel.TabIndex = 21;
            LoginLabel.Text = "Log in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 316);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 31);
            label4.TabIndex = 20;
            label4.Text = "Subject";
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(133, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 39);
            label3.TabIndex = 0;
            label3.Text = "Hello\"name\"";
            // 
            // StudentName
            // 
            StudentName.BackColor = SystemColors.Menu;
            StudentName.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            StudentName.ForeColor = Color.FromArgb(203, 203, 205);
            StudentName.Location = new Point(212, 379);
            StudentName.Margin = new Padding(2);
            StudentName.Multiline = true;
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(299, 72);
            StudentName.TabIndex = 10;
            // 
            // ID
            // 
            ID.BackColor = SystemColors.Menu;
            ID.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            ID.ForeColor = SystemColors.ScrollBar;
            ID.Location = new Point(212, 275);
            ID.Margin = new Padding(2);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new Size(299, 72);
            ID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 185);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 39);
            label2.TabIndex = 23;
            label2.Text = "Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(286, 185);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 39);
            label1.TabIndex = 24;
            label1.Text = "Date:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(203, 203, 205);
            textBox1.Location = new Point(202, 487);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 72);
            textBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 528);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 26;
            label5.Text = "Section";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 420);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 31);
            label6.TabIndex = 27;
            label6.Text = "Instructor";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // EndForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(549, 630);
            Controls.Add(panel1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            ImeMode = ImeMode.NoControl;
            Name = "EndForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LoginLabel;
        private Label label4;
        private Button Exit;
        private Label label3;
        private TextBox StudentName;
        private TextBox ID;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
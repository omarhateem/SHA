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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndForm));
            panel1 = new Panel();
            DateLabel = new Label();
            TimeLabel = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginLabel = new Label();
            label4 = new Label();
            Exit = new Button();
            label3 = new Label();
            StudentName = new TextBox();
            ID = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(TimeLabel);
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
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 711);
            panel1.TabIndex = 3;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.DimGray;
            DateLabel.Location = new Point(161, 350);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(67, 32);
            DateLabel.TabIndex = 30;
            DateLabel.Text = "Date";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeLabel.ForeColor = Color.DimGray;
            TimeLabel.Location = new Point(161, 279);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(70, 32);
            TimeLabel.TabIndex = 29;
            TimeLabel.Text = "Time";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 31);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 518);
            label6.Name = "label6";
            label6.Size = new Size(168, 39);
            label6.TabIndex = 27;
            label6.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 432);
            label5.Name = "label5";
            label5.Size = new Size(138, 39);
            label5.TabIndex = 26;
            label5.Text = "Section";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(203, 203, 205);
            textBox1.Location = new Point(217, 413);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 67);
            textBox1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(27, 343);
            label1.Name = "label1";
            label1.Size = new Size(108, 40);
            label1.TabIndex = 24;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(23, 271);
            label2.Name = "label2";
            label2.Size = new Size(112, 40);
            label2.TabIndex = 23;
            label2.Text = "Time:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.DeepSkyBlue;
            LoginLabel.Location = new Point(326, 1053);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(94, 30);
            LoginLabel.TabIndex = 21;
            LoginLabel.Text = "Log in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 602);
            label4.Name = "label4";
            label4.Size = new Size(138, 39);
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
            Exit.Location = new Point(720, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(61, 57);
            Exit.TabIndex = 18;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(119, 193);
            label3.Name = "label3";
            label3.Size = new Size(313, 59);
            label3.TabIndex = 0;
            label3.Text = "Hello\"name\"";
            // 
            // StudentName
            // 
            StudentName.BackColor = SystemColors.Menu;
            StudentName.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            StudentName.ForeColor = Color.FromArgb(203, 203, 205);
            StudentName.Location = new Point(217, 505);
            StudentName.Multiline = true;
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(311, 67);
            StudentName.TabIndex = 10;
            // 
            // ID
            // 
            ID.BackColor = SystemColors.Menu;
            ID.Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            ID.ForeColor = SystemColors.ScrollBar;
            ID.Location = new Point(217, 591);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new Size(311, 67);
            ID.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(499, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 52);
            button1.TabIndex = 31;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EndForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 711);
            Controls.Add(panel1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EndForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndForm";
            Load += EndForm_Load;
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
        private Label DateLabel;
        private Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    partial class EndForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndForm));
            panel1 = new Panel();
            button1 = new Button();
            DateLabel = new Label();
            TimeLabel = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            LoginLabel = new Label();
            label4 = new Label();
            Exit = new Button();
            label3 = new Label();
            comboBoxSections = new ComboBox();

            Sectionback= new Label();
            Instructorback = new Label();
            Subjectb= new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // panel1
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(TimeLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Sectionback);
            panel1.Controls.Add(Instructorback);
            panel1.Controls.Add(Subjectb);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 427);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;

            // button1
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(349, 7);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(32, 31);
            button1.TabIndex = 31;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // DateLabel
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.DimGray;
            DateLabel.Location = new Point(113, 210);
            DateLabel.Margin = new Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(46, 21);
            DateLabel.TabIndex = 30;
            DateLabel.Text = "Date";

            // TimeLabel
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeLabel.ForeColor = Color.DimGray;
            TimeLabel.Location = new Point(113, 167);
            TimeLabel.Margin = new Padding(2, 0, 2, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(48, 21);
            TimeLabel.TabIndex = 29;
            TimeLabel.Text = "Time";

            comboBoxSections.FormattingEnabled = true;
            comboBoxSections.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17" });
            comboBoxSections.Location = new Point(123, 100);
            comboBoxSections.Name = "comboBoxSections";
            comboBoxSections.Size = new Size(100, 28);
            comboBoxSections.TabIndex = 22;
            // pictureBox1
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;

            // label6
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 311);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 29);
            label6.TabIndex = 27;
            label6.Text = "Instructor : ";

            // label5
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 259);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 29);
            label5.TabIndex = 26;
            label5.Text = "Section : ";

            // name
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(148, 116);
            label7.Margin = new Padding(2, 2, 2, 2);
            //label7.Multiline = true;
            label7.Name = "label7";
            label7.Size = new Size(219, 42);
            label7.TabIndex = 25;
            label7.Text = "";

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(19, 206);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 29);
            label1.TabIndex = 24;
            label1.Text = "Date:";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(16, 163);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 23;
            label2.Text = "Time:";

            // LoginLabel
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.DeepSkyBlue;
            LoginLabel.Location = new Point(228, 632);
            LoginLabel.Margin = new Padding(2, 0, 2, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(65, 20);
            LoginLabel.TabIndex = 21;
            LoginLabel.Text = "Log in";

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 361);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 29);
            label4.TabIndex = 20;
            label4.Text = "Subject : ";

            // Exit
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(349, 7);
            Exit.Margin = new Padding(2, 2, 2, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(32, 31);
            Exit.TabIndex = 18;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            string idf = LoginForm.instant.id2.Text;

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.25F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(50, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 39);
            label3.TabIndex = 0;
            label3.Text = "Hello,"  ;

            // Sectionback
            Sectionback.AutoSize = true;
            Sectionback.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            Sectionback.ForeColor = Color.RoyalBlue;
            Sectionback.Location = new Point(152, 262);
            Sectionback.Margin = new Padding(2, 2, 2, 0);
            Sectionback.Name = "Sectionback";
            Sectionback.Size = new Size(150, 39);
            Sectionback.TabIndex = 0;
            Sectionback.Text = "";

            // Instructorback
            Instructorback.AutoSize = true; 
            Instructorback.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            Instructorback.ForeColor = Color.RoyalBlue;
            Instructorback.Location = new Point(152, 313);
            Instructorback.Margin = new Padding(2, 2, 2, 2);
            Instructorback.Name = "Instructorback";
            Instructorback.Size = new Size(219, 42);
            Instructorback.Text = "";

            // Subjectback
            Subjectb.AutoSize = true;
            Subjectb.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            Subjectb.ForeColor = Color.RoyalBlue;
            Subjectb.Location = new Point(152, 363);
            Subjectb.Margin = new Padding(2, 2, 2, 2);
            Subjectb.Name = "Subjectback";
            Subjectb.Size = new Size(219, 42);
            Subjectb.Text = "";

            // timer1
            timer1.Tick += timer1_Tick;

            // EndForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 92, 92);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(398, 427);
            Controls.Add(panel1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
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
        private Label Sectionback;
        private ComboBox comboBoxSections;

        private Label Instructorback;
        private Label Subjectb;
        private Label label7;
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

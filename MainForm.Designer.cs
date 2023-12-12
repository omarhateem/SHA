namespace Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 275);
            button1.Name = "button1";
            button1.Size = new Size(346, 48);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(31, 344);
            button2.Name = "button2";
            button2.Size = new Size(346, 40);
            button2.TabIndex = 3;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(152, 209);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 13;
            label2.Text = "HELLO";
            // 
            // Exit
            // 
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(358, 11);
            Exit.Margin = new Padding(2);
            Exit.Name = "Exit";
            Exit.Size = new Size(43, 34);
            Exit.TabIndex = 19;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 452);
            Controls.Add(Exit);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button Exit;
    }
}

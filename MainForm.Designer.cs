namespace Project
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblWelcome;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new PictureBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new System.Drawing.Point(150, 50);
            this.pictureBox1.Margin = new Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // btnLogin
            this.btnLogin.BackColor = Color.Blue;
            this.btnLogin.FlatStyle = FlatStyle.Popup;
            this.btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new System.Drawing.Point(150, 300);
            this.btnLogin.Margin = new Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.BackColor = Color.Red;
            this.btnRegister.FlatStyle = FlatStyle.Popup;
            this.btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new System.Drawing.Point(300, 300);
            this.btnRegister.Margin = new Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 50);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblWelcome.ForeColor = Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(125, 370);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 37);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to My App!";

            // MainForm
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

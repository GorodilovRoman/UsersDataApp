namespace UsersDataApp
{
    partial class Log_in
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.LoginAndPassword = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtHide = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginAndPassword
            // 
            this.LoginAndPassword.AutoSize = true;
            this.LoginAndPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginAndPassword.ForeColor = System.Drawing.Color.Azure;
            this.LoginAndPassword.Location = new System.Drawing.Point(19, 108);
            this.LoginAndPassword.Name = "LoginAndPassword";
            this.LoginAndPassword.Size = new System.Drawing.Size(239, 21);
            this.LoginAndPassword.TabIndex = 0;
            this.LoginAndPassword.Text = "Enter your login and password";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.Azure;
            this.Login.Location = new System.Drawing.Point(49, 144);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(38, 15);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Azure;
            this.Password.Location = new System.Drawing.Point(28, 171);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(59, 15);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(93, 142);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Location = new System.Drawing.Point(104, 195);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(183, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHide.Location = new System.Drawing.Point(172, 170);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(19, 18);
            this.btnHide.TabIndex = 6;
            this.btnHide.TabStop = false;
            this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHide_MouseDown);
            this.btnHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHide_MouseUp);
            // 
            // txtHide
            // 
            this.txtHide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHide.Location = new System.Drawing.Point(95, 172);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(75, 13);
            this.txtHide.TabIndex = 4;
            this.txtHide.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(270, 290);
            this.Controls.Add(this.txtHide);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginAndPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_in";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginAndPassword;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.TextBox txtHide;
        private System.Windows.Forms.Timer timer1;
    }
}
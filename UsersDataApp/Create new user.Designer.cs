namespace UsersDataApp
{
    partial class Create_new_user
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
            this.UserID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(139, 26);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(46, 13);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "User ID:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(125, 52);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(124, 78);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(139, 104);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(150, 130);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(191, 23);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(169, 20);
            this.txtUserID.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(191, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(191, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(191, 101);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(169, 20);
            this.txtGender.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Location = new System.Drawing.Point(13, 196);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(297, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(22, 135);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(13, 13);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(94, 116);
            this.pic.TabIndex = 13;
            this.pic.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(128, 156);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // Create_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.UserID);
            this.Name = "Create_new_user";
            this.Text = "Create new user";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
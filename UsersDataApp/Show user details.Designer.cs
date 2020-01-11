namespace UsersDataApp
{
    partial class Show_user_details
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
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.AccessibleName = "";
            this.txtUserID.Location = new System.Drawing.Point(190, 22);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(169, 20);
            this.txtUserID.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(190, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(127, 155);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 27;
            this.Password.Text = "Password:";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(94, 116);
            this.pic.TabIndex = 26;
            this.pic.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(21, 134);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(190, 100);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(169, 20);
            this.txtGender.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(190, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 20);
            this.txtLastName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(190, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtFirstName.TabIndex = 20;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(149, 129);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 19;
            this.Email.Text = "Email:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(138, 103);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 18;
            this.Gender.Text = "Gender:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(123, 77);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 17;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(124, 51);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 16;
            this.FirstName.Text = "First Name:";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(138, 25);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(46, 13);
            this.UserID.TabIndex = 15;
            this.UserID.Text = "User ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(12, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(301, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(93, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Show_user_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.txtUserID);
            this.Name = "Show_user_details";
            this.Text = "User details";
            this.Load += new System.EventHandler(this.Show_user_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}
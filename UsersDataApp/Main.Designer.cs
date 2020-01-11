namespace UsersDataApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.labExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnUserCreate, "btnUserCreate");
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.UseVisualStyleBackColor = true;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // Welcome
            // 
            resources.ApplyResources(this.Welcome, "Welcome");
            this.Welcome.ForeColor = System.Drawing.Color.Azure;
            this.Welcome.Name = "Welcome";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnShowAll, "btnShowAll");
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // labExit
            // 
            resources.ApplyResources(this.labExit, "labExit");
            this.labExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labExit.ForeColor = System.Drawing.Color.Azure;
            this.labExit.Name = "labExit";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.btnUserCreate);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label labExit;
    }
}


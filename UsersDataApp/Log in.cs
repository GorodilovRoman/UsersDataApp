using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsersDataApp
{
    public partial class Log_in : Form
    {
        public string ReturnValue { get; set; }
        private bool AreNotEmpty()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Please enter your email");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password");
                return false;
            }
            else { return true; }
        }
        public Log_in()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (AreNotEmpty())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Select Password from [Users_db].[Users] where Email = @Email", connection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100));
                        sqlCommand.Parameters["@Email"].Value = txtLogin.Text;
                        string password = (string)sqlCommand.ExecuteScalar();
                        if (password == txtPassword.Text)
                        {
                            using (SqlCommand sqlCommand2 = new SqlCommand("Select User_ID from [Users_db].[Users] where Email = @Email AND Password = @Password", connection))
                            {
                                sqlCommand2.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100));
                                sqlCommand2.Parameters["@Email"].Value = txtLogin.Text;
                                sqlCommand2.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100));
                                sqlCommand2.Parameters["@Password"].Value = txtPassword.Text;
                                this.ReturnValue = Convert.ToString((int)sqlCommand2.ExecuteScalar());
                            }
                            MessageBox.Show("Successful log in");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 36, 49);
            txtHide.Hide();
        }

        private void btnHide_MouseDown(object sender, MouseEventArgs e)
        {
            txtHide.Show();
        }

        private void btnHide_MouseUp(object sender, MouseEventArgs e)
        {
            txtHide.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHide.Text = txtPassword.Text;
        }
    }
}

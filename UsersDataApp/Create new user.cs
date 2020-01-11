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
    public partial class Create_new_user : Form
    {
        private int parsedUserID;

        private bool AreUserDetailsValid()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                return false;
            }
            else if(txtLastName.Text == "")
            {
                MessageBox.Show("Please enter your surname.");
                return false;
            }
            else if (txtGender.Text == "")
            {
                MessageBox.Show("Please enter your gender.");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearForm()
        {
            txtUserID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtGender.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            this.parsedUserID = 0;
        }

        public Create_new_user()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    
                }
            }
        }

        public bool IsServerConnected()
        {
            using (var l_oConnection = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("You are not connected to database.");
                    return false;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (AreUserDetailsValid())
            {
                if (IsServerConnected())
                    {
                    // Create the connection.
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
                    {
                        // Create a SqlCommand, and identify it as a stored procedure.
                        using (SqlCommand sqlCommand = new SqlCommand("Users_db.User_Insert", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.NVarChar, 100));
                            sqlCommand.Parameters["@First_Name"].Value = txtFirstName.Text;

                            sqlCommand.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.NVarChar, 100));
                            sqlCommand.Parameters["@Last_Name"].Value = txtLastName.Text;

                            sqlCommand.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 50));
                            sqlCommand.Parameters["@Gender"].Value = txtGender.Text;

                            sqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100));
                            sqlCommand.Parameters["@Email"].Value = txtEmail.Text;

                            sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100));
                            sqlCommand.Parameters["@Password"].Value = txtPassword.Text;

                            // Add the output parameter.
                            sqlCommand.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.Int));
                            sqlCommand.Parameters["@User_ID"].Direction = ParameterDirection.Output;

                            try
                            {
                                connection.Open();

                                // Run the stored procedure.
                                sqlCommand.ExecuteNonQuery();

                                // Customer ID is an IDENTITY value from the database.
                                this.parsedUserID = (int)sqlCommand.Parameters["@User_ID"].Value;

                                // Put the Customer ID value into the read-only text box.
                                this.txtUserID.Text = Convert.ToString(parsedUserID);
                            }
                            catch
                            {
                                MessageBox.Show("User ID was not returned. Account could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
            this.ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

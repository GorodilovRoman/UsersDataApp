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
using System.Text.RegularExpressions;

namespace UsersDataApp
{
    public partial class Show_user_details : Form
    {
        public Show_user_details()
        {
            InitializeComponent();
        }

        private bool AreUserDetailsValid()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                return false;
            }
            else if (txtLastName.Text == "")
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

        private void Show_user_details_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (var form = new Log_in())
                {
                    var result = form.ShowDialog();
                    string val = form.ReturnValue;
                    this.txtUserID.Text = val;
                }

                // Create a SqlCommand object.
                using (SqlCommand sqlCommand = new SqlCommand("SELECT [User_ID], [First_Name], [Last_Name], [Gender], [Email], [Password] FROM Users_db.Users WHERE [User_ID]="+txtUserID.Text, connection))
                {
                    try
                    {
                        connection.Open();
                        
                        // Run the query by calling ExecuteReader().
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            // Create a data table to hold the retrieved data.
                            DataTable dataTable = new DataTable();

                            while (dataReader.Read())
                            {
                                txtUserID.Text = (dataReader["User_ID"].ToString());
                                txtFirstName.Text = (dataReader["First_Name"].ToString());
                                txtLastName.Text = (dataReader["Last_Name"].ToString());
                                txtGender.Text = (dataReader["Gender"].ToString());
                                txtEmail.Text = (dataReader["Email"].ToString());
                                txtPassword.Text = (dataReader["Password"].ToString());
                            }

                            // Close the SqlDataReader.
                            dataReader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested information could not be loaded into the form.");
                    }
                    finally
                    {
                        // Close the connection.
                        connection.Close();
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AreUserDetailsValid())
            {
                if (IsServerConnected())
                {
                    // Create the connection.
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
                    {
                        // Create a SqlCommand, and identify it as a stored procedure.
                        using (SqlCommand sqlCommand = new SqlCommand("Users_db.User_Update", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            connection.Open();

                            sqlCommand.Parameters.AddWithValue("@User_ID", txtUserID.Text);
                            sqlCommand.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@Last_Name", txtLastName.Text);

                            sqlCommand.Parameters.AddWithValue("@Gender", txtGender.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                            
                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                // Create a SqlCommand object.
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Users_db.Users where [User_ID] = " + txtUserID.Text, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("This user can't be deleted");
                    }
                    finally
                    {
                        // Close the connection.
                        connection.Close();
                    }
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

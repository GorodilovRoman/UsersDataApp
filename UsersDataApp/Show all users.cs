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
    public partial class Show_all_users : Form
    {
        public Show_all_users()
        {
            InitializeComponent();
        }

        private void Show_all_users_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT [User_ID] AS 'User ID', [First_Name] AS 'Name', [Last_Name] AS 'Surname', [Gender], [Email] FROM Users_db.Users";

                // Create a SqlCommand object.
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        // Run the query by calling ExecuteReader().
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            // Create a data table to hold the retrieved data.
                            DataTable dataTable = new DataTable();

                            // Load the data from SqlDataReader into the data table.
                            dataTable.Load(dataReader);

                            // Display the data from the data table in the data grid view.
                            this.dgvUsers.DataSource = dataTable;

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
    }
}

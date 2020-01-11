using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersDataApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form frm = new Show_user_details();
            frm.Show();
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            Form frm = new Create_new_user();
            frm.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Form frm = new Show_all_users();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

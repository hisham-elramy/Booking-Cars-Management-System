using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;


namespace Booking_Cars_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.GetUserByUsernameAndPassword(txtbUsername.Text, txtbPassword.Text);
            if (User != null)
            {
                frmMain Main = new frmMain();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Login Failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbUsername.Clear();
                txtbPassword.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbUsername.Clear();
            txtbPassword.Clear();
        }
    }
}

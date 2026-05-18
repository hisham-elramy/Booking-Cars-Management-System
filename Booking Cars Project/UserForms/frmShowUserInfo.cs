using BusinessAccessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_Cars_Project
{
    public partial class frmShowUserInfo : Form
    {
        private clsUser _User = new clsUser();

        public frmShowUserInfo()
        {

           

            InitializeComponent();
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {

            txtbAddress.Enabled = false;
            txtbEmail.Enabled = false;
            txtbPassword.Enabled = false;
            txtbName.Enabled = false;
            txtbNationalID.Enabled = false;
            txtbPhone.Enabled = false;
            txtbUsername.Enabled = false;
        }

        private void txtbUserID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbUserID_Leave(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtbUserID.Text, out id))
            {
                _User = clsUser.GetUserByID(id);

                if (_User != null)
                {
                    errorProvider1.SetError(txtbUserID, "");
                    txtbName.Text = _User.Name;
                    txtbPhone.Text = _User.Phone;
                    txtbEmail.Text = _User.Email;
                    txtbAddress.Text = _User.Address;
                    txtbNationalID.Text = _User.NationalID;
                    txtbPassword.Text = _User.Password;
                    txtbUsername.Text = _User.Username;
                }
                else
                {
                    errorProvider1.SetError(txtbUserID, "User Not Exist");
                    MessageBox.Show("User not found", "Show User Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnClose.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtbUserID, "Invalid User ID");
                MessageBox.Show("Please enter a valid numeric User ID");
                btnClose.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

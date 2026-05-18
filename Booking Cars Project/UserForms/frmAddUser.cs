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
    public partial class frmAddUser : Form
    {

        private clsUser _User = new clsUser();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.Name = txtbName.Text;
            _User.Phone = txtbPhone.Text;
            _User.Email = txtbEmail.Text;
            _User.Address = txtbAddress.Text;
            _User.NationalID = txtbNationalID.Text;
            _User.Password = txtbPassword.Text;
            _User.Username = txtbUsername.Text;

            switch (_User.Save())
            {
                case clsUser.enError.NoErrors:
                    MessageBox.Show("User Added Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.UserIDError:
                    MessageBox.Show("User ID Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.NationalIDError:
                    MessageBox.Show("User National ID Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.PhoneError:
                    MessageBox.Show("User Phone Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.EmailError:
                    MessageBox.Show("User Email Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.UsernameError:
                    MessageBox.Show("User Username Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsUser.enError.UnKnownError:
                    MessageBox.Show("User Unknown Error", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            txtbAddress.Enabled = false;
            txtbEmail.Enabled = false;  
            txtbPassword.Enabled = false;
            txtbName.Enabled = false;
            txtbNationalID.Enabled = false;
            txtbPhone.Enabled = false;
            txtbUsername.Enabled = false;
            btnSave.Enabled = false;

            lblUserID.Text = _User.UserID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void MakingError(Guna2TextBox tb, string ErrorMessage)
        {
            errorProvider1.SetError(tb, ErrorMessage);
        }

        private void DeleteError(Guna2TextBox tb)
        {
            errorProvider1.SetError(tb, "");
        }
        private void txtbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbName.Text))
            {
                MakingError(txtbName, "This Field Is Empty");
                txtbName.Focus();
            }
            else
            {
                DeleteError(txtbName);
            }
        }

        private void txtbPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPhone.Text))
            {
                MakingError(txtbPhone, "This Field Is Empty");
                txtbPhone.Focus();
            }
            else if (clsUser.IsUserExistByPhone(txtbPhone.Text))
            {
                MakingError(txtbPhone, "Phone Is Exist");
                txtbPhone.Focus();
            }
            else
            {
                DeleteError(txtbPhone);
            }
        }

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbEmail.Text))
            {
                MakingError(txtbEmail, "This Field Is Empty");
                txtbEmail.Focus();
            }
            else if (clsUser.IsUserExistByEmail(txtbEmail.Text))
            {
                MakingError(txtbEmail, "Email Is Exist");
                txtbEmail.Focus();
            }
            else
            {
                DeleteError(txtbEmail);
            }
        }

        private void txtbNationalID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNationalID.Text))
            {
                MakingError(txtbNationalID, "This Field Is Empty");
                txtbNationalID.Focus();
            }
            else if (clsUser.IsUserExistByNationalID(txtbNationalID.Text))
            {
                MakingError(txtbNationalID, "NationalID Is Exist");
                txtbNationalID.Focus();
            }
            else
            {
                DeleteError(txtbNationalID);
            }
        }

        private void txtbUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbUsername.Text))
            {
                MakingError(txtbUsername, "This Field Is Empty");
                txtbUsername.Focus();
            }
            else if (clsUser.IsUserExistByUsername(txtbUsername.Text))
            {
                MakingError(txtbUsername, "Username Is Exist");
                txtbUsername.Focus();
            }
            else
            {
                DeleteError(txtbUsername);
            }
        }

        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPassword.Text))
            {
                MakingError(txtbPassword, "This Field Is Empty");
                txtbPassword.Focus();
            }
            else
            {
                DeleteError(txtbPassword);
            }
        }

        private void txtbAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbAddress.Text))
            {
                MakingError(txtbAddress, "This Field Is Empty");
                txtbAddress.Focus();
            }
            else
            {
                DeleteError(txtbAddress);
            }
        }
    }
}

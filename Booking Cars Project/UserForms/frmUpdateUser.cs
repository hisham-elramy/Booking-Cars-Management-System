using BusinessAccessLayer;
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
    public partial class frmUpdateUser : Form
    {
        private clsUser _User = new clsUser();
        public frmUpdateUser(int UserID)
        {

            _User = clsUser.GetUserByID(UserID);

            InitializeComponent();
        }

        private void LoadUserData() 
        {
            if (_User != null)
            {
                txtbName.Text = _User.Name;
                txtbPhone.Text = _User.Phone;
                txtbEmail.Text = _User.Email;
                txtbAddress.Text = _User.Address;
                txtbNationalID.Text = _User.NationalID;
                txtbPassword.Text = _User.Password;
                txtbUsername.Text = _User.Username;
                lblUserID.Text = _User.UserID.ToString();
            }

        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            LoadUserData();
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
                    MessageBox.Show("User Updated Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

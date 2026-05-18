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
    public partial class frmUpdateClient : Form
    {

        private clsClient _Client = new clsClient();
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Client.Name = txtbName.Text;
            _Client.Phone = txtbPhone.Text;
            _Client.Email = txtbEmail.Text;
            _Client.Address = txtbAddress.Text;
            _Client.NationalID = txtbNationalID.Text;


            switch (_Client.Save())
            {
                case clsClient.enError.NoError:
                    MessageBox.Show("Client Added Successfully", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsClient.enError.ClientIDError:
                    MessageBox.Show("Client ID Error", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsClient.enError.NationalIDError:
                    MessageBox.Show("Client National ID Error", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsClient.enError.PhoneError:
                    MessageBox.Show("Client Phone Error", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsClient.enError.EmailError:
                    MessageBox.Show("Client Email Error", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsClient.enError.UnknownError:
                    MessageBox.Show("Client Unknown Error", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

            txtbAddress.Enabled = false;
            txtbEmail.Enabled = false;
            txtbName.Enabled = false;
            txtbNationalID.Enabled = false;
            txtbPhone.Enabled = false;
            btnSave.Enabled = false;

            lblClientID.Text = _Client.ClientID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbEmail.Text))
            {
                MakingError(txtbEmail, "This Field Is Empty");
                txtbEmail.Focus();
            }
            else if (clsClient.IsClientExistByEmail(txtbEmail.Text))
            {
                MakingError(txtbEmail, "Email Is Exist");
                txtbEmail.Focus();
            }
            else
            {
                DeleteError(txtbEmail);
            }
        }

        private void txtbPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPhone.Text))
            {
                MakingError(txtbPhone, "This Field Is Empty");
                txtbPhone.Focus();
            }
            else if (clsClient.IsClientExistByPhone(txtbPhone.Text))
            {
                MakingError(txtbPhone, "Phone Is Exist");
                txtbPhone.Focus();
            }
            else
            {
                DeleteError(txtbPhone);
            }
        }

        private void txtbNationalID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNationalID.Text))
            {
                MakingError(txtbNationalID, "This Field Is Empty");
                txtbNationalID.Focus();
            }
            else if (clsClient.IsClientExistByNationalID(txtbNationalID.Text))
            {
                MakingError(txtbNationalID, "NationalID Is Exist");
                txtbNationalID.Focus();
            }
            else
            {
                DeleteError(txtbNationalID);
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

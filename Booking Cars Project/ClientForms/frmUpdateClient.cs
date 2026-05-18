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
    public partial class frmAddClient : Form
    {

        private clsClient _Client = new clsClient();

        public frmAddClient()
        {
            InitializeComponent();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            if (_Client != null)
            {
                txtbName.Text = _Client.Name;
                txtbPhone.Text = _Client.Phone;
                txtbEmail.Text = _Client.Email;
                txtbAddress.Text = _Client.Address;
                txtbNationalID.Text = _Client.NationalID;
                lblClientID.Text = _Client.ClientID.ToString();
            }

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
                    MessageBox.Show("Client Updated Successfully", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
          
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

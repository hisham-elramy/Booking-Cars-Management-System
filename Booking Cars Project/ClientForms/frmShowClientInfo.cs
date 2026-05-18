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
    public partial class frmShowClientInfo : Form
    {

        private clsClient _Client = new clsClient();
        public frmShowClientInfo()
        {
            InitializeComponent();
        }

        private void frmShowClientInfo_Load(object sender, EventArgs e)
        {
            txtbAddress.Enabled = false;
            txtbClientID.Enabled = false;
            txtbEmail.Enabled = false;
            txtbName.Enabled = false;
            txtbNationalID.Enabled = false;
            txtbPhone.Enabled = false;

            cbSearch.SelectedIndex = 0;
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Client = new clsClient();

            ClearButtons();

            txtbAddress.Enabled = false;
            txtbClientID.Enabled = false;
            txtbEmail.Enabled = false;
            txtbName.Enabled = false;
            txtbNationalID.Enabled = false;
            txtbPhone.Enabled = false;

            if (cbSearch.SelectedIndex == 0)
            {
                txtbClientID.Enabled = true;
              
            }
            else if (cbSearch.SelectedIndex == 1)
            {
                
                txtbPhone.Enabled = true;
            }
            else if (cbSearch.SelectedIndex == 2)
            {
               
                txtbEmail.Enabled = true;
            }
            else if (cbSearch.SelectedIndex == 3)
            {
                txtbNationalID.Enabled = true;
            }
        }

        private void txtbName_Leave(object sender, EventArgs e)
        {
    
        }

        private void ClearButtons()
        {
            txtbClientID.Text = "";
            txtbAddress.Text ="";
            txtbEmail.Text = "";
            txtbName.Text = "";
            txtbNationalID.Text = "";
            txtbPhone.Text = "";
        }

        private void txtbClientID_Leave(object sender, EventArgs e)
        {
            _Client = clsClient.GetClientByID(Convert.ToInt32(txtbClientID.Text));

            if (_Client != null)
            {
                txtbAddress.Text = _Client.Address;
                txtbEmail.Text = _Client.Email;
                txtbName.Text = _Client.Name;
                txtbNationalID.Text = _Client.NationalID;
                txtbPhone.Text = _Client.Phone;
            }
            else
            {
                MessageBox.Show("Client ID Not Exist", "Show Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbClientID.Focus();
            }
        }

        private void txtbPhone_Leave(object sender, EventArgs e)
        {
            _Client = clsClient.GetClientByPhone(txtbPhone.Text);

            if (_Client != null)
            {
                txtbClientID.Text = _Client.ClientID.ToString();
                txtbAddress.Text = _Client.Address;
                txtbEmail.Text = _Client.Email;
                txtbName.Text = _Client.Name;
                txtbNationalID.Text = _Client.NationalID;
            }
            else
            {
                MessageBox.Show("Phone Not Exist", "Show Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbClientID.Focus();
            }
        }

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            _Client = clsClient.GetClientByEmail(txtbEmail.Text);

            if (_Client != null)
            {
                txtbClientID.Text = _Client.ClientID.ToString();
                txtbAddress.Text = _Client.Address;
                txtbName.Text = _Client.Name;
                txtbNationalID.Text = _Client.NationalID;
                txtbPhone.Text = _Client.Phone;
            }
            else
            {
                MessageBox.Show("Client Email Not Exist", "Show Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbClientID.Focus();
            }
        }

        private void txtbNationalID_Leave(object sender, EventArgs e)
        {
            _Client = clsClient.GetClientByNationalID(txtbNationalID.Text);

            if (_Client != null)
            {
                txtbClientID.Text = _Client.ClientID.ToString();
                txtbAddress.Text = _Client.Address;
                txtbName.Text = _Client.Name;
                txtbPhone.Text = _Client.Phone;
                txtbEmail.Text = _Client.Email;

            }
            else
            {
                MessageBox.Show("Client NationalID Not Exist", "Show Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbClientID.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

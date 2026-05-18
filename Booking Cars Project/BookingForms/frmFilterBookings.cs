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
    public partial class frmFilterBookings : Form
    {

        public DataTable Bookings = new DataTable();

        public frmFilterBookings()
        {
            InitializeComponent();
        }

        private void frmFilterBookings_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearErrors();

            dtpStart.Enabled = default;
            dtpEnd.Enabled = default;

            cbSearch.SelectedIndex = 0;

            txtbCarID.Enabled = true;
            txtbCarPlateNumber.Enabled = false;
            txtbClientID.Enabled = false;
            txtbClientNatioanlID.Enabled = false;
            txtbUserID.Enabled = false;
            txtbUserUsername.Enabled = false;

            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;

            cbSearch.SelectedIndex = 0;
            cbSearch.Focus();
        }

        private void ClearTextBoxes() 
        {
            txtbCarID.Text = "";
            txtbCarPlateNumber.Text = "";
            txtbClientID.Text = "";
            txtbClientNatioanlID.Text = "";
            txtbUserID.Text = "";
            txtbUserUsername.Text = "";
        }

        private void ClearErrors() 
        {
            errorProvider1.SetError(txtbClientID, "");
            errorProvider1.SetError(txtbCarID, "");
            errorProvider1.SetError(txtbCarPlateNumber, "");
            errorProvider1.SetError(txtbClientNatioanlID, "");
            errorProvider1.SetError(txtbUserID, "");
            errorProvider1.SetError(txtbUserUsername, "");
            errorProvider1.SetError(dtpStart, "");
            errorProvider1.SetError(dtpEnd, "");

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearErrors();

            txtbCarID.Enabled = false;
            txtbCarPlateNumber.Enabled = false;
            txtbClientID.Enabled = false;
            txtbClientNatioanlID.Enabled = false;
            txtbUserID.Enabled = false;
            txtbUserUsername.Enabled = false;

            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;



            switch (cbSearch.SelectedIndex)
            {
                case 0:
                    txtbCarID.Enabled = true;
                    break;
                case 1:
                    txtbCarPlateNumber.Enabled = true;
                    break;
                case 2:
                    txtbClientID.Enabled = true;
                    break;
                case 3:
                    txtbClientNatioanlID.Enabled = true;
                    break;
                case 4:
                    txtbUserID.Enabled = true;
                    break;
                case 5:
                    txtbUserUsername.Enabled = true;
                    break;
                case 6:
                    dtpStart.Enabled = true;
                    dtpEnd.Enabled = true;
                    break;
                case 7:
                    txtbCarID.Enabled = true;
                    dtpStart.Enabled = true;
                    dtpEnd.Enabled = true;
                    break;
                case 8:
                    txtbCarPlateNumber.Enabled = true;
                    dtpStart.Enabled = true;
                    dtpEnd.Enabled = true;
                    break;
            }

        
        }

        private void txtbClientID_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbClientID.Text))
            {
                errorProvider1.SetError(txtbClientID, "Client ID is required");
                btnClose.Focus();
            }
            else if (!int.TryParse(txtbClientID.Text, out int ClientID))
            {
                errorProvider1.SetError(txtbClientID, "Client ID must be a number");
                btnClose.Focus();
            }
            else if (!clsClient.IsClientExistByID(ClientID))
            {
                errorProvider1.SetError(txtbClientID, "Client ID does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbClientID, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbUserID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbUserID.Text))
            {
                errorProvider1.SetError(txtbUserID, "User ID is required");
                btnClose.Focus();
            }
            else if (!int.TryParse(txtbUserID.Text, out int UserID))
            {
                errorProvider1.SetError(txtbUserID, "User ID must be a number");
                btnClose.Focus();
            }
            else if (!clsUser.IsUserExistByID(UserID))
            {
                errorProvider1.SetError(txtbUserID, "User ID does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbUserID, "");
            }
        }

        private void txtbClientNatioanlID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbClientNatioanlID.Text))
            {
                errorProvider1.SetError(txtbClientNatioanlID, "Client National ID is required");
                btnClose.Focus();
            }
            else if (!clsClient.IsClientExistByNationalID(txtbClientNatioanlID.Text))
            {
                errorProvider1.SetError(txtbClientNatioanlID, "Client National ID does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbClientNatioanlID, "");
            }
        }

        private void txtbUserUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbUserUsername.Text))
            {
                errorProvider1.SetError(txtbUserUsername, "User Username is required");
                btnClose.Focus();
            }
            else if (!clsUser.IsUserExistByUsername(txtbUserUsername.Text))
            {
                errorProvider1.SetError(txtbUserUsername, "User Username does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbUserUsername, "");
            }
        }

        private void txtbCarID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCarID.Text))
            {
                errorProvider1.SetError(txtbCarID, "Car ID is required");
                btnClose.Focus();
            }
            else if (!int.TryParse(txtbCarID.Text, out int CarID))
            {
                errorProvider1.SetError(txtbCarID, "Car ID must be a number");
                btnClose.Focus();
            }
            else if (!clsCar.IsCarExistByID(CarID))
            {
                errorProvider1.SetError(txtbCarID, "Car ID does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbCarID, "");

            }
        }

        private void txtbCarPlateNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCarPlateNumber.Text))
            {
                errorProvider1.SetError(txtbCarPlateNumber, "Car Plate Number is required");
                btnClose.Focus();
            }
            else if (!clsCar.IsCarExistByPlateNumber(txtbCarPlateNumber.Text))
            {
                errorProvider1.SetError(txtbCarPlateNumber, "Car Plate Number does not exist");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbCarPlateNumber, "");
            }
        }

        private void dtpStart_Leave(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpStart, "Invalid Date");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(dtpStart, "");
            }
        }

        private void dtpEnd_Leave(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                errorProvider1.SetError(dtpEnd, "Invalid Date");
                btnClose.Focus();
            }
            else
            {
                errorProvider1.SetError(dtpEnd, "");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            switch (cbSearch.SelectedIndex)
            {
                case 0: // Car ID
                    Bookings = clsBooking.GetBookingsByCarID(Convert.ToInt32(txtbCarID.Text));
                    break;

                case 1: // Plate Number
                    var car = clsCar.GetCarByPlateNumber(txtbCarPlateNumber.Text);
                    if (car == null)
                    {
                        MessageBox.Show("Car not found.");
                        this.Close();
                        return;
                    }
                    Bookings = clsBooking.GetBookingsByCarID(car.CarID);
                    break;

                case 2: // Client ID
                    Bookings = clsBooking.GetBookingsByClientID(Convert.ToInt32(txtbClientID.Text));
                    break;

                case 3: // Client National ID
                    var client = clsClient.GetClientByNationalID(txtbClientNatioanlID.Text);
                    if (client == null)
                    {
                        MessageBox.Show("Client not found.");
                        this.Close();
                        return;
                    }
                    Bookings = clsBooking.GetBookingsByClientID(client.ClientID);
                    break;

                case 4: // User ID
                    Bookings = clsBooking.GetBookingsByUserID(Convert.ToInt32(txtbUserID.Text));
                    break;

                case 5: // Username
                    var user = clsUser.GetUserByUsername(txtbUserUsername.Text);
                    if (user == null)
                    {
                        MessageBox.Show("User not found.");
                        this.Close();
                        return;
                    }
                    Bookings = clsBooking.GetBookingsByUserID(user.UserID);
                    break;

                case 6: // By Date
                    Bookings = clsBooking.GetBookingsByDateRange(dtpStart.Value, dtpEnd.Value);
                    break;

                case 7: // CarID + Date Range
                    Bookings = clsBooking.GetBookingsByCarIDAndDateRange(
                        Convert.ToInt32(txtbCarID.Text),
                        dtpStart.Value,
                        dtpEnd.Value
                    );
                    break;

                case 8: // Plate + Date Range
                    var car2 = clsCar.GetCarByPlateNumber(txtbCarPlateNumber.Text);
                    if (car2 == null)
                    {
                        MessageBox.Show("Car not found.");
                        this.Close();
                        return;
                    }
                    Bookings = clsBooking.GetBookingsByCarIDAndDateRange(
                        car2.CarID,
                        dtpStart.Value,
                        dtpEnd.Value
                    );
                    break;
            }

            this.Close();
        }
    }
}

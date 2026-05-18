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
    public partial class frmUpdateBooking : Form
    {
        private clsBooking _Booking = new clsBooking();

        public frmUpdateBooking(int BookingID)
        {
            InitializeComponent();

            _Booking = clsBooking.GetBookingByID(BookingID);
        }
        private void DisableTextBoxes()
        {
            txtbCarID.Enabled = false;
            txtbClientID.Enabled = false;
            txtbTotalPrice.Enabled = false;
            txtbUserID.Enabled = false;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }

        private void _LoadBookingData() 
        {
            txtbCarID.Text = _Booking.CarID.ToString();
            txtbClientID.Text = _Booking.ClientID.ToString();
            txtbUserID.Text = _Booking.UserID.ToString();
            txtbTotalPrice.Text = _Booking.TotalPrice.ToString();
            txtbBookingID.Text = _Booking.BookingID.ToString();

            dtpStart.Value = _Booking.StartDate;
            dtpEnd.Value = _Booking.EndDate;
        }
        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
            if (_Booking != null) 
            {
                _LoadBookingData();
            }
        }

        private void txtbClientID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbClientID.Text))
            {
                errorProvider1.SetError(txtbClientID, "Client Is Required");
                txtbClientID.Focus();
            }
            else if (!clsClient.IsClientExistByID(Convert.ToInt32(txtbClientID.Text)))
            {
                errorProvider1.SetError(txtbClientID, "Client Is Not Exist");
                txtbClientID.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbClientID, "");
            }
        }

        private void txtbUserID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbClientID.Text))
            {
                errorProvider1.SetError(txtbUserID, "User Is Required");
                txtbUserID.Focus();
            }
            else if (!clsUser.IsUserExistByID(Convert.ToInt32(txtbUserID.Text)))
            {
                errorProvider1.SetError(txtbUserID, "User Is Not Exist");
                txtbUserID.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbUserID, "");
            }
        }

        private void txtbCarID_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbCarID.Text))
            {
                errorProvider1.SetError(txtbCarID, "Car Is Required");
                txtbCarID.Focus();
            }
            else if (!clsCar.IsCarExistByID(Convert.ToInt32(txtbCarID.Text)))
            {
                errorProvider1.SetError(txtbCarID, "Car Is Not Exist");
                txtbCarID.Focus();
            }
            else
            {
                errorProvider1.SetError(txtbCarID, "");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
        
        }

        private void dtpStart_Leave(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpStart, "Invalid Date");
                dtpStart.Focus();
            }
        }

        private void dtpEnd_Leave(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                errorProvider1.SetError(dtpEnd, "Invalid Date");
                dtpEnd.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            switch (_Booking.Save())
            {
                case clsBooking.enError.NoError:
                    MessageBox.Show("Booking Updated Successfully", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case clsBooking.enError.CarIDError:
                    MessageBox.Show("Car ID Error", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.ClientIDError:
                    MessageBox.Show("Client ID Error", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.UserIDError:
                    MessageBox.Show("User ID Error", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.BookingIDError:
                    MessageBox.Show("Booking ID Error", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.UnknowError:
                    MessageBox.Show("Booking Unknown Error", "Update Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            btnPayment.Enabled = false;
        }

        private void btnCalculateTotalPrice_Click_1(object sender, EventArgs e)
        {
            if (clsBooking.IsCarBookedInDateRange(Convert.ToInt32(txtbCarID.Text), dtpStart.Value, dtpEnd.Value))
            {
                MessageBox.Show("Booking Is Exist", "Booking A Car", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            txtbTotalPrice.Text = clsBooking.CalculateTotalPrice(Convert.ToInt32(txtbCarID.Text), dtpStart.Value, dtpEnd.Value).ToString();
            btnCalculateTotalPrice.Enabled = false;

            _Booking.CarID = Convert.ToInt32(txtbCarID.Text);
            _Booking.StartDate = dtpStart.Value;
            _Booking.EndDate = dtpEnd.Value;
            _Booking.ClientID = Convert.ToInt32(txtbClientID.Text);
            _Booking.UserID = Convert.ToInt32(txtbUserID.Text);
            _Booking.TotalPrice = Convert.ToDecimal(txtbTotalPrice.Text);

            DisableTextBoxes();

            btnPayment.Enabled = true;

        }


    }
}

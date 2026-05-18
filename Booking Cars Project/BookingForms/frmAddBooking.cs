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
    public partial class frmAddBooking : Form
    {

        public clsBooking _Booking = new clsBooking();
        public frmAddBooking()
        {
            InitializeComponent();
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

        private void ResetTextBoxes()
        {
            txtbCarID.Text = "";
            txtbClientID.Text = "";
            txtbTotalPrice.Text = "";
            txtbUserID.Text = "";

            dtpStart.ResetText();
            dtpEnd.ResetText();
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

        private void btnCalculateTotalPrice_Click(object sender, EventArgs e)
        {
            if (clsBooking.IsCarBookedInDateRange(Convert.ToInt32(txtbCarID.Text), dtpStart.Value, dtpEnd.Value)) 
            {
                MessageBox.Show("Booking Is Exist", "Booking A Car", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ResetTextBoxes();
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            switch (_Booking.Save())
            {
                case clsBooking.enError.NoError:
                    MessageBox.Show("Booking Added Successfully", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case clsBooking.enError.CarIDError:
                    MessageBox.Show("Car ID Error", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.ClientIDError:
                    MessageBox.Show("Client ID Error", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.UserIDError:
                    MessageBox.Show("User ID Error", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.BookingIDError:
                    MessageBox.Show("Booking ID Error", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsBooking.enError.UnknowError:
                    MessageBox.Show("Booking Unknown Error", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            btnPayment.Enabled = false;

            AddPayment Form = new AddPayment(_Booking.BookingID);
            Form.ShowDialog();

            
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
    }
}

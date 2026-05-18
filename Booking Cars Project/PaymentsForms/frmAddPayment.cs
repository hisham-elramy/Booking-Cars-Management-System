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
    public partial class AddPayment : Form
    {
        private clsPayment _Payment = new clsPayment();

        public AddPayment(int BookingID)
        {
            InitializeComponent();

            _Payment.BookingID = BookingID;
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            txtbBookingID.Text = _Payment.BookingID.ToString();

            cbPaymentMethods.DataSource = clsPaymentMethod.GetAllMethods();
            cbPaymentMethods.DisplayMember = "Method_Name";
            cbPaymentMethods.ValueMember = "Method_ID";

        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            _Payment.MethodID = Convert.ToInt32(cbPaymentMethods.SelectedValue);
            _Payment.PaymentDate = dtpPaymentDate.Value;

            switch (_Payment.Save())
            {
                case clsPayment.enError.NoError:
                    MessageBox.Show("Payment Added Successfully", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsPayment.enError.PaymentIDError:
                    MessageBox.Show("Payment ID Error", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsPayment.enError.BookingIDError:
                    MessageBox.Show("Booking Number Error", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsPayment.enError.PaymentDateError:
                    MessageBox.Show("Payment Date Error", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsPayment.enError.MethodIDError:
                    MessageBox.Show("Method ID Error", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsPayment.enError.UnknownError:
                    MessageBox.Show("Payment Unknown Error", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            dtpPaymentDate.Enabled = false;
            cbPaymentMethods.Enabled = false;
            btnPrintReceipt.Enabled = false;

            txtbPaymentID.Text = _Payment.PaymentID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpPaymentDate_Leave(object sender, EventArgs e)
        {
            if (dtpPaymentDate.Value < DateTime.Now) 
            {
                errorProvider1.SetError(dtpPaymentDate, "Invalid Date");
                dtpPaymentDate.Focus();
            }
        }
    }
}

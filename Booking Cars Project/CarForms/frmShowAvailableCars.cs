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
    public partial class frmShowAvailableCars : Form
    {
        public DataTable CarsTable = new DataTable();
        public frmShowAvailableCars()
        {
            InitializeComponent();
        }

        private void cbCar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCar.Checked == true)
            {
                txtbCarID.Enabled = true;
                lblCarID.Enabled = true;
            }
            else
            {
                txtbCarID.Enabled = false;
                lblCarID.Enabled = false;
            }
        }

        private void txtbCarID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCarID.Text))
            {
                errorProvider1.SetError(txtbCarID, "Car ID is required");
            }
            else if (!int.TryParse(txtbCarID.Text, out int carID))
            {
                errorProvider1.SetError(txtbCarID, "Car ID must be a number");
            }
            else if (!clsCar.IsCarExistByID(carID))
            {
                errorProvider1.SetError(txtbCarID, "Car ID does not exist");
            }
            else
            {
                errorProvider1.SetError(txtbCarID, "");
            }
        }

        private void dtpStart_Leave(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpStart, "Invalid Date");
            }
            else
            {
                errorProvider1.SetError(dtpStart, "");
            }
        }

        private void dtpEnd_Leave(object sender, EventArgs e)
        {
            if (dtpEnd.Value < DateTime.Now || dtpEnd.Value < dtpStart.Value)
            {
                errorProvider1.SetError(dtpEnd, "Invalid Date");
            }
            else
            {
                errorProvider1.SetError(dtpEnd, "");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!txtbCarID.Enabled)
            {
                if (clsCar.GetAvailableCars(dtpStart.Value, dtpEnd.Value) != null)
                {
                    CarsTable = clsCar.GetAvailableCars(dtpStart.Value, dtpEnd.Value);
                }
                else
                {
                    MessageBox.Show("An Error Happen", "Available Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                if (clsCar.GetAvailableCarsByCarID(dtpStart.Value, dtpEnd.Value, Convert.ToInt32(txtbCarID.Text)) != null)
                {
                    CarsTable = clsCar.GetAvailableCarsByCarID(dtpStart.Value, dtpEnd.Value, Convert.ToInt32(txtbCarID.Text));
                }
                else
                {
                    MessageBox.Show("An Error Happen", "Available Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmShowAvailableCars_Load(object sender, EventArgs e)
        {

        }
    }
}

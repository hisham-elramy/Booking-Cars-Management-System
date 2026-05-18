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
    public partial class frmShowCarInfo : Form
    {

        private clsCar _Car = new clsCar();

        public frmShowCarInfo()
        {
            InitializeComponent();
        }

        private void frmShowCarInfo_Load(object sender, EventArgs e)
        {
            txtbColor.Enabled = false;
            txtbModel.Enabled = false;
            txtbPlateNumber.Enabled = false;
            txtbPricePerDay.Enabled = false;
            txtbStatus.Enabled = false;
            txtbYear.Enabled = false;
        }

        private void txtbCarID_Leave(object sender, EventArgs e)
        {
            int ID = 0;

            if (int.TryParse(txtbCarID.Text, out ID))
            {
                _Car = clsCar.GetCarByID(ID);

                if (_Car != null)
                {
                    errorProvider1.SetError(txtbCarID, "");
                    txtbModel.Text = _Car.Model;
                    txtbColor.Text = _Car.Color;
                    txtbPlateNumber.Text = _Car.PlateNumber;
                    txtbPricePerDay.Text = _Car.PricePerDay.ToString();
                    txtbStatus.Text = _Car.Status.ToString();
                    txtbYear.Text = _Car.Year.ToString();
                    pbCarImage.ImageLocation = _Car.ImagePath;
                }
                else
                {
                    errorProvider1.SetError(txtbCarID, "Car ID Not Exist");
                    MessageBox.Show("Car Not Found|", "Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClose.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter A Valid ID", "Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

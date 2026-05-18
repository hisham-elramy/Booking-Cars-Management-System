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
    public partial class frmUpdateCar : Form
    {

        private clsCar _Car = new clsCar();
        public frmUpdateCar(int CarID)
        {
            InitializeComponent();

            _Car = clsCar.GetCarByID(CarID);
        }

        private void LoadCarData() 
        {
            if (_Car != null)
            { 
                txtbColor.Text = _Car.Color;
                txtbModel.Text = _Car.Model;
                txtbPlateNumber.Text = _Car.PlateNumber;
                txtbPricePerDay.Text = _Car.PricePerDay.ToString();
                txtbYear.Text = _Car.Year.ToString();
                cbStatus.Checked = _Car.Status;
                pbCarImage.ImageLocation = _Car.ImagePath;
                lblCarID.Text = _Car.CarID.ToString();
            }
        }

        private void frmUpstaeCar_Load(object sender, EventArgs e)
        {
            LoadCarData();
            if (pbCarImage.ImageLocation != null || pbCarImage.ImageLocation != "")
            {
                llblDeleteCarImage.Visible = true;
            }
            else
            {
                llblDeleteCarImage.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Car.Color = txtbColor.Text;
            _Car.Model = txtbModel.Text;
            _Car.PlateNumber = txtbPlateNumber.Text;
            _Car.PricePerDay = Convert.ToDecimal(txtbPricePerDay.Text);
            _Car.Year = Convert.ToInt32(txtbYear.Text);
            _Car.Status = cbStatus.Checked;
            _Car.ImagePath = pbCarImage.ImageLocation;
            _Car.CarID = Convert.ToInt32(lblCarID.Text);

            switch (_Car.Save())
            {
                case clsCar.enError.NoError:
                    MessageBox.Show("Car Updated Successfully", "Update Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.CarIDError:
                    MessageBox.Show("Car ID Error", "Update Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.PlateNumberError:
                    MessageBox.Show("Car Plate Number Error", "Update Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.UnknownError:
                    MessageBox.Show("Car Unknown Error", "Update Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblSetCarImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbCarImage.Load(selectedFilePath);
                llblDeleteCarImage.Visible = true;
            }

        }

        private void llblDeleteCarImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCarImage.ImageLocation = null;
            llblDeleteCarImage.Visible = false;
        }
    }
}

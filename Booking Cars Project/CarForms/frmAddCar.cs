using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_Cars_Project
{
    public partial class frmAddCar : Form
    {

        
        public frmAddCar()
        {
            InitializeComponent();
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

        private void LoadCarData() 
        {
            clsCar Car = new clsCar();
            Car.Year = Convert.ToInt32(txtbYear.Text);
            Car.Model = txtbModel.Text;
            Car.Color = txtbColor.Text;
            Car.ImagePath = pbCarImage.ImageLocation;
            Car.PlateNumber = txtbPlateNumber.Text;
            Car.PricePerDay = Convert.ToDecimal(txtbPricePerDay.Text);
            Car.Status = cbStatus.Checked;

            switch (Car.Save())
            {
                case clsCar.enError.NoError:
                    MessageBox.Show("Car Added Successfully", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.CarIDError:
                    MessageBox.Show("Car ID Error", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.PlateNumberError:
                    MessageBox.Show("Plate Number Error", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsCar.enError.UnknownError:
                    MessageBox.Show("Car Unknown Error", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            txtbYear.Enabled = false;
            txtbModel.Enabled = false;
            txtbColor.Enabled = false;
            pbCarImage.Enabled = false;
            txtbPlateNumber.Enabled = false;
            txtbPricePerDay.Enabled = false;
            btnSave.Enabled = false;
            llblDeleteCarImage.Enabled = false;
            llblSetCarImage.Enabled = false;
            pbCarImage.Enabled = false;
            cbStatus.Enabled = false;

            lblCarID.Text = Car.CarID.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadCarData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCar_Load(object sender, EventArgs e)
        {

        }
    }
}

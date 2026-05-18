using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_Cars_Project
{
    public partial class frmMain : Form
    {

        frmShowAvailableCars Form = new frmShowAvailableCars();
        frmFilterBookings Form2 = new frmFilterBookings();
        public frmMain()
        {
            InitializeComponent();
        }

        private void _LoadUsersDataTodgvUsers() 
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadUsersDataTodgvUsers();
            _LoadCars();
            _LoadClients();
            _LoadBookings();
            _LoadPayments();
            _LoadPaymentMethods();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure To Delete User With ID = " + ((int)dgvUsers.CurrentRow.Cells[0].Value) + "?", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(((int)dgvUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("User Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else 
                {
                    MessageBox.Show("User Not Deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            _LoadUsersDataTodgvUsers();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            frmUpdateUser Form = new frmUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Form.ShowDialog();

            _LoadUsersDataTodgvUsers();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddUser Form = new frmAddUser();
            Form.ShowDialog();

            _LoadUsersDataTodgvUsers();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo Form = new frmShowUserInfo();
            Form.ShowDialog();

            
        }

        private void _LoadCars() 
        {
            dgvShowCars.DataSource = clsCar.GetAllCars();
        }
        private void dgvShowCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnShowCarInfo_Click(object sender, EventArgs e)
        {
            frmShowCarInfo Form = new frmShowCarInfo();
            Form.ShowDialog();

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            frmAddCar Form = new frmAddCar();
            Form.ShowDialog();

            _LoadCars();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCar Form = new frmUpdateCar((int)dgvShowCars.CurrentRow.Cells[0].Value);
            Form.ShowDialog();

            _LoadCars();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Tou Sure To Delete Car With ID = " + ((int)dgvShowCars.CurrentRow.Cells[0].Value) + "?", "Delete Car", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK) 
            {
                if (clsCar.DeleteCar((int)dgvShowCars.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Car Deleted Successfully", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else 
                {
                    MessageBox.Show("Car Not Deleted", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _LoadCars();

            }
        }

        private void btnShowAvailableCars_Click(object sender, EventArgs e)
        {
            Form.ShowDialog();

            dgvShowCars.DataSource = Form.CarsTable;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllCars_Click(object sender, EventArgs e)
        {
            _LoadCars();
        }

        private void _LoadClients() 
        {
            dgvShowClients.DataSource = clsClient.GetAllClients();
        }

        private void dgvShowClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnShowClientInfo_Click(object sender, EventArgs e)
        {
            frmShowClientInfo Form = new frmShowClientInfo();
            Form.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmUpdateClient Form = new frmUpdateClient();
            Form.ShowDialog();

            _LoadClients();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddClient Form = new frmAddClient();
            Form.ShowDialog();

            _LoadClients();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure To Delete Client With ID = " + ((int)dgvUsers.CurrentRow.Cells[0].Value) + "?", "Delete Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(((int)dgvUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Client Deleted Successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            _LoadClients();
        }


        private void _LoadBookings() 
        {
            dgvShowBookings.DataSource = clsBooking.GetAllBookings();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            frmAddBooking Form = new frmAddBooking();
            Form.ShowDialog();

            _LoadBookings();
        }

        private void ResetTextBoxes()
        {
            
        }

        private void btnFilterBookings_Click(object sender, EventArgs e)
        {
            

            Form2.ShowDialog();

            if (Form2.Bookings == null)
            {
                dgvShowBookings.DataSource = null;
            }
            else
            {
                dgvShowBookings.DataSource = Form2.Bookings;
            }
        }

        private void btnShowAllBookings_Click(object sender, EventArgs e)
        {
            _LoadBookings();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dgvShowBookings.Refresh();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdateBooking Form = new frmUpdateBooking(Convert.ToInt32(dgvShowBookings.CurrentRow.Cells[0].Value));
            Form.ShowDialog();

            _LoadBookings();
            _LoadPayments();
            _LoadPaymentMethods();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete Booking With ID = " + Convert.ToInt32(dgvShowBookings.CurrentRow.Cells[0].Value) + "?", "Delete Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) 
            {
                if (MessageBox.Show("System Will Delete Payment With ID = " + clsPayment.GetPaymentByBookingID(Convert.ToInt32(dgvShowBookings.CurrentRow.Cells[0].Value)).PaymentID + "?", "Delete Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (clsPayment.DeletePayment(clsPayment.GetPaymentByBookingID(Convert.ToInt32(dgvShowBookings.CurrentRow.Cells[0].Value)).PaymentID))
                    {
                        MessageBox.Show("Payment Deleted Successfully", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (clsBooking.DeleteBooking(Convert.ToInt32(dgvShowBookings.CurrentRow.Cells[0].Value)))
                        {
                            MessageBox.Show("Booking Deleted Successfully", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Booking Not Deleted", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Payment Not Deleted", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            _LoadBookings();
            _LoadPayments();
            _LoadPaymentMethods();
        }

        private void dgvShowBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _LoadPayments() 
        {
            dgvShowPayments.DataSource = clsPayment.GetAllPayments();
        }

        private void _LoadPaymentMethods() 
        {
            dgvShowPaymentMethods.DataSource = clsPaymentMethod.GetAllMethods();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            _LoadPayments();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace Booking_Cars_Project
{
    partial class frmUpdateBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBooking));
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtbUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbCarID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalculateTotalPrice = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.AutoRoundedCorners = true;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.Enabled = false;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(572, 277);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(156, 48);
            this.btnPayment.TabIndex = 94;
            this.btnPayment.Text = "Update";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(572, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 48);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(388, 196);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(89, 26);
            this.guna2HtmlLabel8.TabIndex = 91;
            this.guna2HtmlLabel8.Text = "End Date";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(105, 196);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(92, 26);
            this.guna2HtmlLabel7.TabIndex = 90;
            this.guna2HtmlLabel7.Text = "Start Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Animated = true;
            this.dtpEnd.AutoRoundedCorners = true;
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(294, 228);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(272, 36);
            this.dtpEnd.TabIndex = 89;
            this.dtpEnd.Value = new System.DateTime(2025, 11, 24, 8, 6, 41, 30);
            // 
            // dtpStart
            // 
            this.dtpStart.Animated = true;
            this.dtpStart.AutoRoundedCorners = true;
            this.dtpStart.BackColor = System.Drawing.Color.Transparent;
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(15, 228);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(273, 36);
            this.dtpStart.TabIndex = 88;
            this.dtpStart.Value = new System.DateTime(2025, 11, 24, 8, 6, 41, 30);
            // 
            // txtbUserID
            // 
            this.txtbUserID.Animated = true;
            this.txtbUserID.AutoRoundedCorners = true;
            this.txtbUserID.BorderRadius = 12;
            this.txtbUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbUserID.DefaultText = "";
            this.txtbUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUserID.Location = new System.Drawing.Point(78, 138);
            this.txtbUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbUserID.Name = "txtbUserID";
            this.txtbUserID.PlaceholderText = "";
            this.txtbUserID.SelectedText = "";
            this.txtbUserID.Size = new System.Drawing.Size(90, 26);
            this.txtbUserID.TabIndex = 81;
            this.txtbUserID.Leave += new System.EventHandler(this.txtbUserID_Leave);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(87, 106);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(71, 26);
            this.guna2HtmlLabel4.TabIndex = 80;
            this.guna2HtmlLabel4.Text = "User ID";
            // 
            // txtbClientID
            // 
            this.txtbClientID.Animated = true;
            this.txtbClientID.AutoRoundedCorners = true;
            this.txtbClientID.BorderRadius = 12;
            this.txtbClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbClientID.DefaultText = "";
            this.txtbClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbClientID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbClientID.Location = new System.Drawing.Point(418, 138);
            this.txtbClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbClientID.Name = "txtbClientID";
            this.txtbClientID.PlaceholderText = "";
            this.txtbClientID.SelectedText = "";
            this.txtbClientID.Size = new System.Drawing.Size(90, 26);
            this.txtbClientID.TabIndex = 79;
            this.txtbClientID.Leave += new System.EventHandler(this.txtbClientID_Leave);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(420, 106);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(81, 26);
            this.guna2HtmlLabel3.TabIndex = 78;
            this.guna2HtmlLabel3.Text = "Client ID";
            // 
            // txtbCarID
            // 
            this.txtbCarID.Animated = true;
            this.txtbCarID.AutoRoundedCorners = true;
            this.txtbCarID.BorderRadius = 12;
            this.txtbCarID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCarID.DefaultText = "";
            this.txtbCarID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbCarID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbCarID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCarID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCarID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCarID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbCarID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCarID.Location = new System.Drawing.Point(249, 138);
            this.txtbCarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCarID.Name = "txtbCarID";
            this.txtbCarID.PlaceholderText = "";
            this.txtbCarID.SelectedText = "";
            this.txtbCarID.Size = new System.Drawing.Size(90, 26);
            this.txtbCarID.TabIndex = 77;
            this.txtbCarID.Leave += new System.EventHandler(this.txtbCarID_Leave);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(259, 106);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 26);
            this.guna2HtmlLabel1.TabIndex = 76;
            this.guna2HtmlLabel1.Text = "Car ID";
            // 
            // txtbTotalPrice
            // 
            this.txtbTotalPrice.Animated = true;
            this.txtbTotalPrice.AutoRoundedCorners = true;
            this.txtbTotalPrice.BorderRadius = 12;
            this.txtbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbTotalPrice.DefaultText = "";
            this.txtbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbTotalPrice.Enabled = false;
            this.txtbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbTotalPrice.Location = new System.Drawing.Point(588, 138);
            this.txtbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbTotalPrice.Name = "txtbTotalPrice";
            this.txtbTotalPrice.PlaceholderText = "";
            this.txtbTotalPrice.SelectedText = "";
            this.txtbTotalPrice.Size = new System.Drawing.Size(103, 26);
            this.txtbTotalPrice.TabIndex = 96;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(587, 106);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(103, 26);
            this.guna2HtmlLabel2.TabIndex = 95;
            this.guna2HtmlLabel2.Text = "Total Price";
            // 
            // txtbBookingID
            // 
            this.txtbBookingID.Animated = true;
            this.txtbBookingID.AutoRoundedCorners = true;
            this.txtbBookingID.BorderRadius = 12;
            this.txtbBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbBookingID.DefaultText = "";
            this.txtbBookingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbBookingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbBookingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbBookingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbBookingID.Enabled = false;
            this.txtbBookingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbBookingID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbBookingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbBookingID.Location = new System.Drawing.Point(348, 53);
            this.txtbBookingID.Name = "txtbBookingID";
            this.txtbBookingID.PlaceholderText = "";
            this.txtbBookingID.SelectedText = "";
            this.txtbBookingID.Size = new System.Drawing.Size(90, 26);
            this.txtbBookingID.TabIndex = 98;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(340, 21);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(104, 26);
            this.guna2HtmlLabel5.TabIndex = 97;
            this.guna2HtmlLabel5.Text = "Booking ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCalculateTotalPrice
            // 
            this.btnCalculateTotalPrice.Animated = true;
            this.btnCalculateTotalPrice.AutoRoundedCorners = true;
            this.btnCalculateTotalPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateTotalPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculateTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculateTotalPrice.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalculateTotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCalculateTotalPrice.ForeColor = System.Drawing.Color.White;
            this.btnCalculateTotalPrice.Location = new System.Drawing.Point(130, 355);
            this.btnCalculateTotalPrice.Name = "btnCalculateTotalPrice";
            this.btnCalculateTotalPrice.Size = new System.Drawing.Size(294, 48);
            this.btnCalculateTotalPrice.TabIndex = 99;
            this.btnCalculateTotalPrice.Text = "Calculate Total Price";
            this.btnCalculateTotalPrice.Click += new System.EventHandler(this.btnCalculateTotalPrice_Click_1);
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateTotalPrice);
            this.Controls.Add(this.txtbBookingID);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtbTotalPrice);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtbUserID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtbClientID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtbCarID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateBooking";
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2TextBox txtbUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtbClientID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtbCarID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtbBookingID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnCalculateTotalPrice;
    }
}
namespace Booking_Cars_Project
{
    partial class frmFilterBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilterBookings));
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbCarID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbCarPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbClientNatioanlID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbUserUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearch
            // 
            this.cbSearch.AutoRoundedCorners = true;
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.Items.AddRange(new object[] {
            "Car ID",
            "Car Plate Number",
            "Client ID",
            "Client National ID",
            "User ID",
            "User Username",
            "Date Range",
            "Date Range With Car ID",
            "Date Range With Car Plate Number"});
            this.cbSearch.Location = new System.Drawing.Point(532, 73);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(243, 36);
            this.cbSearch.TabIndex = 0;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(321, 229);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 26);
            this.guna2HtmlLabel1.TabIndex = 48;
            this.guna2HtmlLabel1.Text = "Car ID";
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
            this.txtbCarID.Location = new System.Drawing.Point(321, 271);
            this.txtbCarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCarID.Name = "txtbCarID";
            this.txtbCarID.PlaceholderText = "";
            this.txtbCarID.SelectedText = "";
            this.txtbCarID.Size = new System.Drawing.Size(90, 26);
            this.txtbCarID.TabIndex = 57;
            this.txtbCarID.Leave += new System.EventHandler(this.txtbCarID_Leave);
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
            this.txtbClientID.Location = new System.Drawing.Point(47, 73);
            this.txtbClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbClientID.Name = "txtbClientID";
            this.txtbClientID.PlaceholderText = "";
            this.txtbClientID.SelectedText = "";
            this.txtbClientID.Size = new System.Drawing.Size(90, 26);
            this.txtbClientID.TabIndex = 59;
            this.txtbClientID.Leave += new System.EventHandler(this.txtbClientID_Leave);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(47, 41);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(81, 26);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "Client ID";
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
            this.txtbUserID.Location = new System.Drawing.Point(47, 161);
            this.txtbUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbUserID.Name = "txtbUserID";
            this.txtbUserID.PlaceholderText = "";
            this.txtbUserID.SelectedText = "";
            this.txtbUserID.Size = new System.Drawing.Size(90, 26);
            this.txtbUserID.TabIndex = 61;
            this.txtbUserID.Leave += new System.EventHandler(this.txtbUserID_Leave);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(47, 129);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(71, 26);
            this.guna2HtmlLabel4.TabIndex = 60;
            this.guna2HtmlLabel4.Text = "User ID";
            // 
            // txtbCarPlateNumber
            // 
            this.txtbCarPlateNumber.Animated = true;
            this.txtbCarPlateNumber.AutoRoundedCorners = true;
            this.txtbCarPlateNumber.BorderRadius = 12;
            this.txtbCarPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCarPlateNumber.DefaultText = "";
            this.txtbCarPlateNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbCarPlateNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbCarPlateNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCarPlateNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCarPlateNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCarPlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbCarPlateNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCarPlateNumber.Location = new System.Drawing.Point(321, 371);
            this.txtbCarPlateNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCarPlateNumber.Name = "txtbCarPlateNumber";
            this.txtbCarPlateNumber.PlaceholderText = "";
            this.txtbCarPlateNumber.SelectedText = "";
            this.txtbCarPlateNumber.Size = new System.Drawing.Size(177, 26);
            this.txtbCarPlateNumber.TabIndex = 63;
            this.txtbCarPlateNumber.Leave += new System.EventHandler(this.txtbCarPlateNumber_Leave);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(321, 329);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(168, 26);
            this.guna2HtmlLabel2.TabIndex = 62;
            this.guna2HtmlLabel2.Text = "Car Plate Number";
            // 
            // txtbClientNatioanlID
            // 
            this.txtbClientNatioanlID.Animated = true;
            this.txtbClientNatioanlID.AutoRoundedCorners = true;
            this.txtbClientNatioanlID.BorderRadius = 12;
            this.txtbClientNatioanlID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbClientNatioanlID.DefaultText = "";
            this.txtbClientNatioanlID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbClientNatioanlID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbClientNatioanlID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbClientNatioanlID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbClientNatioanlID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbClientNatioanlID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbClientNatioanlID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbClientNatioanlID.Location = new System.Drawing.Point(303, 73);
            this.txtbClientNatioanlID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbClientNatioanlID.Name = "txtbClientNatioanlID";
            this.txtbClientNatioanlID.PlaceholderText = "";
            this.txtbClientNatioanlID.SelectedText = "";
            this.txtbClientNatioanlID.Size = new System.Drawing.Size(177, 26);
            this.txtbClientNatioanlID.TabIndex = 65;
            this.txtbClientNatioanlID.Leave += new System.EventHandler(this.txtbClientNatioanlID_Leave);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(303, 41);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(163, 26);
            this.guna2HtmlLabel5.TabIndex = 64;
            this.guna2HtmlLabel5.Text = "Client National ID";
            // 
            // txtbUserUsername
            // 
            this.txtbUserUsername.Animated = true;
            this.txtbUserUsername.AutoRoundedCorners = true;
            this.txtbUserUsername.BorderRadius = 12;
            this.txtbUserUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbUserUsername.DefaultText = "";
            this.txtbUserUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbUserUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbUserUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUserUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbUserUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUserUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbUserUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbUserUsername.Location = new System.Drawing.Point(303, 161);
            this.txtbUserUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbUserUsername.Name = "txtbUserUsername";
            this.txtbUserUsername.PlaceholderText = "";
            this.txtbUserUsername.SelectedText = "";
            this.txtbUserUsername.Size = new System.Drawing.Size(177, 26);
            this.txtbUserUsername.TabIndex = 67;
            this.txtbUserUsername.Leave += new System.EventHandler(this.txtbUserUsername_Leave);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(303, 129);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(147, 26);
            this.guna2HtmlLabel6.TabIndex = 66;
            this.guna2HtmlLabel6.Text = "User Username";
            // 
            // dtpStart
            // 
            this.dtpStart.Animated = true;
            this.dtpStart.AutoRoundedCorners = true;
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(12, 261);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(274, 36);
            this.dtpStart.TabIndex = 68;
            this.dtpStart.Value = new System.DateTime(2025, 11, 24, 8, 6, 41, 30);
            this.dtpStart.Leave += new System.EventHandler(this.dtpStart_Leave);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Animated = true;
            this.dtpEnd.AutoRoundedCorners = true;
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(12, 361);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(274, 36);
            this.dtpEnd.TabIndex = 69;
            this.dtpEnd.Value = new System.DateTime(2025, 11, 24, 8, 6, 41, 30);
            this.dtpEnd.Leave += new System.EventHandler(this.dtpEnd_Leave);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(56, 229);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(92, 26);
            this.guna2HtmlLabel7.TabIndex = 70;
            this.guna2HtmlLabel7.Text = "Start Date";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(59, 329);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(89, 26);
            this.guna2HtmlLabel8.TabIndex = 71;
            this.guna2HtmlLabel8.Text = "End Date";
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
            this.btnClose.Location = new System.Drawing.Point(583, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 48);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(600, 41);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(98, 26);
            this.guna2HtmlLabel9.TabIndex = 73;
            this.guna2HtmlLabel9.Text = "Search By";
            // 
            // btnApply
            // 
            this.btnApply.Animated = true;
            this.btnApply.AutoRoundedCorners = true;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(583, 271);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(156, 48);
            this.btnApply.TabIndex = 74;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFilterBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtbUserUsername);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtbClientNatioanlID);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtbCarPlateNumber);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtbUserID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtbClientID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtbCarID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilterBookings";
            this.Text = "Filter Bookings";
            this.Load += new System.EventHandler(this.frmFilterBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbCarID;
        private Guna.UI2.WinForms.Guna2TextBox txtbClientID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtbUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtbCarPlateNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtbClientNatioanlID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtbUserUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Button btnApply;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
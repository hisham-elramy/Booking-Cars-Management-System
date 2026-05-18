namespace Booking_Cars_Project
{
    partial class frmShowCarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowCarInfo));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtbCarID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(171, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.txtbCarID.Location = new System.Drawing.Point(222, 28);
            this.txtbCarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCarID.Name = "txtbCarID";
            this.txtbCarID.PlaceholderText = "";
            this.txtbCarID.SelectedText = "";
            this.txtbCarID.Size = new System.Drawing.Size(88, 26);
            this.txtbCarID.TabIndex = 72;
            this.txtbCarID.Leave += new System.EventHandler(this.txtbCarID_Leave);
            // 
            // txtbModel
            // 
            this.txtbModel.Animated = true;
            this.txtbModel.AutoRoundedCorners = true;
            this.txtbModel.BorderRadius = 12;
            this.txtbModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbModel.DefaultText = "";
            this.txtbModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbModel.Location = new System.Drawing.Point(12, 121);
            this.txtbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbModel.Name = "txtbModel";
            this.txtbModel.PlaceholderText = "";
            this.txtbModel.SelectedText = "";
            this.txtbModel.Size = new System.Drawing.Size(200, 26);
            this.txtbModel.TabIndex = 71;
            // 
            // txtbYear
            // 
            this.txtbYear.Animated = true;
            this.txtbYear.AutoRoundedCorners = true;
            this.txtbYear.BorderRadius = 12;
            this.txtbYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbYear.DefaultText = "";
            this.txtbYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbYear.Location = new System.Drawing.Point(12, 197);
            this.txtbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.PlaceholderText = "";
            this.txtbYear.SelectedText = "";
            this.txtbYear.Size = new System.Drawing.Size(200, 26);
            this.txtbYear.TabIndex = 70;
            // 
            // txtbStatus
            // 
            this.txtbStatus.Animated = true;
            this.txtbStatus.AutoRoundedCorners = true;
            this.txtbStatus.BorderRadius = 12;
            this.txtbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbStatus.DefaultText = "";
            this.txtbStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbStatus.Location = new System.Drawing.Point(257, 197);
            this.txtbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.PlaceholderText = "";
            this.txtbStatus.SelectedText = "";
            this.txtbStatus.Size = new System.Drawing.Size(200, 26);
            this.txtbStatus.TabIndex = 69;
            // 
            // txtbPricePerDay
            // 
            this.txtbPricePerDay.Animated = true;
            this.txtbPricePerDay.AutoRoundedCorners = true;
            this.txtbPricePerDay.BorderRadius = 12;
            this.txtbPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbPricePerDay.DefaultText = "";
            this.txtbPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPricePerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPricePerDay.Location = new System.Drawing.Point(257, 121);
            this.txtbPricePerDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPricePerDay.Name = "txtbPricePerDay";
            this.txtbPricePerDay.PlaceholderText = "";
            this.txtbPricePerDay.SelectedText = "";
            this.txtbPricePerDay.Size = new System.Drawing.Size(200, 26);
            this.txtbPricePerDay.TabIndex = 68;
            // 
            // txtbColor
            // 
            this.txtbColor.Animated = true;
            this.txtbColor.AutoRoundedCorners = true;
            this.txtbColor.BorderRadius = 12;
            this.txtbColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbColor.DefaultText = "";
            this.txtbColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbColor.Location = new System.Drawing.Point(257, 273);
            this.txtbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbColor.Name = "txtbColor";
            this.txtbColor.PlaceholderText = "";
            this.txtbColor.SelectedText = "";
            this.txtbColor.Size = new System.Drawing.Size(200, 26);
            this.txtbColor.TabIndex = 67;
            // 
            // txtbPlateNumber
            // 
            this.txtbPlateNumber.Animated = true;
            this.txtbPlateNumber.AutoRoundedCorners = true;
            this.txtbPlateNumber.BorderRadius = 12;
            this.txtbPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbPlateNumber.DefaultText = "";
            this.txtbPlateNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbPlateNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbPlateNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPlateNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbPlateNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtbPlateNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbPlateNumber.Location = new System.Drawing.Point(12, 273);
            this.txtbPlateNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPlateNumber.Name = "txtbPlateNumber";
            this.txtbPlateNumber.PlaceholderText = "";
            this.txtbPlateNumber.SelectedText = "";
            this.txtbPlateNumber.Size = new System.Drawing.Size(200, 26);
            this.txtbPlateNumber.TabIndex = 66;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(257, 89);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(130, 26);
            this.guna2HtmlLabel9.TabIndex = 64;
            this.guna2HtmlLabel9.Text = "Price Per Day";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(257, 165);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(59, 26);
            this.guna2HtmlLabel8.TabIndex = 63;
            this.guna2HtmlLabel8.Text = "Status";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(257, 241);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(53, 26);
            this.guna2HtmlLabel6.TabIndex = 62;
            this.guna2HtmlLabel6.Text = "Color";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 241);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(130, 26);
            this.guna2HtmlLabel5.TabIndex = 61;
            this.guna2HtmlLabel5.Text = "Plate Number";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 165);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(46, 26);
            this.guna2HtmlLabel3.TabIndex = 59;
            this.guna2HtmlLabel3.Text = "Year";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 89);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 26);
            this.guna2HtmlLabel2.TabIndex = 58;
            this.guna2HtmlLabel2.Text = "Model";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(152, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 26);
            this.guna2HtmlLabel1.TabIndex = 57;
            this.guna2HtmlLabel1.Text = "Car ID";
            // 
            // pbCarImage
            // 
            this.pbCarImage.Location = new System.Drawing.Point(482, 12);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(306, 422);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 74;
            this.pbCarImage.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmShowCarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbCarID);
            this.Controls.Add(this.txtbModel);
            this.Controls.Add(this.txtbYear);
            this.Controls.Add(this.txtbStatus);
            this.Controls.Add(this.txtbPricePerDay);
            this.Controls.Add(this.txtbColor);
            this.Controls.Add(this.txtbPlateNumber);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowCarInfo";
            this.Text = "Show Car Info";
            this.Load += new System.EventHandler(this.frmShowCarInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtbCarID;
        private Guna.UI2.WinForms.Guna2TextBox txtbModel;
        private Guna.UI2.WinForms.Guna2TextBox txtbYear;
        private Guna.UI2.WinForms.Guna2TextBox txtbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtbPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtbColor;
        private Guna.UI2.WinForms.Guna2TextBox txtbPlateNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
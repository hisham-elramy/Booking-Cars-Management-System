namespace Booking_Cars_Project
{
    partial class frmUpdateCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCar));
            this.cbStatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.llblDeleteCarImage = new System.Windows.Forms.LinkLabel();
            this.llblSetCarImage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtbModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCarID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.CheckedState.BorderRadius = 0;
            this.cbStatus.CheckedState.BorderThickness = 0;
            this.cbStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.Location = new System.Drawing.Point(317, 276);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(122, 37);
            this.cbStatus.TabIndex = 79;
            this.cbStatus.Text = "Status";
            this.cbStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbStatus.UncheckedState.BorderRadius = 0;
            this.cbStatus.UncheckedState.BorderThickness = 0;
            this.cbStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // llblDeleteCarImage
            // 
            this.llblDeleteCarImage.AutoSize = true;
            this.llblDeleteCarImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblDeleteCarImage.LinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.llblDeleteCarImage.Location = new System.Drawing.Point(676, 50);
            this.llblDeleteCarImage.Name = "llblDeleteCarImage";
            this.llblDeleteCarImage.Size = new System.Drawing.Size(117, 20);
            this.llblDeleteCarImage.TabIndex = 78;
            this.llblDeleteCarImage.TabStop = true;
            this.llblDeleteCarImage.Text = "Delete Image";
            this.llblDeleteCarImage.Visible = false;
            this.llblDeleteCarImage.VisitedLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.llblDeleteCarImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDeleteCarImage_LinkClicked);
            // 
            // llblSetCarImage
            // 
            this.llblSetCarImage.AutoSize = true;
            this.llblSetCarImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSetCarImage.LinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.llblSetCarImage.Location = new System.Drawing.Point(514, 50);
            this.llblSetCarImage.Name = "llblSetCarImage";
            this.llblSetCarImage.Size = new System.Drawing.Size(92, 20);
            this.llblSetCarImage.TabIndex = 76;
            this.llblSetCarImage.TabStop = true;
            this.llblSetCarImage.Text = "Set Image";
            this.llblSetCarImage.VisitedLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.llblSetCarImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetCarImage_LinkClicked);
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
            this.btnClose.Location = new System.Drawing.Point(281, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(99, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 45);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtbModel.Location = new System.Drawing.Point(24, 124);
            this.txtbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbModel.Name = "txtbModel";
            this.txtbModel.PlaceholderText = "";
            this.txtbModel.SelectedText = "";
            this.txtbModel.Size = new System.Drawing.Size(200, 26);
            this.txtbModel.TabIndex = 73;
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
            this.txtbYear.Location = new System.Drawing.Point(24, 200);
            this.txtbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.PlaceholderText = "";
            this.txtbYear.SelectedText = "";
            this.txtbYear.Size = new System.Drawing.Size(200, 26);
            this.txtbYear.TabIndex = 72;
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
            this.txtbColor.Location = new System.Drawing.Point(281, 124);
            this.txtbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbColor.Name = "txtbColor";
            this.txtbColor.PlaceholderText = "";
            this.txtbColor.SelectedText = "";
            this.txtbColor.Size = new System.Drawing.Size(200, 26);
            this.txtbColor.TabIndex = 71;
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
            this.txtbPricePerDay.Location = new System.Drawing.Point(281, 200);
            this.txtbPricePerDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPricePerDay.Name = "txtbPricePerDay";
            this.txtbPricePerDay.PlaceholderText = "";
            this.txtbPricePerDay.SelectedText = "";
            this.txtbPricePerDay.Size = new System.Drawing.Size(200, 26);
            this.txtbPricePerDay.TabIndex = 70;
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
            this.txtbPlateNumber.Location = new System.Drawing.Point(24, 276);
            this.txtbPlateNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPlateNumber.Name = "txtbPlateNumber";
            this.txtbPlateNumber.PlaceholderText = "";
            this.txtbPlateNumber.SelectedText = "";
            this.txtbPlateNumber.Size = new System.Drawing.Size(200, 26);
            this.txtbPlateNumber.TabIndex = 69;
            // 
            // lblCarID
            // 
            this.lblCarID.BackColor = System.Drawing.Color.Transparent;
            this.lblCarID.Enabled = false;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.ForeColor = System.Drawing.Color.White;
            this.lblCarID.Location = new System.Drawing.Point(281, 31);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(24, 26);
            this.lblCarID.TabIndex = 68;
            this.lblCarID.Text = "---";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(281, 92);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(53, 26);
            this.guna2HtmlLabel8.TabIndex = 67;
            this.guna2HtmlLabel8.Text = "Color";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(281, 168);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(130, 26);
            this.guna2HtmlLabel6.TabIndex = 66;
            this.guna2HtmlLabel6.Text = "Price Per Day";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 244);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(130, 26);
            this.guna2HtmlLabel5.TabIndex = 65;
            this.guna2HtmlLabel5.Text = "Plate Number";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 168);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(46, 26);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "Year";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 26);
            this.guna2HtmlLabel2.TabIndex = 63;
            this.guna2HtmlLabel2.Text = "Model";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(205, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 26);
            this.guna2HtmlLabel1.TabIndex = 62;
            this.guna2HtmlLabel1.Text = "Car ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbCarImage
            // 
            this.pbCarImage.Location = new System.Drawing.Point(511, 89);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(277, 305);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 77;
            this.pbCarImage.TabStop = false;
            // 
            // frmUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.llblDeleteCarImage);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.llblSetCarImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbModel);
            this.Controls.Add(this.txtbYear);
            this.Controls.Add(this.txtbColor);
            this.Controls.Add(this.txtbPricePerDay);
            this.Controls.Add(this.txtbPlateNumber);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCar";
            this.Text = "Update Car";
            this.Load += new System.EventHandler(this.frmUpstaeCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox cbStatus;
        private System.Windows.Forms.LinkLabel llblDeleteCarImage;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.LinkLabel llblSetCarImage;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtbModel;
        private Guna.UI2.WinForms.Guna2TextBox txtbYear;
        private Guna.UI2.WinForms.Guna2TextBox txtbColor;
        private Guna.UI2.WinForms.Guna2TextBox txtbPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtbPlateNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
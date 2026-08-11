namespace DVLD.Licenses.InternationalLicenses
{
    partial class frmInternationalLicensesList
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
            this.lblNoData = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.lblFiterBy = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cbActivationStatus = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddInternationaLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalLicenseOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(294, 460);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(897, 39);
            this.lblNoData.TabIndex = 40;
            this.lblNoData.Text = "You don\'t have Any International Licenses to show";
            this.lblNoData.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(466, 211);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(630, 40);
            this.lblHeader.TabIndex = 36;
            this.lblHeader.Text = "International License Applications";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(387, 305);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(224, 24);
            this.tbUserFilterationValue.TabIndex = 35;
            this.tbUserFilterationValue.Visible = false;
            this.tbUserFilterationValue.TextChanged += new System.EventHandler(this.tbUserFilterationValue_TextChanged);
            this.tbUserFilterationValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserFilterationValue_KeyPress);
            // 
            // lblFiterBy
            // 
            this.lblFiterBy.AutoSize = true;
            this.lblFiterBy.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.lblFiterBy.Location = new System.Drawing.Point(12, 304);
            this.lblFiterBy.Name = "lblFiterBy";
            this.lblFiterBy.Size = new System.Drawing.Size(95, 21);
            this.lblFiterBy.TabIndex = 34;
            this.lblFiterBy.Text = "Filter By ";
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(131, 304);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(224, 27);
            this.cbFilters.TabIndex = 33;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(12, 690);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 31;
            this.lblRecords.Text = "# Records : 0";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicenseOptions;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(12, 343);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1445, 318);
            this.dgvInternationalLicenses.TabIndex = 30;
            // 
            // cmsInternationalLicenseOptions
            // 
            this.cmsInternationalLicenseOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsInternationalLicenseOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicenseOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowPersonDetails,
            this.opShowLicenseDetails,
            this.opShowPersonLicenseHistory});
            this.cmsInternationalLicenseOptions.Name = "cmsOptions";
            this.cmsInternationalLicenseOptions.Size = new System.Drawing.Size(284, 82);
            // 
            // opShowPersonDetails
            // 
            this.opShowPersonDetails.Image = global::DVLD.Properties.Resources.info2;
            this.opShowPersonDetails.Name = "opShowPersonDetails";
            this.opShowPersonDetails.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonDetails.Text = "Show Person Details";
            this.opShowPersonDetails.Click += new System.EventHandler(this.opShowPersonDetails_Click);
            // 
            // opShowLicenseDetails
            // 
            this.opShowLicenseDetails.Image = global::DVLD.Properties.Resources.License_View_32;
            this.opShowLicenseDetails.Name = "opShowLicenseDetails";
            this.opShowLicenseDetails.Size = new System.Drawing.Size(283, 26);
            this.opShowLicenseDetails.Text = "Show License Details";
            this.opShowLicenseDetails.Click += new System.EventHandler(this.opShowLicenseDetails_Click);
            // 
            // opShowPersonLicenseHistory
            // 
            this.opShowPersonLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.opShowPersonLicenseHistory.Name = "opShowPersonLicenseHistory";
            this.opShowPersonLicenseHistory.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonLicenseHistory.Text = "Show Person License History";
            this.opShowPersonLicenseHistory.Click += new System.EventHandler(this.opShowPersonLicenseHistory_Click);
            // 
            // cbActivationStatus
            // 
            this.cbActivationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbActivationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbActivationStatus.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbActivationStatus.FormattingEnabled = true;
            this.cbActivationStatus.Location = new System.Drawing.Point(387, 304);
            this.cbActivationStatus.Name = "cbActivationStatus";
            this.cbActivationStatus.Size = new System.Drawing.Size(224, 27);
            this.cbActivationStatus.TabIndex = 39;
            this.cbActivationStatus.Visible = false;
            this.cbActivationStatus.SelectedIndexChanged += new System.EventHandler(this.cbActivationStatus_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::DVLD.Properties.Resources.Applications2;
            this.pbImage.Location = new System.Drawing.Point(473, 7);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(623, 208);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 38;
            this.pbImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1323, 680);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInternationaLicense
            // 
            this.btnAddInternationaLicense.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnAddInternationaLicense.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddInternationaLicense.Location = new System.Drawing.Point(1367, 240);
            this.btnAddInternationaLicense.Name = "btnAddInternationaLicense";
            this.btnAddInternationaLicense.Size = new System.Drawing.Size(90, 97);
            this.btnAddInternationaLicense.TabIndex = 37;
            this.btnAddInternationaLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddInternationaLicense.UseVisualStyleBackColor = true;
            this.btnAddInternationaLicense.Click += new System.EventHandler(this.btnAddInternationaLicense_Click);
            // 
            // frmInternationalLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1469, 741);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddInternationaLicense);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Controls.Add(this.cbActivationStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInternationalLicensesList";
            this.Text = "International Licenses List";
            this.Load += new System.EventHandler(this.frmInternationalLicensesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalLicenseOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddInternationaLicense;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.Label lblFiterBy;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseOptions;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonLicenseHistory;
        private System.Windows.Forms.ComboBox cbActivationStatus;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem opShowLicenseDetails;
    }
}
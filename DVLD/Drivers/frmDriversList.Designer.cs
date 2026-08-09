namespace DVLD.Drivers
{
    partial class frmDriversList
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
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.lblFiterBy = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.dgvDriversList = new System.Windows.Forms.DataGridView();
            this.cmsDriverOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opIssueInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManageDrivers = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblNoData = new System.Windows.Forms.Label();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).BeginInit();
            this.cmsDriverOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(437, 251);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(263, 24);
            this.tbUserFilterationValue.TabIndex = 28;
            this.tbUserFilterationValue.Visible = false;
            this.tbUserFilterationValue.TextChanged += new System.EventHandler(this.tbUserFilterationValue_TextChanged);
            this.tbUserFilterationValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserFilterationValue_KeyPress);
            // 
            // lblFiterBy
            // 
            this.lblFiterBy.AutoSize = true;
            this.lblFiterBy.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.lblFiterBy.Location = new System.Drawing.Point(43, 251);
            this.lblFiterBy.Name = "lblFiterBy";
            this.lblFiterBy.Size = new System.Drawing.Size(95, 21);
            this.lblFiterBy.TabIndex = 27;
            this.lblFiterBy.Text = "Filter By ";
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(144, 248);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(263, 27);
            this.cbFilters.TabIndex = 26;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // dgvDriversList
            // 
            this.dgvDriversList.AllowUserToAddRows = false;
            this.dgvDriversList.AllowUserToDeleteRows = false;
            this.dgvDriversList.AllowUserToOrderColumns = true;
            this.dgvDriversList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriversList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriversList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversList.ContextMenuStrip = this.cmsDriverOptions;
            this.dgvDriversList.Location = new System.Drawing.Point(47, 286);
            this.dgvDriversList.Name = "dgvDriversList";
            this.dgvDriversList.ReadOnly = true;
            this.dgvDriversList.RowHeadersWidth = 51;
            this.dgvDriversList.RowTemplate.Height = 24;
            this.dgvDriversList.Size = new System.Drawing.Size(1304, 367);
            this.dgvDriversList.TabIndex = 21;
            // 
            // cmsDriverOptions
            // 
            this.cmsDriverOptions.BackColor = System.Drawing.Color.White;
            this.cmsDriverOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsDriverOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDriverOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowPersonInfo,
            this.toolStripSeparator1,
            this.opIssueInternationalLicense,
            this.opShowPersonLicenseHistory,
            this.toolStripSeparator2,
            this.opSendEmail,
            this.opSendSMS});
            this.cmsDriverOptions.Name = "cmsOptions";
            this.cmsDriverOptions.Size = new System.Drawing.Size(284, 174);
            this.cmsDriverOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDriverOptions_Opening);
            // 
            // opShowPersonInfo
            // 
            this.opShowPersonInfo.Image = global::DVLD.Properties.Resources.info;
            this.opShowPersonInfo.Name = "opShowPersonInfo";
            this.opShowPersonInfo.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonInfo.Text = "Show Person Information";
            this.opShowPersonInfo.Click += new System.EventHandler(this.opShowPersonInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(280, 6);
            // 
            // opIssueInternationalLicense
            // 
            this.opIssueInternationalLicense.Image = global::DVLD.Properties.Resources.International_32;
            this.opIssueInternationalLicense.Name = "opIssueInternationalLicense";
            this.opIssueInternationalLicense.Size = new System.Drawing.Size(283, 26);
            this.opIssueInternationalLicense.Text = "Issue International License";
            this.opIssueInternationalLicense.Click += new System.EventHandler(this.UnImplementedFeatures_Click);
            // 
            // opShowPersonLicenseHistory
            // 
            this.opShowPersonLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.opShowPersonLicenseHistory.Name = "opShowPersonLicenseHistory";
            this.opShowPersonLicenseHistory.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonLicenseHistory.Text = "Show Person License History";
            this.opShowPersonLicenseHistory.Click += new System.EventHandler(this.opShowPersonLicenseHistory_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(280, 6);
            // 
            // opSendEmail
            // 
            this.opSendEmail.Image = global::DVLD.Properties.Resources.send_mail;
            this.opSendEmail.Name = "opSendEmail";
            this.opSendEmail.Size = new System.Drawing.Size(283, 26);
            this.opSendEmail.Text = "Send Email";
            this.opSendEmail.Click += new System.EventHandler(this.UnImplementedFeatures_Click);
            // 
            // opSendSMS
            // 
            this.opSendSMS.Image = global::DVLD.Properties.Resources.call_32;
            this.opSendSMS.Name = "opSendSMS";
            this.opSendSMS.Size = new System.Drawing.Size(283, 26);
            this.opSendSMS.Text = "Send SMS";
            this.opSendSMS.Click += new System.EventHandler(this.UnImplementedFeatures_Click);
            // 
            // lblManageDrivers
            // 
            this.lblManageDrivers.AutoSize = true;
            this.lblManageDrivers.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblManageDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageDrivers.Location = new System.Drawing.Point(590, 179);
            this.lblManageDrivers.Name = "lblManageDrivers";
            this.lblManageDrivers.Size = new System.Drawing.Size(291, 40);
            this.lblManageDrivers.TabIndex = 24;
            this.lblManageDrivers.Text = "Manage Drivers";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(43, 674);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "# Records : 0";
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(451, 479);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(561, 39);
            this.lblNoData.TabIndex = 29;
            this.lblNoData.Text = "You don\'t have Drivers to show";
            this.lblNoData.Visible = false;
            // 
            // pbDrivers
            // 
            this.pbDrivers.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pbDrivers.Location = new System.Drawing.Point(597, 12);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(284, 164);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrivers.TabIndex = 25;
            this.pbDrivers.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1217, 664);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 735);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.dgvDriversList);
            this.Controls.Add(this.pbDrivers);
            this.Controls.Add(this.lblManageDrivers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDriversList";
            this.Text = "Drivers List";
            this.Load += new System.EventHandler(this.frmDriversList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).EndInit();
            this.cmsDriverOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.Label lblFiterBy;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.DataGridView dgvDriversList;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.Label lblManageDrivers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.ContextMenuStrip cmsDriverOptions;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opIssueInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opSendEmail;
        private System.Windows.Forms.ToolStripMenuItem opSendSMS;
    }
}
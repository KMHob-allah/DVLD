namespace DVLD.Applications.LocalApplications
{
    partial class frmLocalAppsList
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
            this.lblLocalLicenseApplications = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.lblFiterBy = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsApplicationOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowAppDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.opDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.opCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLocalAppsList = new System.Windows.Forms.DataGridView();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnNewLocalLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNoData = new System.Windows.Forms.Label();
            this.cmsApplicationOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalAppsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocalLicenseApplications
            // 
            this.lblLocalLicenseApplications.AutoSize = true;
            this.lblLocalLicenseApplications.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblLocalLicenseApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocalLicenseApplications.Location = new System.Drawing.Point(456, 199);
            this.lblLocalLicenseApplications.Name = "lblLocalLicenseApplications";
            this.lblLocalLicenseApplications.Size = new System.Drawing.Size(631, 40);
            this.lblLocalLicenseApplications.TabIndex = 23;
            this.lblLocalLicenseApplications.Text = "Local Driving License Applications";
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(439, 310);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(277, 24);
            this.tbUserFilterationValue.TabIndex = 22;
            this.tbUserFilterationValue.Visible = false;
            this.tbUserFilterationValue.TextChanged += new System.EventHandler(this.tbUserFilterationValue_TextChanged);
            this.tbUserFilterationValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserFilterationValue_KeyPress);
            // 
            // lblFiterBy
            // 
            this.lblFiterBy.AutoSize = true;
            this.lblFiterBy.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.lblFiterBy.Location = new System.Drawing.Point(25, 310);
            this.lblFiterBy.Name = "lblFiterBy";
            this.lblFiterBy.Size = new System.Drawing.Size(95, 21);
            this.lblFiterBy.TabIndex = 21;
            this.lblFiterBy.Text = "Filter By ";
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(144, 310);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(277, 27);
            this.cbFilters.TabIndex = 20;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(25, 772);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 18;
            this.lblRecords.Text = "# Records : 0";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // cmsApplicationOptions
            // 
            this.cmsApplicationOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsApplicationOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplicationOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowAppDetails,
            this.toolStripSeparator1,
            this.opEditApplication,
            this.opDeleteApplication,
            this.toolStripSeparator2,
            this.opCancelApplication,
            this.toolStripSeparator3,
            this.opSchduleTests,
            this.toolStripSeparator6,
            this.opIssueDrivingLicenseFirstTime,
            this.toolStripSeparator4,
            this.opShowLicense,
            this.toolStripSeparator5,
            this.opShowPersonLicenseHistory});
            this.cmsApplicationOptions.Name = "cmsOptions";
            this.cmsApplicationOptions.Size = new System.Drawing.Size(317, 276);
            this.cmsApplicationOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplicationOptions_Opening);
            // 
            // opShowAppDetails
            // 
            this.opShowAppDetails.Image = global::DVLD.Properties.Resources.info;
            this.opShowAppDetails.Name = "opShowAppDetails";
            this.opShowAppDetails.Size = new System.Drawing.Size(316, 26);
            this.opShowAppDetails.Text = "Show Application Details";
            this.opShowAppDetails.Click += new System.EventHandler(this.opShowAppDetails_Click);
            // 
            // opEditApplication
            // 
            this.opEditApplication.Image = global::DVLD.Properties.Resources.edit_32;
            this.opEditApplication.Name = "opEditApplication";
            this.opEditApplication.Size = new System.Drawing.Size(316, 26);
            this.opEditApplication.Text = "Edit Application";
            this.opEditApplication.Click += new System.EventHandler(this.opEditApplication_Click);
            // 
            // opDeleteApplication
            // 
            this.opDeleteApplication.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.opDeleteApplication.Name = "opDeleteApplication";
            this.opDeleteApplication.Size = new System.Drawing.Size(316, 26);
            this.opDeleteApplication.Text = "Delete Application";
            this.opDeleteApplication.Click += new System.EventHandler(this.opDeleteApplication_Click);
            // 
            // opCancelApplication
            // 
            this.opCancelApplication.Image = global::DVLD.Properties.Resources.Delete_32;
            this.opCancelApplication.Name = "opCancelApplication";
            this.opCancelApplication.Size = new System.Drawing.Size(316, 26);
            this.opCancelApplication.Text = "Cancel Application";
            this.opCancelApplication.Click += new System.EventHandler(this.opCancelApplication_Click);
            // 
            // opSchduleTests
            // 
            this.opSchduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opSchduleVisionTest,
            this.opSchduleWrittenTest,
            this.opSchduleStreetTest});
            this.opSchduleTests.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.opSchduleTests.Name = "opSchduleTests";
            this.opSchduleTests.Size = new System.Drawing.Size(316, 26);
            this.opSchduleTests.Text = "Schdule Tests";
            // 
            // opSchduleVisionTest
            // 
            this.opSchduleVisionTest.Image = global::DVLD.Properties.Resources.Vision_Test_32;
            this.opSchduleVisionTest.Name = "opSchduleVisionTest";
            this.opSchduleVisionTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleVisionTest.Text = "Schdule Vision Test";
            this.opSchduleVisionTest.Click += new System.EventHandler(this.opSchduleVisionTest_Click);
            // 
            // opSchduleWrittenTest
            // 
            this.opSchduleWrittenTest.Image = global::DVLD.Properties.Resources.Written_Test_32;
            this.opSchduleWrittenTest.Name = "opSchduleWrittenTest";
            this.opSchduleWrittenTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleWrittenTest.Text = "Schdule Written Test";
            this.opSchduleWrittenTest.Click += new System.EventHandler(this.opSchduleWrittenTest_Click);
            // 
            // opSchduleStreetTest
            // 
            this.opSchduleStreetTest.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.opSchduleStreetTest.Name = "opSchduleStreetTest";
            this.opSchduleStreetTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleStreetTest.Text = "Schdule Street Test";
            this.opSchduleStreetTest.Click += new System.EventHandler(this.opSchduleStreetTest_Click);
            // 
            // opIssueDrivingLicenseFirstTime
            // 
            this.opIssueDrivingLicenseFirstTime.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.opIssueDrivingLicenseFirstTime.Name = "opIssueDrivingLicenseFirstTime";
            this.opIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(316, 26);
            this.opIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.opIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.opIssueDrivingLicenseFirstTime_Click);
            // 
            // opShowLicense
            // 
            this.opShowLicense.Image = global::DVLD.Properties.Resources.License_View_32;
            this.opShowLicense.Name = "opShowLicense";
            this.opShowLicense.Size = new System.Drawing.Size(316, 26);
            this.opShowLicense.Text = "Show License";
            this.opShowLicense.Click += new System.EventHandler(this.opShowLicense_Click);
            // 
            // opShowPersonLicenseHistory
            // 
            this.opShowPersonLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.opShowPersonLicenseHistory.Name = "opShowPersonLicenseHistory";
            this.opShowPersonLicenseHistory.Size = new System.Drawing.Size(316, 26);
            this.opShowPersonLicenseHistory.Text = "Show Person License History";
            this.opShowPersonLicenseHistory.Click += new System.EventHandler(this.opShowPersonLicenseHistory_Click);
            // 
            // dgvLocalAppsList
            // 
            this.dgvLocalAppsList.AllowUserToAddRows = false;
            this.dgvLocalAppsList.AllowUserToDeleteRows = false;
            this.dgvLocalAppsList.AllowUserToOrderColumns = true;
            this.dgvLocalAppsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalAppsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalAppsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocalAppsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalAppsList.ContextMenuStrip = this.cmsApplicationOptions;
            this.dgvLocalAppsList.Location = new System.Drawing.Point(29, 356);
            this.dgvLocalAppsList.Name = "dgvLocalAppsList";
            this.dgvLocalAppsList.ReadOnly = true;
            this.dgvLocalAppsList.RowHeadersWidth = 51;
            this.dgvLocalAppsList.RowTemplate.Height = 24;
            this.dgvLocalAppsList.Size = new System.Drawing.Size(1462, 387);
            this.dgvLocalAppsList.TabIndex = 17;
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.Applications1;
            this.pbPeople.Location = new System.Drawing.Point(634, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(301, 184);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 25;
            this.pbPeople.TabStop = false;
            // 
            // btnNewLocalLicenseApplication
            // 
            this.btnNewLocalLicenseApplication.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnNewLocalLicenseApplication.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.btnNewLocalLicenseApplication.Location = new System.Drawing.Point(1384, 258);
            this.btnNewLocalLicenseApplication.Name = "btnNewLocalLicenseApplication";
            this.btnNewLocalLicenseApplication.Size = new System.Drawing.Size(107, 92);
            this.btnNewLocalLicenseApplication.TabIndex = 24;
            this.btnNewLocalLicenseApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewLocalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnNewLocalLicenseApplication.Click += new System.EventHandler(this.btnNewLocalLicenseApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1357, 762);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(270, 494);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(997, 39);
            this.lblNoData.TabIndex = 26;
            this.lblNoData.Text = "You don\'t have local driving license applications to show";
            this.lblNoData.Visible = false;
            // 
            // frmLocalAppsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 837);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnNewLocalLicenseApplication);
            this.Controls.Add(this.lblLocalLicenseApplications);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvLocalAppsList);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalAppsList";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmLocalAppsList_Load);
            this.cmsApplicationOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalAppsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewLocalLicenseApplication;
        private System.Windows.Forms.Label lblLocalLicenseApplications;
        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.Label lblFiterBy;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem opShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem opIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem opSchduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem opSchduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem opSchduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem opSchduleTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem opCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem opEditApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opShowAppDetails;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationOptions;
        private System.Windows.Forms.DataGridView dgvLocalAppsList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lblNoData;
    }
}
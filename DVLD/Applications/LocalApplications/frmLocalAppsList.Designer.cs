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
            this.opShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.opShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.opIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.opSchduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opSchduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.opCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.opEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opShowAppDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApplicationOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dvgLocalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnNewLocalLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsApplicationOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLocalLicenseApplications)).BeginInit();
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
            this.tbUserFilterationValue.Location = new System.Drawing.Point(400, 310);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(224, 24);
            this.tbUserFilterationValue.TabIndex = 22;
            this.tbUserFilterationValue.Visible = false;
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
            this.cbFilters.Size = new System.Drawing.Size(224, 27);
            this.cbFilters.TabIndex = 20;
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
            // opShowPersonLicenseHistory
            // 
            this.opShowPersonLicenseHistory.Name = "opShowPersonLicenseHistory";
            this.opShowPersonLicenseHistory.Size = new System.Drawing.Size(312, 24);
            this.opShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(309, 6);
            // 
            // opShowLicense
            // 
            this.opShowLicense.Name = "opShowLicense";
            this.opShowLicense.Size = new System.Drawing.Size(312, 24);
            this.opShowLicense.Text = "Show License";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(309, 6);
            // 
            // opIssueDrivingLicenseFirstTime
            // 
            this.opIssueDrivingLicenseFirstTime.Name = "opIssueDrivingLicenseFirstTime";
            this.opIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(312, 24);
            this.opIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(309, 6);
            // 
            // opSchduleStreetTest
            // 
            this.opSchduleStreetTest.Name = "opSchduleStreetTest";
            this.opSchduleStreetTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleStreetTest.Text = "Schdule Street Test";
            // 
            // opSchduleWrittenTest
            // 
            this.opSchduleWrittenTest.Name = "opSchduleWrittenTest";
            this.opSchduleWrittenTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleWrittenTest.Text = "Schdule Written Test";
            // 
            // opSchduleVisionTest
            // 
            this.opSchduleVisionTest.Name = "opSchduleVisionTest";
            this.opSchduleVisionTest.Size = new System.Drawing.Size(239, 26);
            this.opSchduleVisionTest.Text = "Schdule Vision Test";
            // 
            // opSchduleTests
            // 
            this.opSchduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opSchduleVisionTest,
            this.opSchduleWrittenTest,
            this.opSchduleStreetTest});
            this.opSchduleTests.Name = "opSchduleTests";
            this.opSchduleTests.Size = new System.Drawing.Size(312, 24);
            this.opSchduleTests.Text = "Schdule Tests";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(309, 6);
            // 
            // opCancelApplication
            // 
            this.opCancelApplication.Name = "opCancelApplication";
            this.opCancelApplication.Size = new System.Drawing.Size(312, 24);
            this.opCancelApplication.Text = "Cancel Application";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(309, 6);
            // 
            // opDeleteApplication
            // 
            this.opDeleteApplication.Name = "opDeleteApplication";
            this.opDeleteApplication.Size = new System.Drawing.Size(312, 24);
            this.opDeleteApplication.Text = "Delete Application";
            // 
            // opEditApplication
            // 
            this.opEditApplication.Name = "opEditApplication";
            this.opEditApplication.Size = new System.Drawing.Size(312, 24);
            this.opEditApplication.Text = "Edit Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(309, 6);
            // 
            // opShowAppDetails
            // 
            this.opShowAppDetails.Name = "opShowAppDetails";
            this.opShowAppDetails.Size = new System.Drawing.Size(312, 24);
            this.opShowAppDetails.Text = "Show Application Details";
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
            this.cmsApplicationOptions.Size = new System.Drawing.Size(313, 232);
            // 
            // dvgLocalLicenseApplications
            // 
            this.dvgLocalLicenseApplications.AllowUserToAddRows = false;
            this.dvgLocalLicenseApplications.AllowUserToDeleteRows = false;
            this.dvgLocalLicenseApplications.AllowUserToOrderColumns = true;
            this.dvgLocalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLocalLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dvgLocalLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgLocalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLocalLicenseApplications.ContextMenuStrip = this.cmsApplicationOptions;
            this.dvgLocalLicenseApplications.Location = new System.Drawing.Point(29, 356);
            this.dvgLocalLicenseApplications.Name = "dvgLocalLicenseApplications";
            this.dvgLocalLicenseApplications.ReadOnly = true;
            this.dvgLocalLicenseApplications.RowHeadersWidth = 51;
            this.dvgLocalLicenseApplications.RowTemplate.Height = 24;
            this.dvgLocalLicenseApplications.Size = new System.Drawing.Size(1413, 387);
            this.dvgLocalLicenseApplications.TabIndex = 17;
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
            this.btnNewLocalLicenseApplication.Location = new System.Drawing.Point(1348, 265);
            this.btnNewLocalLicenseApplication.Name = "btnNewLocalLicenseApplication";
            this.btnNewLocalLicenseApplication.Size = new System.Drawing.Size(94, 81);
            this.btnNewLocalLicenseApplication.TabIndex = 24;
            this.btnNewLocalLicenseApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewLocalLicenseApplication.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1308, 762);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmLocalAppsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 837);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnNewLocalLicenseApplication);
            this.Controls.Add(this.lblLocalLicenseApplications);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dvgLocalLicenseApplications);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalAppsList";
            this.Text = "frmLocalAppsList";
            this.cmsApplicationOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLocalLicenseApplications)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgLocalLicenseApplications;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbPeople;
    }
}
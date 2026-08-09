namespace DVLD.Applications.LostOrDamagedLicenseApplications
{
    partial class frmLostOrDamagedLicenseApplications
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
            this.ctrlLicenseCardWithFilter1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbAppInfoForLicenseReplacement = new System.Windows.Forms.GroupBox();
            this.lblCreatedByUserNameValue = new System.Windows.Forms.Label();
            this.lblCreatedByUserName = new System.Windows.Forms.Label();
            this.lblReplacedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblRplacedLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblRenewicenseAppIDValue = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRenewicenseAppID = new System.Windows.Forms.Label();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnklblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbReplacementOptions = new System.Windows.Forms.GroupBox();
            this.rdbtnLostLicense = new System.Windows.Forms.RadioButton();
            this.rdbtnDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gbAppInfoForLicenseReplacement.SuspendLayout();
            this.gbReplacementOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(63, 82);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1232, 427);
            this.ctrlLicenseCardWithFilter1.TabIndex = 0;
            this.ctrlLicenseCardWithFilter1.LicenseSelected += new System.Action<int>(this.ctrlLicenseCardWithFilter1_LicenseSelected);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(400, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(613, 39);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Replacement For Damaged License";
            // 
            // gbAppInfoForLicenseReplacement
            // 
            this.gbAppInfoForLicenseReplacement.BackColor = System.Drawing.Color.White;
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblCreatedByUserNameValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblCreatedByUserName);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblReplacedLicenseIDValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblOldLicenseIDValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblRplacedLicenseID);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblOldLicenseID);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblAppDateValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblAppFeesValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblRenewicenseAppIDValue);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblAppDate);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblAppFees);
            this.gbAppInfoForLicenseReplacement.Controls.Add(this.lblRenewicenseAppID);
            this.gbAppInfoForLicenseReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAppInfoForLicenseReplacement.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbAppInfoForLicenseReplacement.Location = new System.Drawing.Point(70, 516);
            this.gbAppInfoForLicenseReplacement.Name = "gbAppInfoForLicenseReplacement";
            this.gbAppInfoForLicenseReplacement.Size = new System.Drawing.Size(1218, 177);
            this.gbAppInfoForLicenseReplacement.TabIndex = 31;
            this.gbAppInfoForLicenseReplacement.TabStop = false;
            this.gbAppInfoForLicenseReplacement.Text = "Application Info For License Replacement";
            // 
            // lblCreatedByUserNameValue
            // 
            this.lblCreatedByUserNameValue.AutoSize = true;
            this.lblCreatedByUserNameValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblCreatedByUserNameValue.Location = new System.Drawing.Point(826, 129);
            this.lblCreatedByUserNameValue.Name = "lblCreatedByUserNameValue";
            this.lblCreatedByUserNameValue.Size = new System.Drawing.Size(37, 21);
            this.lblCreatedByUserNameValue.TabIndex = 28;
            this.lblCreatedByUserNameValue.Text = "???";
            // 
            // lblCreatedByUserName
            // 
            this.lblCreatedByUserName.AutoSize = true;
            this.lblCreatedByUserName.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByUserName.Location = new System.Drawing.Point(618, 129);
            this.lblCreatedByUserName.Name = "lblCreatedByUserName";
            this.lblCreatedByUserName.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByUserName.TabIndex = 27;
            this.lblCreatedByUserName.Text = "Created By";
            // 
            // lblReplacedLicenseIDValue
            // 
            this.lblReplacedLicenseIDValue.AutoSize = true;
            this.lblReplacedLicenseIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblReplacedLicenseIDValue.Location = new System.Drawing.Point(826, 44);
            this.lblReplacedLicenseIDValue.Name = "lblReplacedLicenseIDValue";
            this.lblReplacedLicenseIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblReplacedLicenseIDValue.TabIndex = 21;
            this.lblReplacedLicenseIDValue.Text = "???";
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(826, 82);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblOldLicenseIDValue.TabIndex = 20;
            this.lblOldLicenseIDValue.Text = "???";
            // 
            // lblRplacedLicenseID
            // 
            this.lblRplacedLicenseID.AutoSize = true;
            this.lblRplacedLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblRplacedLicenseID.Location = new System.Drawing.Point(618, 43);
            this.lblRplacedLicenseID.Name = "lblRplacedLicenseID";
            this.lblRplacedLicenseID.Size = new System.Drawing.Size(189, 20);
            this.lblRplacedLicenseID.TabIndex = 18;
            this.lblRplacedLicenseID.Text = "Replaced License ID";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblOldLicenseID.Location = new System.Drawing.Point(618, 82);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(139, 20);
            this.lblOldLicenseID.TabIndex = 17;
            this.lblOldLicenseID.Text = "Old License ID";
            // 
            // lblAppDateValue
            // 
            this.lblAppDateValue.AutoSize = true;
            this.lblAppDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppDateValue.Location = new System.Drawing.Point(333, 81);
            this.lblAppDateValue.Name = "lblAppDateValue";
            this.lblAppDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblAppDateValue.TabIndex = 15;
            this.lblAppDateValue.Text = "???";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppFeesValue.Location = new System.Drawing.Point(333, 128);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblAppFeesValue.TabIndex = 12;
            this.lblAppFeesValue.Text = "???";
            // 
            // lblRenewicenseAppIDValue
            // 
            this.lblRenewicenseAppIDValue.AutoSize = true;
            this.lblRenewicenseAppIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblRenewicenseAppIDValue.Location = new System.Drawing.Point(333, 43);
            this.lblRenewicenseAppIDValue.Name = "lblRenewicenseAppIDValue";
            this.lblRenewicenseAppIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblRenewicenseAppIDValue.TabIndex = 9;
            this.lblRenewicenseAppIDValue.Text = "???";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.Location = new System.Drawing.Point(32, 81);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(157, 20);
            this.lblAppDate.TabIndex = 8;
            this.lblAppDate.Text = "Application Date";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(32, 128);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(157, 20);
            this.lblAppFees.TabIndex = 5;
            this.lblAppFees.Text = "Application Fees";
            // 
            // lblRenewicenseAppID
            // 
            this.lblRenewicenseAppID.AutoSize = true;
            this.lblRenewicenseAppID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewicenseAppID.Location = new System.Drawing.Point(32, 45);
            this.lblRenewicenseAppID.Name = "lblRenewicenseAppID";
            this.lblRenewicenseAppID.Size = new System.Drawing.Size(273, 20);
            this.lblRenewicenseAppID.TabIndex = 0;
            this.lblRenewicenseAppID.Text = "Renew License Application ID";
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnIssueReplacement.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.Location = new System.Drawing.Point(1019, 709);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(269, 45);
            this.btnIssueReplacement.TabIndex = 33;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(857, 709);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnklblShowLicensesHistory
            // 
            this.lnklblShowLicensesHistory.AutoSize = true;
            this.lnklblShowLicensesHistory.Enabled = false;
            this.lnklblShowLicensesHistory.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowLicensesHistory.Location = new System.Drawing.Point(66, 721);
            this.lnklblShowLicensesHistory.Name = "lnklblShowLicensesHistory";
            this.lnklblShowLicensesHistory.Size = new System.Drawing.Size(198, 21);
            this.lnklblShowLicensesHistory.TabIndex = 35;
            this.lnklblShowLicensesHistory.TabStop = true;
            this.lnklblShowLicensesHistory.Text = "Show Licenses History";
            this.lnklblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicensesHistory_LinkClicked);
            // 
            // lnklblShowNewLicenseInfo
            // 
            this.lnklblShowNewLicenseInfo.AutoSize = true;
            this.lnklblShowNewLicenseInfo.Enabled = false;
            this.lnklblShowNewLicenseInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowNewLicenseInfo.Location = new System.Drawing.Point(329, 721);
            this.lnklblShowNewLicenseInfo.Name = "lnklblShowNewLicenseInfo";
            this.lnklblShowNewLicenseInfo.Size = new System.Drawing.Size(202, 21);
            this.lnklblShowNewLicenseInfo.TabIndex = 34;
            this.lnklblShowNewLicenseInfo.TabStop = true;
            this.lnklblShowNewLicenseInfo.Text = "Show New License Info";
            this.lnklblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowNewLicenseInfo_LinkClicked);
            // 
            // gbReplacementOptions
            // 
            this.gbReplacementOptions.BackColor = System.Drawing.Color.White;
            this.gbReplacementOptions.Controls.Add(this.rdbtnLostLicense);
            this.gbReplacementOptions.Controls.Add(this.rdbtnDamagedLicense);
            this.gbReplacementOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbReplacementOptions.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbReplacementOptions.Location = new System.Drawing.Point(692, 85);
            this.gbReplacementOptions.Name = "gbReplacementOptions";
            this.gbReplacementOptions.Size = new System.Drawing.Size(596, 86);
            this.gbReplacementOptions.TabIndex = 32;
            this.gbReplacementOptions.TabStop = false;
            this.gbReplacementOptions.Text = "Replacement For";
            // 
            // rdbtnLostLicense
            // 
            this.rdbtnLostLicense.AutoSize = true;
            this.rdbtnLostLicense.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnLostLicense.Location = new System.Drawing.Point(345, 39);
            this.rdbtnLostLicense.Name = "rdbtnLostLicense";
            this.rdbtnLostLicense.Size = new System.Drawing.Size(141, 24);
            this.rdbtnLostLicense.TabIndex = 10;
            this.rdbtnLostLicense.TabStop = true;
            this.rdbtnLostLicense.Text = "Lost License";
            this.rdbtnLostLicense.UseVisualStyleBackColor = true;
            this.rdbtnLostLicense.CheckedChanged += new System.EventHandler(this.rdbtnLostLicense_CheckedChanged);
            // 
            // rdbtnDamagedLicense
            // 
            this.rdbtnDamagedLicense.AutoSize = true;
            this.rdbtnDamagedLicense.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnDamagedLicense.Location = new System.Drawing.Point(74, 39);
            this.rdbtnDamagedLicense.Name = "rdbtnDamagedLicense";
            this.rdbtnDamagedLicense.Size = new System.Drawing.Size(184, 24);
            this.rdbtnDamagedLicense.TabIndex = 9;
            this.rdbtnDamagedLicense.TabStop = true;
            this.rdbtnDamagedLicense.Text = "Damaged License";
            this.rdbtnDamagedLicense.UseVisualStyleBackColor = true;
            this.rdbtnDamagedLicense.CheckedChanged += new System.EventHandler(this.rdbtnDamagedLicense_CheckedChanged);
            // 
            // frmLostOrDamagedLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 775);
            this.Controls.Add(this.gbReplacementOptions);
            this.Controls.Add(this.lnklblShowLicensesHistory);
            this.Controls.Add(this.lnklblShowNewLicenseInfo);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAppInfoForLicenseReplacement);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLostOrDamagedLicenseApplications";
            this.Text = "Replacement For Damaged License";
            this.Load += new System.EventHandler(this.frmLostOrDamagedLicenseApplications_Load);
            this.gbAppInfoForLicenseReplacement.ResumeLayout(false);
            this.gbAppInfoForLicenseReplacement.PerformLayout();
            this.gbReplacementOptions.ResumeLayout(false);
            this.gbReplacementOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbAppInfoForLicenseReplacement;
        private System.Windows.Forms.Label lblAppDateValue;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnklblShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lnklblShowNewLicenseInfo;
        private System.Windows.Forms.Label lblCreatedByUserNameValue;
        private System.Windows.Forms.Label lblCreatedByUserName;
        private System.Windows.Forms.Label lblReplacedLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblRplacedLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblRenewicenseAppIDValue;
        private System.Windows.Forms.Label lblRenewicenseAppID;
        private System.Windows.Forms.GroupBox gbReplacementOptions;
        private System.Windows.Forms.RadioButton rdbtnLostLicense;
        private System.Windows.Forms.RadioButton rdbtnDamagedLicense;
    }
}
namespace DVLD.Licenses.RenewLicenses
{
    partial class frmRenewLocalLicense
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
            this.lblRenewLicense = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.lnklblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnklblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lblRenewedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblExpirationDateValue = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblLicenseFeesValue = new System.Windows.Forms.Label();
            this.lblIssueDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblRenewicenseAppIDValue = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRenewicenseAppID = new System.Windows.Forms.Label();
            this.gbNewLicenseInfoApp = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblCreatedByUserNameValue = new System.Windows.Forms.Label();
            this.lblCreatedByUserName = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ctrlLicenseCardWithFilter1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter();
            this.gbNewLicenseInfoApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRenewLicense
            // 
            this.lblRenewLicense.AutoSize = true;
            this.lblRenewLicense.BackColor = System.Drawing.Color.White;
            this.lblRenewLicense.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblRenewLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRenewLicense.Location = new System.Drawing.Point(458, 31);
            this.lblRenewLicense.Name = "lblRenewLicense";
            this.lblRenewLicense.Size = new System.Drawing.Size(487, 39);
            this.lblRenewLicense.TabIndex = 5;
            this.lblRenewLicense.Text = "Renew License Application";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(974, 848);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnRenew.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(1127, 848);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(134, 45);
            this.btnRenew.TabIndex = 27;
            this.btnRenew.Text = "Renew";
            this.btnRenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // lnklblShowNewLicenseInfo
            // 
            this.lnklblShowNewLicenseInfo.AutoSize = true;
            this.lnklblShowNewLicenseInfo.Enabled = false;
            this.lnklblShowNewLicenseInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowNewLicenseInfo.Location = new System.Drawing.Point(306, 860);
            this.lnklblShowNewLicenseInfo.Name = "lnklblShowNewLicenseInfo";
            this.lnklblShowNewLicenseInfo.Size = new System.Drawing.Size(202, 21);
            this.lnklblShowNewLicenseInfo.TabIndex = 28;
            this.lnklblShowNewLicenseInfo.TabStop = true;
            this.lnklblShowNewLicenseInfo.Text = "Show New License Info";
            this.lnklblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowNewLicenseInfo_LinkClicked);
            // 
            // lnklblShowLicensesHistory
            // 
            this.lnklblShowLicensesHistory.AutoSize = true;
            this.lnklblShowLicensesHistory.Enabled = false;
            this.lnklblShowLicensesHistory.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowLicensesHistory.Location = new System.Drawing.Point(39, 860);
            this.lnklblShowLicensesHistory.Name = "lnklblShowLicensesHistory";
            this.lnklblShowLicensesHistory.Size = new System.Drawing.Size(198, 21);
            this.lnklblShowLicensesHistory.TabIndex = 29;
            this.lnklblShowLicensesHistory.TabStop = true;
            this.lnklblShowLicensesHistory.Text = "Show Licenses History";
            this.lnklblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicensesHistory_LinkClicked);
            // 
            // lblRenewedLicenseIDValue
            // 
            this.lblRenewedLicenseIDValue.AutoSize = true;
            this.lblRenewedLicenseIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblRenewedLicenseIDValue.Location = new System.Drawing.Point(826, 44);
            this.lblRenewedLicenseIDValue.Name = "lblRenewedLicenseIDValue";
            this.lblRenewedLicenseIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblRenewedLicenseIDValue.TabIndex = 21;
            this.lblRenewedLicenseIDValue.Text = "???";
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
            // lblExpirationDateValue
            // 
            this.lblExpirationDateValue.AutoSize = true;
            this.lblExpirationDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblExpirationDateValue.Location = new System.Drawing.Point(826, 117);
            this.lblExpirationDateValue.Name = "lblExpirationDateValue";
            this.lblExpirationDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblExpirationDateValue.TabIndex = 19;
            this.lblExpirationDateValue.Text = "???";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(618, 43);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(187, 20);
            this.lblRenewedLicenseID.TabIndex = 18;
            this.lblRenewedLicenseID.Text = "Renewed License ID";
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
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpirationDate.Location = new System.Drawing.Point(618, 117);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(148, 20);
            this.lblExpirationDate.TabIndex = 16;
            this.lblExpirationDate.Text = "Expiration Date";
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
            // lblLicenseFeesValue
            // 
            this.lblLicenseFeesValue.AutoSize = true;
            this.lblLicenseFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblLicenseFeesValue.Location = new System.Drawing.Point(333, 189);
            this.lblLicenseFeesValue.Name = "lblLicenseFeesValue";
            this.lblLicenseFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblLicenseFeesValue.TabIndex = 14;
            this.lblLicenseFeesValue.Text = "???";
            // 
            // lblIssueDateValue
            // 
            this.lblIssueDateValue.AutoSize = true;
            this.lblIssueDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblIssueDateValue.Location = new System.Drawing.Point(333, 116);
            this.lblIssueDateValue.Name = "lblIssueDateValue";
            this.lblIssueDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblIssueDateValue.TabIndex = 13;
            this.lblIssueDateValue.Text = "???";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppFeesValue.Location = new System.Drawing.Point(333, 153);
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
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseFees.Location = new System.Drawing.Point(32, 189);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(123, 20);
            this.lblLicenseFees.TabIndex = 7;
            this.lblLicenseFees.Text = "License Fees";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.Location = new System.Drawing.Point(32, 117);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(102, 20);
            this.lblIssueDate.TabIndex = 6;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(32, 153);
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
            // gbNewLicenseInfoApp
            // 
            this.gbNewLicenseInfoApp.BackColor = System.Drawing.Color.White;
            this.gbNewLicenseInfoApp.Controls.Add(this.tbNotes);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblCreatedByUserNameValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblCreatedByUserName);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblTotalFeesValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblTotalFees);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblNotes);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblRenewedLicenseIDValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblOldLicenseIDValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblExpirationDateValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblRenewedLicenseID);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblOldLicenseID);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblExpirationDate);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblAppDateValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblLicenseFeesValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblIssueDateValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblAppFeesValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblRenewicenseAppIDValue);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblAppDate);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblLicenseFees);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblIssueDate);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblAppFees);
            this.gbNewLicenseInfoApp.Controls.Add(this.lblRenewicenseAppID);
            this.gbNewLicenseInfoApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNewLicenseInfoApp.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbNewLicenseInfoApp.Location = new System.Drawing.Point(51, 511);
            this.gbNewLicenseInfoApp.Name = "gbNewLicenseInfoApp";
            this.gbNewLicenseInfoApp.Size = new System.Drawing.Size(1218, 326);
            this.gbNewLicenseInfoApp.TabIndex = 30;
            this.gbNewLicenseInfoApp.TabStop = false;
            this.gbNewLicenseInfoApp.Text = "New License Info Application";
            // 
            // tbNotes
            // 
            this.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotes.Location = new System.Drawing.Point(319, 225);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(557, 88);
            this.tbNotes.TabIndex = 29;
            // 
            // lblCreatedByUserNameValue
            // 
            this.lblCreatedByUserNameValue.AutoSize = true;
            this.lblCreatedByUserNameValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblCreatedByUserNameValue.Location = new System.Drawing.Point(833, 153);
            this.lblCreatedByUserNameValue.Name = "lblCreatedByUserNameValue";
            this.lblCreatedByUserNameValue.Size = new System.Drawing.Size(37, 21);
            this.lblCreatedByUserNameValue.TabIndex = 28;
            this.lblCreatedByUserNameValue.Text = "???";
            // 
            // lblCreatedByUserName
            // 
            this.lblCreatedByUserName.AutoSize = true;
            this.lblCreatedByUserName.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByUserName.Location = new System.Drawing.Point(625, 153);
            this.lblCreatedByUserName.Name = "lblCreatedByUserName";
            this.lblCreatedByUserName.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedByUserName.TabIndex = 27;
            this.lblCreatedByUserName.Text = "Created By";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblTotalFeesValue.Location = new System.Drawing.Point(833, 188);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblTotalFeesValue.TabIndex = 26;
            this.lblTotalFeesValue.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(625, 189);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(102, 20);
            this.lblTotalFees.TabIndex = 25;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(32, 225);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 20);
            this.lblNotes.TabIndex = 24;
            this.lblNotes.Text = "Notes";
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(43, 75);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1232, 425);
            this.ctrlLicenseCardWithFilter1.TabIndex = 31;
            this.ctrlLicenseCardWithFilter1.LicenseSelected += new System.Action<int>(this.ctrlLicenseCardWithFilter1_LicenseSelected);
            // 
            // frmRenewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 922);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.Controls.Add(this.gbNewLicenseInfoApp);
            this.Controls.Add(this.lnklblShowLicensesHistory);
            this.Controls.Add(this.lnklblShowNewLicenseInfo);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRenewLicense);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLocalLicense";
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalLicense_Load);
            this.gbNewLicenseInfoApp.ResumeLayout(false);
            this.gbNewLicenseInfoApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRenewLicense;
        //private RenewLocalLicenses.ctrlRenewLocalLicenseCard ctrlRenewLocalLicenseCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.LinkLabel lnklblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel lnklblShowLicensesHistory;
        private System.Windows.Forms.Label lblRenewedLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblExpirationDateValue;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblAppDateValue;
        private System.Windows.Forms.Label lblLicenseFeesValue;
        private System.Windows.Forms.Label lblIssueDateValue;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblRenewicenseAppIDValue;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblRenewicenseAppID;
        private System.Windows.Forms.GroupBox gbNewLicenseInfoApp;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lblCreatedByUserNameValue;
        private System.Windows.Forms.Label lblCreatedByUserName;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private LocalLicenses.Controls.ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
    }
}
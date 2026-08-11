namespace DVLD.Applications.ReleaseLicenses
{
    partial class frmReleaseLicense
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
            this.errpFeesHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblCreatedByUserName = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDateValue = new System.Windows.Forms.Label();
            this.lnklblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDetainIDValue = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.lblAppIDValue = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblFineFeesValue = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.ctrlLicenseCardWithFilter1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errpFeesHandler)).BeginInit();
            this.gbDetainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errpFeesHandler
            // 
            this.errpFeesHandler.ContainerControl = this;
            // 
            // lblLicenseIDValue
            // 
            this.lblLicenseIDValue.AutoSize = true;
            this.lblLicenseIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblLicenseIDValue.Location = new System.Drawing.Point(785, 44);
            this.lblLicenseIDValue.Name = "lblLicenseIDValue";
            this.lblLicenseIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblLicenseIDValue.TabIndex = 21;
            this.lblLicenseIDValue.Text = "???";
            // 
            // lblCreatedByUserName
            // 
            this.lblCreatedByUserName.AutoSize = true;
            this.lblCreatedByUserName.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblCreatedByUserName.Location = new System.Drawing.Point(785, 82);
            this.lblCreatedByUserName.Name = "lblCreatedByUserName";
            this.lblCreatedByUserName.Size = new System.Drawing.Size(37, 21);
            this.lblCreatedByUserName.TabIndex = 20;
            this.lblCreatedByUserName.Text = "???";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.Location = new System.Drawing.Point(618, 43);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(102, 20);
            this.lblLicenseID.TabIndex = 18;
            this.lblLicenseID.Text = "License ID";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(618, 81);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedBy.TabIndex = 17;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblDetainDateValue
            // 
            this.lblDetainDateValue.AutoSize = true;
            this.lblDetainDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblDetainDateValue.Location = new System.Drawing.Point(184, 82);
            this.lblDetainDateValue.Name = "lblDetainDateValue";
            this.lblDetainDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblDetainDateValue.TabIndex = 15;
            this.lblDetainDateValue.Text = "???";
            // 
            // lnklblShowLicensesHistory
            // 
            this.lnklblShowLicensesHistory.AutoSize = true;
            this.lnklblShowLicensesHistory.Enabled = false;
            this.lnklblShowLicensesHistory.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowLicensesHistory.Location = new System.Drawing.Point(73, 713);
            this.lnklblShowLicensesHistory.Name = "lnklblShowLicensesHistory";
            this.lnklblShowLicensesHistory.Size = new System.Drawing.Size(198, 21);
            this.lnklblShowLicensesHistory.TabIndex = 43;
            this.lnklblShowLicensesHistory.TabStop = true;
            this.lnklblShowLicensesHistory.Text = "Show Licenses History";
            this.lnklblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicensesHistory_LinkClicked);
            // 
            // lnklblLicenseInfo
            // 
            this.lnklblLicenseInfo.AutoSize = true;
            this.lnklblLicenseInfo.Enabled = false;
            this.lnklblLicenseInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblLicenseInfo.Location = new System.Drawing.Point(330, 713);
            this.lnklblLicenseInfo.Name = "lnklblLicenseInfo";
            this.lnklblLicenseInfo.Size = new System.Drawing.Size(161, 21);
            this.lnklblLicenseInfo.TabIndex = 42;
            this.lnklblLicenseInfo.TabStop = true;
            this.lnklblLicenseInfo.Text = "Show License Info";
            this.lnklblLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLicenseInfo_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(513, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 39);
            this.lblHeader.TabIndex = 38;
            this.lblHeader.Text = "Release Detain License";
            // 
            // lblDetainIDValue
            // 
            this.lblDetainIDValue.AutoSize = true;
            this.lblDetainIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblDetainIDValue.Location = new System.Drawing.Point(184, 45);
            this.lblDetainIDValue.Name = "lblDetainIDValue";
            this.lblDetainIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblDetainIDValue.TabIndex = 9;
            this.lblDetainIDValue.Text = "???";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetainDate.Location = new System.Drawing.Point(32, 82);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(114, 20);
            this.lblDetainDate.TabIndex = 8;
            this.lblDetainDate.Text = "Detain Date";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblFineFees.Location = new System.Drawing.Point(32, 119);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(95, 20);
            this.lblFineFees.TabIndex = 6;
            this.lblFineFees.Text = "Fine Fees";
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.BackColor = System.Drawing.Color.White;
            this.gbDetainInfo.Controls.Add(this.lblAppIDValue);
            this.gbDetainInfo.Controls.Add(this.lblApplicationID);
            this.gbDetainInfo.Controls.Add(this.lblTotalFeesValue);
            this.gbDetainInfo.Controls.Add(this.lblTotalFees);
            this.gbDetainInfo.Controls.Add(this.lblAppFeesValue);
            this.gbDetainInfo.Controls.Add(this.lblApplicationFees);
            this.gbDetainInfo.Controls.Add(this.lblFineFeesValue);
            this.gbDetainInfo.Controls.Add(this.lblLicenseIDValue);
            this.gbDetainInfo.Controls.Add(this.lblCreatedByUserName);
            this.gbDetainInfo.Controls.Add(this.lblLicenseID);
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Controls.Add(this.lblDetainDateValue);
            this.gbDetainInfo.Controls.Add(this.lblDetainIDValue);
            this.gbDetainInfo.Controls.Add(this.lblDetainDate);
            this.gbDetainInfo.Controls.Add(this.lblFineFees);
            this.gbDetainInfo.Controls.Add(this.lblDetainID);
            this.gbDetainInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetainInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbDetainInfo.Location = new System.Drawing.Point(77, 485);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(1218, 206);
            this.gbDetainInfo.TabIndex = 39;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // lblAppIDValue
            // 
            this.lblAppIDValue.AutoSize = true;
            this.lblAppIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppIDValue.Location = new System.Drawing.Point(785, 158);
            this.lblAppIDValue.Name = "lblAppIDValue";
            this.lblAppIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblAppIDValue.TabIndex = 28;
            this.lblAppIDValue.Text = "???";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationID.Location = new System.Drawing.Point(618, 157);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(136, 20);
            this.lblApplicationID.TabIndex = 27;
            this.lblApplicationID.Text = "Application ID";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblTotalFeesValue.Location = new System.Drawing.Point(184, 156);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblTotalFeesValue.TabIndex = 26;
            this.lblTotalFeesValue.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(32, 156);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(102, 20);
            this.lblTotalFees.TabIndex = 25;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppFeesValue.Location = new System.Drawing.Point(785, 120);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblAppFeesValue.TabIndex = 24;
            this.lblAppFeesValue.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.Location = new System.Drawing.Point(618, 119);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(157, 20);
            this.lblApplicationFees.TabIndex = 23;
            this.lblApplicationFees.Text = "Application Fees";
            // 
            // lblFineFeesValue
            // 
            this.lblFineFeesValue.AutoSize = true;
            this.lblFineFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblFineFeesValue.Location = new System.Drawing.Point(184, 119);
            this.lblFineFeesValue.Name = "lblFineFeesValue";
            this.lblFineFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblFineFeesValue.TabIndex = 22;
            this.lblFineFeesValue.Text = "???";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetainID.Location = new System.Drawing.Point(32, 45);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(93, 20);
            this.lblDetainID.TabIndex = 0;
            this.lblDetainID.Text = "Detain ID";
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(77, 53);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1232, 427);
            this.ctrlLicenseCardWithFilter1.TabIndex = 37;
            this.ctrlLicenseCardWithFilter1.LicenseSelected += new System.Action<int>(this.ctrlLicenseCardWithFilter1_LicenseSelected);
            // 
            // btnRelease
            // 
            this.btnRelease.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnRelease.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(1127, 701);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(162, 45);
            this.btnRelease.TabIndex = 41;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(971, 701);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1369, 765);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.lnklblShowLicensesHistory);
            this.Controls.Add(this.lnklblLicenseInfo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReleaseLicense";
            this.Text = "Release Detained License";
            this.Load += new System.EventHandler(this.frmReleaseLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpFeesHandler)).EndInit();
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errpFeesHandler;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.LinkLabel lnklblShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lnklblLicenseInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblCreatedByUserName;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDateValue;
        private System.Windows.Forms.Label lblDetainIDValue;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblDetainID;
        private Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
        private System.Windows.Forms.Label lblAppIDValue;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblFineFeesValue;
    }
}
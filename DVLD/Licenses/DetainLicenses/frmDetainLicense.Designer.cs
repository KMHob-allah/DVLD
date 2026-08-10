namespace DVLD.Licenses.DetainLicenses
{
    partial class frmDetainLicense
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
            this.ctrlLicenseCardWithFilter1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblCreatedByUserName = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDateValue = new System.Windows.Forms.Label();
            this.lblDetainIDValue = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnklblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errpFeesHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpFeesHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(49, 84);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1232, 427);
            this.ctrlLicenseCardWithFilter1.TabIndex = 0;
            this.ctrlLicenseCardWithFilter1.LicenseSelected += new System.Action<int>(this.ctrlLicenseCardWithFilter1_LicenseSelected);
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.BackColor = System.Drawing.Color.White;
            this.gbDetainInfo.Controls.Add(this.tbFineFees);
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
            this.gbDetainInfo.Location = new System.Drawing.Point(58, 517);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(1218, 164);
            this.gbDetainInfo.TabIndex = 32;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFineFees.Location = new System.Drawing.Point(184, 116);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(116, 27);
            this.tbFineFees.TabIndex = 29;
            this.tbFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFineFees_KeyPress);
            this.tbFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbFineFees_Validating);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(618, 82);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedBy.TabIndex = 17;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblDetainDateValue
            // 
            this.lblDetainDateValue.AutoSize = true;
            this.lblDetainDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblDetainDateValue.Location = new System.Drawing.Point(184, 83);
            this.lblDetainDateValue.Name = "lblDetainDateValue";
            this.lblDetainDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblDetainDateValue.TabIndex = 15;
            this.lblDetainDateValue.Text = "???";
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
            this.lblDetainDate.Location = new System.Drawing.Point(32, 81);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(114, 20);
            this.lblDetainDate.TabIndex = 8;
            this.lblDetainDate.Text = "Detain Date";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblFineFees.Location = new System.Drawing.Point(32, 117);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(95, 20);
            this.lblFineFees.TabIndex = 6;
            this.lblFineFees.Text = "Fine Fees";
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(557, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(268, 39);
            this.lblHeader.TabIndex = 31;
            this.lblHeader.Text = "Detain License";
            // 
            // lnklblShowLicensesHistory
            // 
            this.lnklblShowLicensesHistory.AutoSize = true;
            this.lnklblShowLicensesHistory.Enabled = false;
            this.lnklblShowLicensesHistory.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowLicensesHistory.Location = new System.Drawing.Point(54, 707);
            this.lnklblShowLicensesHistory.Name = "lnklblShowLicensesHistory";
            this.lnklblShowLicensesHistory.Size = new System.Drawing.Size(198, 21);
            this.lnklblShowLicensesHistory.TabIndex = 36;
            this.lnklblShowLicensesHistory.TabStop = true;
            this.lnklblShowLicensesHistory.Text = "Show Licenses History";
            this.lnklblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblShowLicensesHistory_LinkClicked);
            // 
            // lnklblLicenseInfo
            // 
            this.lnklblLicenseInfo.AutoSize = true;
            this.lnklblLicenseInfo.Enabled = false;
            this.lnklblLicenseInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblLicenseInfo.Location = new System.Drawing.Point(304, 707);
            this.lnklblLicenseInfo.Name = "lnklblLicenseInfo";
            this.lnklblLicenseInfo.Size = new System.Drawing.Size(161, 21);
            this.lnklblLicenseInfo.TabIndex = 35;
            this.lnklblLicenseInfo.TabStop = true;
            this.lnklblLicenseInfo.Text = "Show License Info";
            this.lnklblLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLicenseInfo_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnDetain.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(1142, 695);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(134, 45);
            this.btnDetain.TabIndex = 34;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(982, 695);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errpFeesHandler
            // 
            this.errpFeesHandler.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 752);
            this.Controls.Add(this.lnklblShowLicensesHistory);
            this.Controls.Add(this.lnklblLicenseInfo);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpFeesHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalLicenses.Controls.ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblCreatedByUserName;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDateValue;
        private System.Windows.Forms.Label lblDetainIDValue;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnklblShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lnklblLicenseInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errpFeesHandler;
    }
}
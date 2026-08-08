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
            this.ctrlLicenseCardWithFilter1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCardWithFilter();
            this.ctrlRenewLocalLicenseCard1 = new DVLD.Licenses.RenewLocalLicenses.ctrlRenewLocalLicenseCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.lnklblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnklblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblRenewLicense
            // 
            this.lblRenewLicense.AutoSize = true;
            this.lblRenewLicense.BackColor = System.Drawing.Color.White;
            this.lblRenewLicense.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblRenewLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRenewLicense.Location = new System.Drawing.Point(388, 9);
            this.lblRenewLicense.Name = "lblRenewLicense";
            this.lblRenewLicense.Size = new System.Drawing.Size(487, 39);
            this.lblRenewLicense.TabIndex = 5;
            this.lblRenewLicense.Text = "Renew License Application";
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 70);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1232, 510);
            this.ctrlLicenseCardWithFilter1.TabIndex = 0;
            // 
            // ctrlRenewLocalLicenseCard1
            // 
            this.ctrlRenewLocalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlRenewLocalLicenseCard1.Location = new System.Drawing.Point(17, 586);
            this.ctrlRenewLocalLicenseCard1.Name = "ctrlRenewLocalLicenseCard1";
            this.ctrlRenewLocalLicenseCard1.Size = new System.Drawing.Size(1227, 394);
            this.ctrlRenewLocalLicenseCard1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(958, 998);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnRenew.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(1110, 998);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(134, 45);
            this.btnRenew.TabIndex = 27;
            this.btnRenew.Text = "Renew";
            this.btnRenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenew.UseVisualStyleBackColor = true;
            // 
            // lnklblShowNewLicenseInfo
            // 
            this.lnklblShowNewLicenseInfo.AutoSize = true;
            this.lnklblShowNewLicenseInfo.Enabled = false;
            this.lnklblShowNewLicenseInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowNewLicenseInfo.Location = new System.Drawing.Point(232, 1010);
            this.lnklblShowNewLicenseInfo.Name = "lnklblShowNewLicenseInfo";
            this.lnklblShowNewLicenseInfo.Size = new System.Drawing.Size(202, 21);
            this.lnklblShowNewLicenseInfo.TabIndex = 28;
            this.lnklblShowNewLicenseInfo.TabStop = true;
            this.lnklblShowNewLicenseInfo.Text = "Show New License Info";
            // 
            // lnklblShowLicensesHistory
            // 
            this.lnklblShowLicensesHistory.AutoSize = true;
            this.lnklblShowLicensesHistory.Enabled = false;
            this.lnklblShowLicensesHistory.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lnklblShowLicensesHistory.Location = new System.Drawing.Point(13, 1010);
            this.lnklblShowLicensesHistory.Name = "lnklblShowLicensesHistory";
            this.lnklblShowLicensesHistory.Size = new System.Drawing.Size(198, 21);
            this.lnklblShowLicensesHistory.TabIndex = 29;
            this.lnklblShowLicensesHistory.TabStop = true;
            this.lnklblShowLicensesHistory.Text = "Show Licenses History";
            // 
            // frmRenewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 1055);
            this.Controls.Add(this.lnklblShowLicensesHistory);
            this.Controls.Add(this.lnklblShowNewLicenseInfo);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlRenewLocalLicenseCard1);
            this.Controls.Add(this.lblRenewLicense);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLocalLicense";
            this.Text = "Renew Local Driving License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalLicenses.Controls.ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
        private System.Windows.Forms.Label lblRenewLicense;
        private RenewLocalLicenses.ctrlRenewLocalLicenseCard ctrlRenewLocalLicenseCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.LinkLabel lnklblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel lnklblShowLicensesHistory;
    }
}
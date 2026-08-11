namespace DVLD.Licenses.InternationalLicenses
{
    partial class frmInternationalLicenseCard
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
            this.ctrlInternationalLicenseCard1 = new DVLD.Applications.InternationalLicenses.ctrlInternationalLicenseCard();
            this.pbLicenseImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDriverInternationalLicenseInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlInternationalLicenseCard1
            // 
            this.ctrlInternationalLicenseCard1.Location = new System.Drawing.Point(23, 222);
            this.ctrlInternationalLicenseCard1.Name = "ctrlInternationalLicenseCard1";
            this.ctrlInternationalLicenseCard1.Size = new System.Drawing.Size(1222, 304);
            this.ctrlInternationalLicenseCard1.TabIndex = 0;
            // 
            // pbLicenseImage
            // 
            this.pbLicenseImage.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbLicenseImage.Location = new System.Drawing.Point(466, 12);
            this.pbLicenseImage.Name = "pbLicenseImage";
            this.pbLicenseImage.Size = new System.Drawing.Size(340, 139);
            this.pbLicenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseImage.TabIndex = 69;
            this.pbLicenseImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1112, 546);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 68;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDriverInternationalLicenseInfo
            // 
            this.lblDriverInternationalLicenseInfo.AutoSize = true;
            this.lblDriverInternationalLicenseInfo.BackColor = System.Drawing.Color.White;
            this.lblDriverInternationalLicenseInfo.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblDriverInternationalLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDriverInternationalLicenseInfo.Location = new System.Drawing.Point(339, 168);
            this.lblDriverInternationalLicenseInfo.Name = "lblDriverInternationalLicenseInfo";
            this.lblDriverInternationalLicenseInfo.Size = new System.Drawing.Size(589, 39);
            this.lblDriverInternationalLicenseInfo.TabIndex = 67;
            this.lblDriverInternationalLicenseInfo.Text = "Driver International License Info";
            // 
            // frmInternationalLicenseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 604);
            this.Controls.Add(this.pbLicenseImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDriverInternationalLicenseInfo);
            this.Controls.Add(this.ctrlInternationalLicenseCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInternationalLicenseCard";
            this.Text = "International License Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.InternationalLicenses.ctrlInternationalLicenseCard ctrlInternationalLicenseCard1;
        private System.Windows.Forms.PictureBox pbLicenseImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDriverInternationalLicenseInfo;
    }
}
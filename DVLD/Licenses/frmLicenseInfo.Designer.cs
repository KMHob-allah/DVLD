namespace DVLD.Licenses
{
    partial class frmLicenseInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDriverLicenseInfo = new System.Windows.Forms.Label();
            this.ctrlLicenseCard1 = new DVLD.Licenses.ctrlLicenseCard();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(890, 657);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDriverLicenseInfo
            // 
            this.lblDriverLicenseInfo.AutoSize = true;
            this.lblDriverLicenseInfo.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblDriverLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDriverLicenseInfo.Location = new System.Drawing.Point(358, 133);
            this.lblDriverLicenseInfo.Name = "lblDriverLicenseInfo";
            this.lblDriverLicenseInfo.Size = new System.Drawing.Size(347, 39);
            this.lblDriverLicenseInfo.TabIndex = 4;
            this.lblDriverLicenseInfo.Text = "Driver License Info";
            // 
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(36, 188);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(988, 454);
            this.ctrlLicenseCard1.TabIndex = 6;
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbPeople.Location = new System.Drawing.Point(432, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(187, 108);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 18;
            this.pbPeople.TabStop = false;
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.ctrlLicenseCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDriverLicenseInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseInfo";
            this.Text = "License Information";
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDriverLicenseInfo;
        private ctrlLicenseCard ctrlLicenseCard1;
        private System.Windows.Forms.PictureBox pbPeople;
    }
}
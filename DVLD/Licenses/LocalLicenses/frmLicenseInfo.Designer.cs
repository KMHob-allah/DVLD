namespace DVLD.Licenses.LocalLicenses
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
            this.lblDriverLicenseInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLicenseCard1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCard();
            this.pbLicenseImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverLicenseInfo
            // 
            this.lblDriverLicenseInfo.AutoSize = true;
            this.lblDriverLicenseInfo.BackColor = System.Drawing.Color.White;
            this.lblDriverLicenseInfo.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblDriverLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDriverLicenseInfo.Location = new System.Drawing.Point(494, 165);
            this.lblDriverLicenseInfo.Name = "lblDriverLicenseInfo";
            this.lblDriverLicenseInfo.Size = new System.Drawing.Size(347, 39);
            this.lblDriverLicenseInfo.TabIndex = 4;
            this.lblDriverLicenseInfo.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1146, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(51, 207);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(1228, 412);
            this.ctrlLicenseCard1.TabIndex = 0;
            // 
            // pbLicenseImage
            // 
            this.pbLicenseImage.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbLicenseImage.Location = new System.Drawing.Point(501, 12);
            this.pbLicenseImage.Name = "pbLicenseImage";
            this.pbLicenseImage.Size = new System.Drawing.Size(340, 139);
            this.pbLicenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseImage.TabIndex = 66;
            this.pbLicenseImage.TabStop = false;
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 693);
            this.Controls.Add(this.pbLicenseImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDriverLicenseInfo);
            this.Controls.Add(this.ctrlLicenseCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseInfo";
            this.Text = "Driver License Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlLicenseCard ctrlLicenseCard1;
        private System.Windows.Forms.Label lblDriverLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLicenseImage;
    }
}
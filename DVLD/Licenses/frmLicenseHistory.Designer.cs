namespace DVLD.Licenses
{
    partial class frmLicenseHistory
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
            this.lblLicenseHistory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLicensImage = new System.Windows.Forms.PictureBox();
            this.ctrlLicenseHistory1 = new DVLD.Licenses.Controls.ctrlLicenseHistory();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicensImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Bookman Old Style", 19F, System.Drawing.FontStyle.Bold);
            this.lblLicenseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLicenseHistory.Location = new System.Drawing.Point(15, 45);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(281, 38);
            this.lblLicenseHistory.TabIndex = 26;
            this.lblLicenseHistory.Text = "License History";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1226, 831);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLicensImage
            // 
            this.pbLicensImage.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pbLicensImage.Location = new System.Drawing.Point(22, 137);
            this.pbLicensImage.Name = "pbLicensImage";
            this.pbLicensImage.Size = new System.Drawing.Size(276, 347);
            this.pbLicensImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicensImage.TabIndex = 27;
            this.pbLicensImage.TabStop = false;
            // 
            // ctrlLicenseHistory1
            // 
            this.ctrlLicenseHistory1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseHistory1.Location = new System.Drawing.Point(18, 513);
            this.ctrlLicenseHistory1.Name = "ctrlLicenseHistory1";
            this.ctrlLicenseHistory1.Size = new System.Drawing.Size(1342, 298);
            this.ctrlLicenseHistory1.TabIndex = 29;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(319, 29);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1045, 467);
            this.ctrlPersonCardWithFilter1.TabIndex = 28;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 898);
            this.Controls.Add(this.ctrlLicenseHistory1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.pbLicensImage);
            this.Controls.Add(this.lblLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseHistory";
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLicensImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLicensImage;
        private System.Windows.Forms.Label lblLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlLicenseHistory ctrlLicenseHistory1;
    }
}
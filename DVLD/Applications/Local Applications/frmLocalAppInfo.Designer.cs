namespace DVLD.Applications.LocalApplications
{
    partial class frmLocalAppInfo
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
            this.ctrlLocalAppCard1 = new DVLD.Applications.LocalApplications.ctrlLocalAppCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLocalAppDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLocalAppCard1
            // 
            this.ctrlLocalAppCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalAppCard1.Location = new System.Drawing.Point(34, 115);
            this.ctrlLocalAppCard1.Name = "ctrlLocalAppCard1";
            this.ctrlLocalAppCard1.Size = new System.Drawing.Size(1177, 377);
            this.ctrlLocalAppCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1077, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLocalAppDetails
            // 
            this.lblLocalAppDetails.AutoSize = true;
            this.lblLocalAppDetails.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblLocalAppDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocalAppDetails.Location = new System.Drawing.Point(412, 48);
            this.lblLocalAppDetails.Name = "lblLocalAppDetails";
            this.lblLocalAppDetails.Size = new System.Drawing.Size(452, 39);
            this.lblLocalAppDetails.TabIndex = 13;
            this.lblLocalAppDetails.Text = "Local Application Details";
            // 
            // frmLocalAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 573);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLocalAppDetails);
            this.Controls.Add(this.ctrlLocalAppCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalAppInfo";
            this.Text = "frmLocalAppInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLocalAppCard ctrlLocalAppCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLocalAppDetails;
    }
}
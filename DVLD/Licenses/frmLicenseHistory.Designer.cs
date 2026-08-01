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
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dvgPeopleList = new System.Windows.Forms.DataGridView();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLicenseHistory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.pbLicensImage = new System.Windows.Forms.PictureBox();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeopleList)).BeginInit();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicensImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.tcDriverLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tcDriverLicenses.Location = new System.Drawing.Point(22, 535);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1342, 295);
            this.tcDriverLicenses.TabIndex = 24;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.lblRecords);
            this.tpLocalLicenses.Controls.Add(this.dvgPeopleList);
            this.tpLocalLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 30);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(1334, 261);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local Licenses";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(14, 224);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "# Records : 0";
            // 
            // dvgPeopleList
            // 
            this.dvgPeopleList.AllowUserToAddRows = false;
            this.dvgPeopleList.AllowUserToDeleteRows = false;
            this.dvgPeopleList.AllowUserToOrderColumns = true;
            this.dvgPeopleList.BackgroundColor = System.Drawing.Color.White;
            this.dvgPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPeopleList.Location = new System.Drawing.Point(18, 17);
            this.dvgPeopleList.Name = "dvgPeopleList";
            this.dvgPeopleList.ReadOnly = true;
            this.dvgPeopleList.RowHeadersWidth = 51;
            this.dvgPeopleList.RowTemplate.Height = 24;
            this.dvgPeopleList.Size = new System.Drawing.Size(1299, 193);
            this.dvgPeopleList.TabIndex = 1;
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.Controls.Add(this.label1);
            this.tpInternationalLicenses.Controls.Add(this.dataGridView1);
            this.tpInternationalLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 30);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(1334, 261);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International Licenses";
            this.tpInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Records : 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 192);
            this.dataGridView1.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(1230, 841);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
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
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 898);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.tcDriverLicenses);
            this.Controls.Add(this.pbLicensImage);
            this.Controls.Add(this.lblLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseHistory";
            this.Text = "License History";
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeopleList)).EndInit();
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicensImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dvgPeopleList;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbLicensImage;
        private System.Windows.Forms.Label lblLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}
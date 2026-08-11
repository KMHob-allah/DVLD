namespace DVLD.Licenses.DetainLicenses.DetainedLicensesList
{
    partial class frmDetainedLicensesList
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
            this.lblNoData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cmsLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.opReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.btnRelease = new System.Windows.Forms.Button();
            this.pbDetain = new System.Windows.Forms.PictureBox();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbReleaseList = new System.Windows.Forms.ComboBox();
            this.cmsLicenseOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(372, 463);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(738, 39);
            this.lblNoData.TabIndex = 29;
            this.lblNoData.Text = "You don\'t have Detained Licenses to show";
            this.lblNoData.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filter By ";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(526, 149);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(462, 39);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "Manage Detained Licenses";
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(388, 240);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(241, 24);
            this.tbUserFilterationValue.TabIndex = 24;
            this.tbUserFilterationValue.Visible = false;
            this.tbUserFilterationValue.TextChanged += new System.EventHandler(this.tbUserFilterationValue_TextChanged);
            this.tbUserFilterationValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserFilterationValue_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(131, 239);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(241, 27);
            this.cbFilters.TabIndex = 23;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(12, 691);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 21;
            this.lblRecords.Text = "# Records : 0";
            // 
            // cmsLicenseOptions
            // 
            this.cmsLicenseOptions.BackColor = System.Drawing.Color.White;
            this.cmsLicenseOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsLicenseOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLicenseOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowPersonDetails,
            this.opShowLicenseDetails,
            this.opShowPersonLicenseHistory,
            this.opReleaseDetainedLicense});
            this.cmsLicenseOptions.Name = "cmsOptions";
            this.cmsLicenseOptions.Size = new System.Drawing.Size(284, 108);
            this.cmsLicenseOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLicenseOptions_Opening);
            // 
            // opShowPersonDetails
            // 
            this.opShowPersonDetails.Image = global::DVLD.Properties.Resources.info;
            this.opShowPersonDetails.Name = "opShowPersonDetails";
            this.opShowPersonDetails.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonDetails.Text = "Show Person Details";
            this.opShowPersonDetails.Click += new System.EventHandler(this.opShowPersonDetails_Click);
            // 
            // opShowLicenseDetails
            // 
            this.opShowLicenseDetails.Image = global::DVLD.Properties.Resources.License_View_32;
            this.opShowLicenseDetails.Name = "opShowLicenseDetails";
            this.opShowLicenseDetails.Size = new System.Drawing.Size(283, 26);
            this.opShowLicenseDetails.Text = "Show License Details";
            this.opShowLicenseDetails.Click += new System.EventHandler(this.opShowLicenseDetails_Click);
            // 
            // opShowPersonLicenseHistory
            // 
            this.opShowPersonLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.opShowPersonLicenseHistory.Name = "opShowPersonLicenseHistory";
            this.opShowPersonLicenseHistory.Size = new System.Drawing.Size(283, 26);
            this.opShowPersonLicenseHistory.Text = "Show Person License History";
            this.opShowPersonLicenseHistory.Click += new System.EventHandler(this.opShowPersonLicenseHistory_Click);
            // 
            // opReleaseDetainedLicense
            // 
            this.opReleaseDetainedLicense.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.opReleaseDetainedLicense.Name = "opReleaseDetainedLicense";
            this.opReleaseDetainedLicense.Size = new System.Drawing.Size(283, 26);
            this.opReleaseDetainedLicense.Text = "Release Detained License";
            this.opReleaseDetainedLicense.Click += new System.EventHandler(this.opReleaseDetainedLicense_Click);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(16, 279);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersWidth = 51;
            this.dgvDetainedLicenses.RowTemplate.Height = 24;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1442, 387);
            this.dgvDetainedLicenses.TabIndex = 20;
            // 
            // btnRelease
            // 
            this.btnRelease.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnRelease.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.Location = new System.Drawing.Point(1324, 224);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(58, 52);
            this.btnRelease.TabIndex = 30;
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // pbDetain
            // 
            this.pbDetain.Image = global::DVLD.Properties.Resources.Detain_512;
            this.pbDetain.Location = new System.Drawing.Point(680, 16);
            this.pbDetain.Name = "pbDetain";
            this.pbDetain.Size = new System.Drawing.Size(170, 130);
            this.pbDetain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetain.TabIndex = 27;
            this.pbDetain.TabStop = false;
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnDetain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.btnDetain.Location = new System.Drawing.Point(1400, 221);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(58, 52);
            this.btnDetain.TabIndex = 26;
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1324, 681);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbReleaseList
            // 
            this.cbReleaseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbReleaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReleaseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReleaseList.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbReleaseList.FormattingEnabled = true;
            this.cbReleaseList.Location = new System.Drawing.Point(388, 240);
            this.cbReleaseList.Name = "cbReleaseList";
            this.cbReleaseList.Size = new System.Drawing.Size(241, 27);
            this.cbReleaseList.TabIndex = 31;
            this.cbReleaseList.Visible = false;
            this.cbReleaseList.SelectedIndexChanged += new System.EventHandler(this.cbReleaseList_SelectedIndexChanged);
            // 
            // frmDetainedLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1471, 743);
            this.Controls.Add(this.cbReleaseList);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDetain);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainedLicensesList";
            this.Text = "Detained Licenses List";
            this.Load += new System.EventHandler(this.frmDetainedLicensesList_Load);
            this.cmsLicenseOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDetain;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ToolStripMenuItem opReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem opShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem opShowPersonDetails;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseOptions;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.ComboBox cbReleaseList;
    }
}
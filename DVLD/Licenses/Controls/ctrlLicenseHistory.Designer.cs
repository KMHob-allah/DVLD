namespace DVLD.Licenses.Controls
{
    partial class ctrlLicenseHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.lblNoLocalLicenses = new System.Windows.Forms.Label();
            this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.lblNoInternationalLicenses = new System.Windows.Forms.Label();
            this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsLicenseOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.tcDriverLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tcDriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1337, 292);
            this.tcDriverLicenses.TabIndex = 25;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.lblNoLocalLicenses);
            this.tpLocalLicenses.Controls.Add(this.lblLocalLicensesRecords);
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicenses);
            this.tpLocalLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 30);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(1329, 258);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local Licenses";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblNoLocalLicenses
            // 
            this.lblNoLocalLicenses.AutoSize = true;
            this.lblNoLocalLicenses.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoLocalLicenses.ForeColor = System.Drawing.Color.Silver;
            this.lblNoLocalLicenses.Location = new System.Drawing.Point(343, 98);
            this.lblNoLocalLicenses.Name = "lblNoLocalLicenses";
            this.lblNoLocalLicenses.Size = new System.Drawing.Size(674, 39);
            this.lblNoLocalLicenses.TabIndex = 20;
            this.lblNoLocalLicenses.Text = "You don\'t have Local Licenses to show";
            this.lblNoLocalLicenses.Visible = false;
            // 
            // lblLocalLicensesRecords
            // 
            this.lblLocalLicensesRecords.AutoSize = true;
            this.lblLocalLicensesRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocalLicensesRecords.Location = new System.Drawing.Point(14, 224);
            this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            this.lblLocalLicensesRecords.Size = new System.Drawing.Size(145, 24);
            this.lblLocalLicensesRecords.TabIndex = 2;
            this.lblLocalLicensesRecords.Text = "# Records : 0";
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(18, 17);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.RowHeadersWidth = 51;
            this.dgvLocalLicenses.RowTemplate.Height = 24;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(1299, 193);
            this.dgvLocalLicenses.TabIndex = 1;
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.Controls.Add(this.lblNoInternationalLicenses);
            this.tpInternationalLicenses.Controls.Add(this.lblInternationalLicensesRecords);
            this.tpInternationalLicenses.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternationalLicenses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 30);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(1329, 258);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International Licenses";
            this.tpInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblNoInternationalLicenses
            // 
            this.lblNoInternationalLicenses.AutoSize = true;
            this.lblNoInternationalLicenses.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoInternationalLicenses.ForeColor = System.Drawing.Color.Silver;
            this.lblNoInternationalLicenses.Location = new System.Drawing.Point(267, 100);
            this.lblNoInternationalLicenses.Name = "lblNoInternationalLicenses";
            this.lblNoInternationalLicenses.Size = new System.Drawing.Size(816, 39);
            this.lblNoInternationalLicenses.TabIndex = 20;
            this.lblNoInternationalLicenses.Text = "You don\'t have International Licenses to show";
            this.lblNoInternationalLicenses.Visible = false;
            // 
            // lblInternationalLicensesRecords
            // 
            this.lblInternationalLicensesRecords.AutoSize = true;
            this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(14, 225);
            this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(145, 24);
            this.lblInternationalLicensesRecords.TabIndex = 3;
            this.lblInternationalLicensesRecords.Text = "# Records : 0";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(18, 17);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1298, 192);
            this.dgvInternationalLicenses.TabIndex = 2;
            // 
            // cmsLicenseOptions
            // 
            this.cmsLicenseOptions.BackColor = System.Drawing.Color.White;
            this.cmsLicenseOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsLicenseOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLicenseOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowLicenseDetails,
            this.toolStripSeparator1});
            this.cmsLicenseOptions.Name = "cmsOptions";
            this.cmsLicenseOptions.Size = new System.Drawing.Size(231, 36);
            this.cmsLicenseOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLicenseOptions_Opening);
            // 
            // opShowLicenseDetails
            // 
            this.opShowLicenseDetails.Image = global::DVLD.Properties.Resources.info;
            this.opShowLicenseDetails.Name = "opShowLicenseDetails";
            this.opShowLicenseDetails.Size = new System.Drawing.Size(230, 26);
            this.opShowLicenseDetails.Text = "Show License Details";
            this.opShowLicenseDetails.Click += new System.EventHandler(this.opShowLicenseDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // ctrlLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcDriverLicenses);
            this.Name = "ctrlLicenseHistory";
            this.Size = new System.Drawing.Size(1343, 298);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsLicenseOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblNoLocalLicenses;
        private System.Windows.Forms.Label lblNoInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseOptions;
        private System.Windows.Forms.ToolStripMenuItem opShowLicenseDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

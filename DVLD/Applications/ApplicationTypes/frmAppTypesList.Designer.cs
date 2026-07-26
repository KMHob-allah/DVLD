namespace DVLD.Applications.ApplicationTypes
{
    partial class frmAppTypesList
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
            this.dvgAppTypesList = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opEditType = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppTypesList)).BeginInit();
            this.cmsApplicationTypsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgAppTypesList
            // 
            this.dvgAppTypesList.AllowUserToAddRows = false;
            this.dvgAppTypesList.AllowUserToDeleteRows = false;
            this.dvgAppTypesList.AllowUserToOrderColumns = true;
            this.dvgAppTypesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAppTypesList.BackgroundColor = System.Drawing.Color.White;
            this.dvgAppTypesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgAppTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAppTypesList.ContextMenuStrip = this.cmsApplicationTypsOptions;
            this.dvgAppTypesList.Location = new System.Drawing.Point(62, 116);
            this.dvgAppTypesList.Name = "dvgAppTypesList";
            this.dvgAppTypesList.ReadOnly = true;
            this.dvgAppTypesList.RowHeadersWidth = 51;
            this.dvgAppTypesList.RowTemplate.Height = 24;
            this.dvgAppTypesList.Size = new System.Drawing.Size(1012, 365);
            this.dvgAppTypesList.TabIndex = 6;
            // 
            // cmsApplicationTypsOptions
            // 
            this.cmsApplicationTypsOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsApplicationTypsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplicationTypsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opEditType});
            this.cmsApplicationTypsOptions.Name = "cmsApplicationTypsOptions";
            this.cmsApplicationTypsOptions.Size = new System.Drawing.Size(228, 28);
            // 
            // opEditType
            // 
            this.opEditType.Name = "opEditType";
            this.opEditType.Size = new System.Drawing.Size(227, 24);
            this.opEditType.Text = "Edit Application Type";
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.lblManageApplicationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(349, 38);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(418, 35);
            this.lblManageApplicationTypes.TabIndex = 5;
            this.lblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(58, 512);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "# Records : 0";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(940, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAppTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 584);
            this.Controls.Add(this.dvgAppTypesList);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppTypesList";
            this.Text = "Application Types List";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppTypesList)).EndInit();
            this.cmsApplicationTypsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAppTypesList;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypsOptions;
        private System.Windows.Forms.ToolStripMenuItem opEditType;
        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
    }
}
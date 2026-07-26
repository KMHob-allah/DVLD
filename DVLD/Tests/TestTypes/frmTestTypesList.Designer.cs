namespace DVLD.Tests.TestTypes
{
    partial class frmTestTypesList
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
            this.dvgTestTypesList = new System.Windows.Forms.DataGridView();
            this.cmsTestTypesOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opEditType = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManageTestTypes = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pbAppTypesImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestTypesList)).BeginInit();
            this.cmsTestTypesOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppTypesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTestTypesList
            // 
            this.dvgTestTypesList.AllowUserToAddRows = false;
            this.dvgTestTypesList.AllowUserToDeleteRows = false;
            this.dvgTestTypesList.AllowUserToOrderColumns = true;
            this.dvgTestTypesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTestTypesList.BackgroundColor = System.Drawing.Color.White;
            this.dvgTestTypesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgTestTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTestTypesList.ContextMenuStrip = this.cmsTestTypesOptions;
            this.dvgTestTypesList.Location = new System.Drawing.Point(54, 190);
            this.dvgTestTypesList.Name = "dvgTestTypesList";
            this.dvgTestTypesList.ReadOnly = true;
            this.dvgTestTypesList.RowHeadersWidth = 51;
            this.dvgTestTypesList.RowTemplate.Height = 24;
            this.dvgTestTypesList.Size = new System.Drawing.Size(1012, 365);
            this.dvgTestTypesList.TabIndex = 10;
            // 
            // cmsTestTypesOptions
            // 
            this.cmsTestTypesOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsTestTypesOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestTypesOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opEditType});
            this.cmsTestTypesOptions.Name = "cmsApplicationTypsOptions";
            this.cmsTestTypesOptions.Size = new System.Drawing.Size(177, 28);
            // 
            // opEditType
            // 
            this.opEditType.Name = "opEditType";
            this.opEditType.Size = new System.Drawing.Size(176, 24);
            this.opEditType.Text = "Edit Test Type";
            // 
            // lblManageTestTypes
            // 
            this.lblManageTestTypes.AutoSize = true;
            this.lblManageTestTypes.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.lblManageTestTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageTestTypes.Location = new System.Drawing.Point(411, 132);
            this.lblManageTestTypes.Name = "lblManageTestTypes";
            this.lblManageTestTypes.Size = new System.Drawing.Size(300, 35);
            this.lblManageTestTypes.TabIndex = 9;
            this.lblManageTestTypes.Text = "Manage Test Types";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(50, 586);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 12;
            this.lblRecords.Text = "# Records : 0";
            // 
            // pbAppTypesImage
            // 
            this.pbAppTypesImage.Image = global::DVLD.Properties.Resources.TestType_512;
            this.pbAppTypesImage.Location = new System.Drawing.Point(479, 8);
            this.pbAppTypesImage.Name = "pbAppTypesImage";
            this.pbAppTypesImage.Size = new System.Drawing.Size(194, 121);
            this.pbAppTypesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppTypesImage.TabIndex = 29;
            this.pbAppTypesImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(932, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmTestTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 644);
            this.Controls.Add(this.pbAppTypesImage);
            this.Controls.Add(this.dvgTestTypesList);
            this.Controls.Add(this.lblManageTestTypes);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestTypesList";
            this.Text = "Test Types List";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestTypesList)).EndInit();
            this.cmsTestTypesOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppTypesImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTestTypesList;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypesOptions;
        private System.Windows.Forms.ToolStripMenuItem opEditType;
        private System.Windows.Forms.Label lblManageTestTypes;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbAppTypesImage;
    }
}
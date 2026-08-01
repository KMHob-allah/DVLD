namespace DVLD.Drivers
{
    partial class frmDriversList
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
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.lblFiterBy = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.dgvDriversList = new System.Windows.Forms.DataGridView();
            this.lblManageDrivers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(377, 251);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(224, 24);
            this.tbUserFilterationValue.TabIndex = 28;
            this.tbUserFilterationValue.Visible = false;
            // 
            // lblFiterBy
            // 
            this.lblFiterBy.AutoSize = true;
            this.lblFiterBy.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.lblFiterBy.Location = new System.Drawing.Point(43, 251);
            this.lblFiterBy.Name = "lblFiterBy";
            this.lblFiterBy.Size = new System.Drawing.Size(95, 21);
            this.lblFiterBy.TabIndex = 27;
            this.lblFiterBy.Text = "Filter By ";
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(133, 248);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(224, 27);
            this.cbFilters.TabIndex = 26;
            // 
            // dgvDriversList
            // 
            this.dgvDriversList.AllowUserToAddRows = false;
            this.dgvDriversList.AllowUserToDeleteRows = false;
            this.dgvDriversList.AllowUserToOrderColumns = true;
            this.dgvDriversList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriversList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriversList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversList.Location = new System.Drawing.Point(47, 286);
            this.dgvDriversList.Name = "dgvDriversList";
            this.dgvDriversList.ReadOnly = true;
            this.dgvDriversList.RowHeadersWidth = 51;
            this.dgvDriversList.RowTemplate.Height = 24;
            this.dgvDriversList.Size = new System.Drawing.Size(1304, 367);
            this.dgvDriversList.TabIndex = 21;
            // 
            // lblManageDrivers
            // 
            this.lblManageDrivers.AutoSize = true;
            this.lblManageDrivers.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblManageDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageDrivers.Location = new System.Drawing.Point(590, 179);
            this.lblManageDrivers.Name = "lblManageDrivers";
            this.lblManageDrivers.Size = new System.Drawing.Size(291, 40);
            this.lblManageDrivers.TabIndex = 24;
            this.lblManageDrivers.Text = "Manage Drivers";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1217, 664);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(43, 674);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "# Records : 0";
            // 
            // pbDrivers
            // 
            this.pbDrivers.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pbDrivers.Location = new System.Drawing.Point(597, 12);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(284, 164);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrivers.TabIndex = 25;
            this.pbDrivers.TabStop = false;
            // 
            // frmDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 735);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.dgvDriversList);
            this.Controls.Add(this.pbDrivers);
            this.Controls.Add(this.lblManageDrivers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDriversList";
            this.Text = "Drivers List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.Label lblFiterBy;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.DataGridView dgvDriversList;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.Label lblManageDrivers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
    }
}
namespace DVLD.Tests.TestAppointments
{
    partial class frmTestAppointmentsList
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
            this.ctrlLocalAppCard1 = new DVLD.Applications.LocalApplications.ctrlLocalAppCard();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.dgvAppointmentsList = new System.Windows.Forms.DataGridView();
            this.cmsTestOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.opTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.lblNoData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).BeginInit();
            this.cmsTestOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlLocalAppCard1
            // 
            this.ctrlLocalAppCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalAppCard1.Location = new System.Drawing.Point(23, 107);
            this.ctrlLocalAppCard1.Name = "ctrlLocalAppCard1";
            this.ctrlLocalAppCard1.Size = new System.Drawing.Size(1194, 370);
            this.ctrlLocalAppCard1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(380, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(476, 40);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Vision Test Appointments";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppointments.Location = new System.Drawing.Point(33, 511);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(154, 24);
            this.lblAppointments.TabIndex = 20;
            this.lblAppointments.Text = "Appointments";
            // 
            // dgvAppointmentsList
            // 
            this.dgvAppointmentsList.AllowUserToAddRows = false;
            this.dgvAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvAppointmentsList.AllowUserToOrderColumns = true;
            this.dgvAppointmentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointmentsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointmentsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsList.ContextMenuStrip = this.cmsTestOptions;
            this.dgvAppointmentsList.Location = new System.Drawing.Point(37, 547);
            this.dgvAppointmentsList.Name = "dgvAppointmentsList";
            this.dgvAppointmentsList.ReadOnly = true;
            this.dgvAppointmentsList.RowHeadersWidth = 51;
            this.dgvAppointmentsList.RowTemplate.Height = 24;
            this.dgvAppointmentsList.Size = new System.Drawing.Size(1164, 167);
            this.dgvAppointmentsList.TabIndex = 19;
            // 
            // cmsTestOptions
            // 
            this.cmsTestOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsTestOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opEdit,
            this.opTakeTest});
            this.cmsTestOptions.Name = "cmsOptions";
            this.cmsTestOptions.Size = new System.Drawing.Size(211, 80);
            this.cmsTestOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTestOptions_Opening);
            // 
            // opEdit
            // 
            this.opEdit.Name = "opEdit";
            this.opEdit.Size = new System.Drawing.Size(210, 24);
            this.opEdit.Text = "Edit";
            this.opEdit.Click += new System.EventHandler(this.opEdit_Click);
            // 
            // opTakeTest
            // 
            this.opTakeTest.Name = "opTakeTest";
            this.opTakeTest.Size = new System.Drawing.Size(210, 24);
            this.opTakeTest.Text = "Take";
            this.opTakeTest.Click += new System.EventHandler(this.opTakeTest_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(33, 744);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "# Records : 0";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1067, 734);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnAddAppointment.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(1144, 494);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(57, 47);
            this.btnAddAppointment.TabIndex = 21;
            this.btnAddAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(289, 616);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(616, 39);
            this.lblNoData.TabIndex = 24;
            this.lblNoData.Text = "You don\'t have Any Appointments";
            this.lblNoData.Visible = false;
            // 
            // frmTestAppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 791);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.dgvAppointmentsList);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlLocalAppCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestAppointmentsList";
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmTestAppointmentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).EndInit();
            this.cmsTestOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.LocalApplications.ctrlLocalAppCard ctrlLocalAppCard1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.DataGridView dgvAppointmentsList;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.ContextMenuStrip cmsTestOptions;
        private System.Windows.Forms.ToolStripMenuItem opEdit;
        private System.Windows.Forms.ToolStripMenuItem opTakeTest;
    }
}
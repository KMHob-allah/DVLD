namespace DVLD.People
{
    partial class frmPeopleManagement
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
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            this.cmsPersonOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblPeopleList = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoData = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.opEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.opDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.cmsPersonOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            this.dgvPeopleList.AllowUserToOrderColumns = true;
            this.dgvPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeopleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleList.ContextMenuStrip = this.cmsPersonOptions;
            this.dgvPeopleList.Location = new System.Drawing.Point(56, 275);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.ReadOnly = true;
            this.dgvPeopleList.RowHeadersWidth = 51;
            this.dgvPeopleList.RowTemplate.Height = 24;
            this.dgvPeopleList.Size = new System.Drawing.Size(1442, 387);
            this.dgvPeopleList.TabIndex = 9;
            // 
            // cmsPersonOptions
            // 
            this.cmsPersonOptions.BackColor = System.Drawing.Color.White;
            this.cmsPersonOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsPersonOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPersonOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowDetails,
            this.toolStripSeparator1,
            this.opAddNewPerson,
            this.opEdit,
            this.opDelete,
            this.toolStripSeparator2,
            this.opSendEmail,
            this.opSendSMS});
            this.cmsPersonOptions.Name = "cmsOptions";
            this.cmsPersonOptions.Size = new System.Drawing.Size(196, 172);
            this.cmsPersonOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPersonOptions_Opening);
            // 
            // lblPeopleList
            // 
            this.lblPeopleList.AutoSize = true;
            this.lblPeopleList.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblPeopleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeopleList.Location = new System.Drawing.Point(665, 145);
            this.lblPeopleList.Name = "lblPeopleList";
            this.lblPeopleList.Size = new System.Drawing.Size(269, 39);
            this.lblPeopleList.TabIndex = 15;
            this.lblPeopleList.Text = "Manage People";
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(428, 236);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(241, 24);
            this.tbUserFilterationValue.TabIndex = 14;
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
            this.cbFilters.Location = new System.Drawing.Point(171, 235);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(241, 27);
            this.cbFilters.TabIndex = 12;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(52, 687);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 10;
            this.lblRecords.Text = "# Records : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter By ";
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(537, 440);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(545, 39);
            this.lblNoData.TabIndex = 19;
            this.lblNoData.Text = "You don\'t have people to show";
            this.lblNoData.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // opShowDetails
            // 
            this.opShowDetails.Image = global::DVLD.Properties.Resources.info;
            this.opShowDetails.Name = "opShowDetails";
            this.opShowDetails.Size = new System.Drawing.Size(195, 26);
            this.opShowDetails.Text = "Show Details";
            this.opShowDetails.Click += new System.EventHandler(this.opShowDetails_Click);
            // 
            // opAddNewPerson
            // 
            this.opAddNewPerson.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.opAddNewPerson.Name = "opAddNewPerson";
            this.opAddNewPerson.Size = new System.Drawing.Size(195, 26);
            this.opAddNewPerson.Text = "Add New Person";
            this.opAddNewPerson.Click += new System.EventHandler(this.opAddNewPerson_Click);
            // 
            // opEdit
            // 
            this.opEdit.Image = global::DVLD.Properties.Resources.Details;
            this.opEdit.Name = "opEdit";
            this.opEdit.Size = new System.Drawing.Size(195, 26);
            this.opEdit.Text = "Edit";
            this.opEdit.Click += new System.EventHandler(this.opEdit_Click);
            // 
            // opDelete
            // 
            this.opDelete.Image = global::DVLD.Properties.Resources.recycle_bin;
            this.opDelete.Name = "opDelete";
            this.opDelete.Size = new System.Drawing.Size(195, 26);
            this.opDelete.Text = "Delete";
            this.opDelete.Click += new System.EventHandler(this.opDelete_Click);
            // 
            // opSendEmail
            // 
            this.opSendEmail.Image = global::DVLD.Properties.Resources.send_mail;
            this.opSendEmail.Name = "opSendEmail";
            this.opSendEmail.Size = new System.Drawing.Size(195, 26);
            this.opSendEmail.Text = "Send Email";
            this.opSendEmail.Click += new System.EventHandler(this.UnImplementedFeatures_Click);
            // 
            // opSendSMS
            // 
            this.opSendSMS.Image = global::DVLD.Properties.Resources.call_32;
            this.opSendSMS.Name = "opSendSMS";
            this.opSendSMS.Size = new System.Drawing.Size(195, 26);
            this.opSendSMS.Text = "Send SMS";
            this.opSendSMS.Click += new System.EventHandler(this.UnImplementedFeatures_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.People_400;
            this.pbPeople.Location = new System.Drawing.Point(720, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(170, 130);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 17;
            this.pbPeople.TabStop = false;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnAddNewPerson.Image = global::DVLD.Properties.Resources.add_person;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1432, 216);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(66, 53);
            this.btnAddNewPerson.TabIndex = 16;
            this.btnAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1364, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 734);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.lblPeopleList);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeopleManagement";
            this.Text = "People List";
            this.Load += new System.EventHandler(this.frmPeopleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.cmsPersonOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeopleList;
        private System.Windows.Forms.ContextMenuStrip cmsPersonOptions;
        private System.Windows.Forms.ToolStripMenuItem opShowDetails;
        private System.Windows.Forms.ToolStripMenuItem opAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem opEdit;
        private System.Windows.Forms.ToolStripMenuItem opDelete;
        private System.Windows.Forms.ToolStripMenuItem opSendEmail;
        private System.Windows.Forms.ToolStripMenuItem opSendSMS;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label lblPeopleList;
        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
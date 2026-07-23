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
            this.dvgPeopleList = new System.Windows.Forms.DataGridView();
            this.cmsPersonOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.opAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.opEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.opDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPeopleList = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeopleList)).BeginInit();
            this.cmsPersonOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPeopleList
            // 
            this.dvgPeopleList.AllowUserToAddRows = false;
            this.dvgPeopleList.AllowUserToDeleteRows = false;
            this.dvgPeopleList.AllowUserToOrderColumns = true;
            this.dvgPeopleList.BackgroundColor = System.Drawing.Color.White;
            this.dvgPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPeopleList.ContextMenuStrip = this.cmsPersonOptions;
            this.dvgPeopleList.Location = new System.Drawing.Point(27, 275);
            this.dvgPeopleList.Name = "dvgPeopleList";
            this.dvgPeopleList.ReadOnly = true;
            this.dvgPeopleList.RowHeadersWidth = 51;
            this.dvgPeopleList.RowTemplate.Height = 24;
            this.dvgPeopleList.Size = new System.Drawing.Size(1411, 387);
            this.dvgPeopleList.TabIndex = 9;
            // 
            // cmsPersonOptions
            // 
            this.cmsPersonOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsPersonOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPersonOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowDetails,
            this.opAddNewPerson,
            this.opEdit,
            this.opDelete,
            this.opSendEmail,
            this.opSendSMS});
            this.cmsPersonOptions.Name = "cmsOptions";
            this.cmsPersonOptions.Size = new System.Drawing.Size(192, 148);
            // 
            // opShowDetails
            // 
            this.opShowDetails.Name = "opShowDetails";
            this.opShowDetails.Size = new System.Drawing.Size(191, 24);
            this.opShowDetails.Text = "Show Details";
            // 
            // opAddNewPerson
            // 
            this.opAddNewPerson.Name = "opAddNewPerson";
            this.opAddNewPerson.Size = new System.Drawing.Size(191, 24);
            this.opAddNewPerson.Text = "Add New Person";
            // 
            // opEdit
            // 
            this.opEdit.Name = "opEdit";
            this.opEdit.Size = new System.Drawing.Size(191, 24);
            this.opEdit.Text = "Edit";
            // 
            // opDelete
            // 
            this.opDelete.Name = "opDelete";
            this.opDelete.Size = new System.Drawing.Size(191, 24);
            this.opDelete.Text = "Delete";
            // 
            // opSendEmail
            // 
            this.opSendEmail.Name = "opSendEmail";
            this.opSendEmail.Size = new System.Drawing.Size(191, 24);
            this.opSendEmail.Text = "Send Email";
            // 
            // opSendSMS
            // 
            this.opSendSMS.Name = "opSendSMS";
            this.opSendSMS.Size = new System.Drawing.Size(191, 24);
            this.opSendSMS.Text = "Send SMS";
            // 
            // lblPeopleList
            // 
            this.lblPeopleList.AutoSize = true;
            this.lblPeopleList.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblPeopleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeopleList.Location = new System.Drawing.Point(616, 145);
            this.lblPeopleList.Name = "lblPeopleList";
            this.lblPeopleList.Size = new System.Drawing.Size(269, 39);
            this.lblPeopleList.TabIndex = 15;
            this.lblPeopleList.Text = "Manage People";
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(388, 239);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(241, 24);
            this.tbUserFilterationValue.TabIndex = 14;
            this.tbUserFilterationValue.Visible = false;
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(132, 236);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(241, 27);
            this.cbFilters.TabIndex = 12;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(23, 687);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 10;
            this.lblRecords.Text = "# Records : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter By ";
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.People_400;
            this.pbPeople.Location = new System.Drawing.Point(671, 12);
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
            this.btnAddNewPerson.Location = new System.Drawing.Point(1372, 216);
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
            this.btnClose.Location = new System.Drawing.Point(1304, 677);
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
            this.ClientSize = new System.Drawing.Size(1465, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgPeopleList);
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
            this.Text = "frmPeopleManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeopleList)).EndInit();
            this.cmsPersonOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPeopleList;
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
    }
}
namespace DVLD.Users
{
    partial class frmUsersList
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
            this.cbActivationStatus = new System.Windows.Forms.ComboBox();
            this.opSendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.opSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.opDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.opEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.opAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.tbUserFilterationValue = new System.Windows.Forms.TextBox();
            this.lblFiterBy = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblNoData = new System.Windows.Forms.Label();
            this.cmsUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // cbActivationStatus
            // 
            this.cbActivationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbActivationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbActivationStatus.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbActivationStatus.FormattingEnabled = true;
            this.cbActivationStatus.Location = new System.Drawing.Point(406, 237);
            this.cbActivationStatus.Name = "cbActivationStatus";
            this.cbActivationStatus.Size = new System.Drawing.Size(224, 27);
            this.cbActivationStatus.TabIndex = 28;
            this.cbActivationStatus.Visible = false;
            this.cbActivationStatus.SelectedIndexChanged += new System.EventHandler(this.cbActivationStatus_SelectedIndexChanged);
            // 
            // opSendSMS
            // 
            this.opSendSMS.Name = "opSendSMS";
            this.opSendSMS.Size = new System.Drawing.Size(200, 24);
            this.opSendSMS.Text = "Send SMS";
            this.opSendSMS.Click += new System.EventHandler(this.opSendSMS_Click);
            // 
            // opSendEmail
            // 
            this.opSendEmail.Name = "opSendEmail";
            this.opSendEmail.Size = new System.Drawing.Size(200, 24);
            this.opSendEmail.Text = "Send Email";
            this.opSendEmail.Click += new System.EventHandler(this.opSendEmail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // opChangePassword
            // 
            this.opChangePassword.Name = "opChangePassword";
            this.opChangePassword.Size = new System.Drawing.Size(200, 24);
            this.opChangePassword.Text = "Change Password";
            // 
            // opDelete
            // 
            this.opDelete.Name = "opDelete";
            this.opDelete.Size = new System.Drawing.Size(200, 24);
            this.opDelete.Text = "Delete";
            this.opDelete.Click += new System.EventHandler(this.opDelete_Click);
            // 
            // opEdit
            // 
            this.opEdit.Name = "opEdit";
            this.opEdit.Size = new System.Drawing.Size(200, 24);
            this.opEdit.Text = "Edit";
            this.opEdit.Click += new System.EventHandler(this.opEdit_Click);
            // 
            // opAddNewUser
            // 
            this.opAddNewUser.Name = "opAddNewUser";
            this.opAddNewUser.Size = new System.Drawing.Size(200, 24);
            this.opAddNewUser.Text = "Add New User";
            this.opAddNewUser.Click += new System.EventHandler(this.opAddNewUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // opShowDetails
            // 
            this.opShowDetails.Name = "opShowDetails";
            this.opShowDetails.Size = new System.Drawing.Size(200, 24);
            this.opShowDetails.Text = "Show Details";
            this.opShowDetails.Click += new System.EventHandler(this.opShowDetails_Click);
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cmsUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opShowDetails,
            this.toolStripSeparator1,
            this.opAddNewUser,
            this.opEdit,
            this.opDelete,
            this.opChangePassword,
            this.toolStripSeparator2,
            this.opSendEmail,
            this.opSendSMS});
            this.cmsUserOptions.Name = "cmsOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(201, 184);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblManageUsers.ForeColor = System.Drawing.Color.Navy;
            this.lblManageUsers.Location = new System.Drawing.Point(481, 146);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(259, 40);
            this.lblManageUsers.TabIndex = 25;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // tbUserFilterationValue
            // 
            this.tbUserFilterationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserFilterationValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbUserFilterationValue.Location = new System.Drawing.Point(406, 237);
            this.tbUserFilterationValue.Name = "tbUserFilterationValue";
            this.tbUserFilterationValue.Size = new System.Drawing.Size(224, 24);
            this.tbUserFilterationValue.TabIndex = 24;
            this.tbUserFilterationValue.Visible = false;
            this.tbUserFilterationValue.TextChanged += new System.EventHandler(this.tbUserFilterationValue_TextChanged);
            this.tbUserFilterationValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserFilterationValue_KeyPress);
            // 
            // lblFiterBy
            // 
            this.lblFiterBy.AutoSize = true;
            this.lblFiterBy.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.lblFiterBy.Location = new System.Drawing.Point(31, 234);
            this.lblFiterBy.Name = "lblFiterBy";
            this.lblFiterBy.Size = new System.Drawing.Size(95, 21);
            this.lblFiterBy.TabIndex = 23;
            this.lblFiterBy.Text = "Filter By ";
            // 
            // cbFilters
            // 
            this.cbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilters.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(150, 234);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(224, 27);
            this.cbFilters.TabIndex = 22;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(31, 686);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(145, 24);
            this.lblRecords.TabIndex = 20;
            this.lblRecords.Text = "# Records : 0";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToOrderColumns = true;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.cmsUserOptions;
            this.dgvUsersList.Location = new System.Drawing.Point(35, 270);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersWidth = 51;
            this.dgvUsersList.RowTemplate.Height = 24;
            this.dgvUsersList.Size = new System.Drawing.Size(1124, 387);
            this.dgvUsersList.TabIndex = 19;
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.Users_2_400;
            this.pbPeople.Location = new System.Drawing.Point(504, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(214, 131);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 27;
            this.pbPeople.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1025, 676);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnAddNewUser.Image = global::DVLD.Properties.Resources.Add_New_User_72;
            this.btnAddNewUser.Location = new System.Drawing.Point(1077, 167);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(82, 97);
            this.btnAddNewUser.TabIndex = 26;
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblNoData.ForeColor = System.Drawing.Color.Silver;
            this.lblNoData.Location = new System.Drawing.Point(351, 422);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(527, 39);
            this.lblNoData.TabIndex = 29;
            this.lblNoData.Text = "You don\'t have Users to show";
            this.lblNoData.Visible = false;
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 742);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cbActivationStatus);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.tbUserFilterationValue);
            this.Controls.Add(this.lblFiterBy);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "frmUsersList";
            this.Text = "frmUsersList";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            this.cmsUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbActivationStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem opSendSMS;
        private System.Windows.Forms.ToolStripMenuItem opSendEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opChangePassword;
        private System.Windows.Forms.ToolStripMenuItem opDelete;
        private System.Windows.Forms.ToolStripMenuItem opEdit;
        private System.Windows.Forms.ToolStripMenuItem opAddNewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opShowDetails;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.TextBox tbUserFilterationValue;
        private System.Windows.Forms.Label lblFiterBy;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lblNoData;
    }
}
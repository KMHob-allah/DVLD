namespace DVLD.Users
{
    partial class frmAddUpdateUser
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
            this.errpLoginInfoHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.tbPasswordValue = new System.Windows.Forms.TextBox();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbConfirmPasswordValue = new System.Windows.Forms.TextBox();
            this.tbUserNameValue = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblAddUpdateUser = new System.Windows.Forms.Label();
            this.tcPersonInfoLoginInfo = new System.Windows.Forms.TabControl();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlLoginInfoImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errpLoginInfoHandler)).BeginInit();
            this.tpPersonInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            this.tcPersonInfoLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errpLoginInfoHandler
            // 
            this.errpLoginInfoHandler.ContainerControl = this;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 30);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1122, 565);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.pnlLoginInfoImage);
            this.tpLoginInfo.Controls.Add(this.pnlLoginInfo);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 30);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1122, 565);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.Controls.Add(this.lblUserID);
            this.pnlLoginInfo.Controls.Add(this.chkIsActive);
            this.pnlLoginInfo.Controls.Add(this.tbPasswordValue);
            this.pnlLoginInfo.Controls.Add(this.lblUserIDValue);
            this.pnlLoginInfo.Controls.Add(this.lblPassword);
            this.pnlLoginInfo.Controls.Add(this.lblUserName);
            this.pnlLoginInfo.Controls.Add(this.tbConfirmPasswordValue);
            this.pnlLoginInfo.Controls.Add(this.tbUserNameValue);
            this.pnlLoginInfo.Controls.Add(this.lblConfirmPassword);
            this.pnlLoginInfo.Location = new System.Drawing.Point(6, 6);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(572, 553);
            this.pnlLoginInfo.TabIndex = 14;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserID.Location = new System.Drawing.Point(15, 65);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(74, 21);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "User ID";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(197, 302);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(103, 25);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // tbPasswordValue
            // 
            this.tbPasswordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswordValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbPasswordValue.Location = new System.Drawing.Point(197, 185);
            this.tbPasswordValue.Name = "tbPasswordValue";
            this.tbPasswordValue.PasswordChar = '*';
            this.tbPasswordValue.Size = new System.Drawing.Size(239, 27);
            this.tbPasswordValue.TabIndex = 2;
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserIDValue.Location = new System.Drawing.Point(193, 65);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblUserIDValue.TabIndex = 12;
            this.lblUserIDValue.Text = "???";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblPassword.Location = new System.Drawing.Point(15, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 21);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserName.Location = new System.Drawing.Point(15, 126);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 21);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User Name";
            // 
            // tbConfirmPasswordValue
            // 
            this.tbConfirmPasswordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPasswordValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbConfirmPasswordValue.Location = new System.Drawing.Point(197, 248);
            this.tbConfirmPasswordValue.Name = "tbConfirmPasswordValue";
            this.tbConfirmPasswordValue.PasswordChar = '*';
            this.tbConfirmPasswordValue.Size = new System.Drawing.Size(239, 27);
            this.tbConfirmPasswordValue.TabIndex = 4;
            // 
            // tbUserNameValue
            // 
            this.tbUserNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserNameValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbUserNameValue.Location = new System.Drawing.Point(197, 122);
            this.tbUserNameValue.Name = "tbUserNameValue";
            this.tbUserNameValue.Size = new System.Drawing.Size(239, 27);
            this.tbUserNameValue.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 248);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(162, 21);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblAddUpdateUser
            // 
            this.lblAddUpdateUser.AutoSize = true;
            this.lblAddUpdateUser.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblAddUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddUpdateUser.Location = new System.Drawing.Point(469, 28);
            this.lblAddUpdateUser.Name = "lblAddUpdateUser";
            this.lblAddUpdateUser.Size = new System.Drawing.Size(267, 39);
            this.lblAddUpdateUser.TabIndex = 17;
            this.lblAddUpdateUser.Text = "Add New User";
            // 
            // tcPersonInfoLoginInfo
            // 
            this.tcPersonInfoLoginInfo.Controls.Add(this.tpPersonInfo);
            this.tcPersonInfoLoginInfo.Controls.Add(this.tpLoginInfo);
            this.tcPersonInfoLoginInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tcPersonInfoLoginInfo.Location = new System.Drawing.Point(30, 79);
            this.tcPersonInfoLoginInfo.Name = "tcPersonInfoLoginInfo";
            this.tcPersonInfoLoginInfo.SelectedIndex = 0;
            this.tcPersonInfoLoginInfo.Size = new System.Drawing.Size(1130, 599);
            this.tcPersonInfoLoginInfo.TabIndex = 20;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(35, 13);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1045, 467);
            this.ctrlPersonCardWithFilter1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(879, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1022, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(942, 499);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 45);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlLoginInfoImage
            // 
            this.pnlLoginInfoImage.BackgroundImage = global::DVLD.Properties.Resources.LoginInfo;
            this.pnlLoginInfoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLoginInfoImage.Location = new System.Drawing.Point(584, 6);
            this.pnlLoginInfoImage.Name = "pnlLoginInfoImage";
            this.pnlLoginInfoImage.Size = new System.Drawing.Size(532, 553);
            this.pnlLoginInfoImage.TabIndex = 15;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 751);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddUpdateUser);
            this.Controls.Add(this.tcPersonInfoLoginInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateUser";
            this.Text = "Add / Update User";
            ((System.ComponentModel.ISupportInitialize)(this.errpLoginInfoHandler)).EndInit();
            this.tpPersonInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            this.tcPersonInfoLoginInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errpLoginInfoHandler;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddUpdateUser;
        private System.Windows.Forms.TabControl tcPersonInfoLoginInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Panel pnlLoginInfoImage;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox tbPasswordValue;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbConfirmPasswordValue;
        private System.Windows.Forms.TextBox tbUserNameValue;
        private System.Windows.Forms.Label lblConfirmPassword;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}
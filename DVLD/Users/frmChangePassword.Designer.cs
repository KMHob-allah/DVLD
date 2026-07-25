namespace DVLD.Users
{
    partial class frmChangePassword
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
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNewPasswordValue = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.tbConfirmPasswordValue = new System.Windows.Forms.TextBox();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.errpChangePasswordHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserCard1 = new DVLD.Users.Controls.ctrlUserCard();
            ((System.ComponentModel.ISupportInitialize)(this.errpChangePasswordHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.lblChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChangePassword.Location = new System.Drawing.Point(387, 28);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(321, 39);
            this.lblChangePassword.TabIndex = 19;
            this.lblChangePassword.Text = "Change Password";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(797, 716);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(947, 716);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbNewPasswordValue
            // 
            this.tbNewPasswordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPasswordValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbNewPasswordValue.Location = new System.Drawing.Point(227, 671);
            this.tbNewPasswordValue.Name = "tbNewPasswordValue";
            this.tbNewPasswordValue.PasswordChar = '*';
            this.tbNewPasswordValue.Size = new System.Drawing.Size(239, 27);
            this.tbNewPasswordValue.TabIndex = 26;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblNewPassword.Location = new System.Drawing.Point(45, 673);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(131, 21);
            this.lblNewPassword.TabIndex = 28;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(45, 612);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(161, 21);
            this.lblCurrentPassword.TabIndex = 30;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // tbConfirmPasswordValue
            // 
            this.tbConfirmPasswordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPasswordValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbConfirmPasswordValue.Location = new System.Drawing.Point(227, 734);
            this.tbConfirmPasswordValue.Name = "tbConfirmPasswordValue";
            this.tbConfirmPasswordValue.PasswordChar = '*';
            this.tbConfirmPasswordValue.Size = new System.Drawing.Size(239, 27);
            this.tbConfirmPasswordValue.TabIndex = 27;
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbCurrentPassword.Location = new System.Drawing.Point(227, 608);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(239, 27);
            this.tbCurrentPassword.TabIndex = 25;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(45, 734);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(162, 21);
            this.lblConfirmPassword.TabIndex = 29;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // errpChangePasswordHandler
            // 
            this.errpChangePasswordHandler.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(34, 90);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(1051, 492);
            this.ctrlUserCard1.TabIndex = 33;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 785);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNewPasswordValue);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.tbConfirmPasswordValue);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblChangePassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpChangePasswordHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNewPasswordValue;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox tbConfirmPasswordValue;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ErrorProvider errpChangePasswordHandler;
        private Controls.ctrlUserCard ctrlUserCard1;
    }
}
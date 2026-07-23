namespace DVLD
{
    partial class frmMain
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
            this.msNavigation = new System.Windows.Forms.MenuStrip();
            this.opApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.opDrivingLicensesApps = new System.Windows.Forms.ToolStripMenuItem();
            this.opNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opReplacement = new System.Windows.Forms.ToolStripMenuItem();
            this.opReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.opManageApps = new System.Windows.Forms.ToolStripMenuItem();
            this.opLocalApps = new System.Windows.Forms.ToolStripMenuItem();
            this.opInternationalApps = new System.Windows.Forms.ToolStripMenuItem();
            this.opDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.opManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.opDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.opReleaseDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.opManageAppTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.opManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.opPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.opDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.opUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.opAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.opCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.opChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.opSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msNavigation
            // 
            this.msNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opApplications,
            this.opPeople,
            this.opDrivers,
            this.opUsers,
            this.opAccountSettings});
            this.msNavigation.Location = new System.Drawing.Point(0, 0);
            this.msNavigation.Name = "msNavigation";
            this.msNavigation.Size = new System.Drawing.Size(1546, 72);
            this.msNavigation.TabIndex = 0;
            this.msNavigation.Text = "menuStrip1";
            // 
            // opApplications
            // 
            this.opApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opDrivingLicensesApps,
            this.opManageApps,
            this.opDetainLicenses,
            this.opManageAppTypes,
            this.opManageTestTypes});
            this.opApplications.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.opApplications.Image = global::DVLD.Properties.Resources.Applications_64;
            this.opApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opApplications.Name = "opApplications";
            this.opApplications.Size = new System.Drawing.Size(192, 68);
            this.opApplications.Text = "Applications";
            // 
            // opDrivingLicensesApps
            // 
            this.opDrivingLicensesApps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opNewDrivingLicense,
            this.opRenewDrivingLicense,
            this.opReplacement,
            this.opReleaseDetainedLicense,
            this.opRetakeTest});
            this.opDrivingLicensesApps.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.opDrivingLicensesApps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opDrivingLicensesApps.Name = "opDrivingLicensesApps";
            this.opDrivingLicensesApps.Size = new System.Drawing.Size(360, 70);
            this.opDrivingLicensesApps.Text = "Driving Licenses Services";
            // 
            // opNewDrivingLicense
            // 
            this.opNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opLocalLicense,
            this.opInternationalLicense});
            this.opNewDrivingLicense.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.opNewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opNewDrivingLicense.Name = "opNewDrivingLicense";
            this.opNewDrivingLicense.Size = new System.Drawing.Size(459, 38);
            this.opNewDrivingLicense.Text = "New Driving License";
            // 
            // opLocalLicense
            // 
            this.opLocalLicense.Image = global::DVLD.Properties.Resources.Local_32;
            this.opLocalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opLocalLicense.Name = "opLocalLicense";
            this.opLocalLicense.Size = new System.Drawing.Size(283, 38);
            this.opLocalLicense.Text = "Local License";
            this.opLocalLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // opInternationalLicense
            // 
            this.opInternationalLicense.Image = global::DVLD.Properties.Resources.International_32;
            this.opInternationalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opInternationalLicense.Name = "opInternationalLicense";
            this.opInternationalLicense.Size = new System.Drawing.Size(283, 38);
            this.opInternationalLicense.Text = "International License";
            // 
            // opRenewDrivingLicense
            // 
            this.opRenewDrivingLicense.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.opRenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opRenewDrivingLicense.Name = "opRenewDrivingLicense";
            this.opRenewDrivingLicense.Size = new System.Drawing.Size(459, 38);
            this.opRenewDrivingLicense.Text = "Renew Driving License";
            // 
            // opReplacement
            // 
            this.opReplacement.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            this.opReplacement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opReplacement.Name = "opReplacement";
            this.opReplacement.Size = new System.Drawing.Size(459, 38);
            this.opReplacement.Text = "Replacement for Lost or Damaged License";
            // 
            // opReleaseDetainedLicense
            // 
            this.opReleaseDetainedLicense.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            this.opReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opReleaseDetainedLicense.Name = "opReleaseDetainedLicense";
            this.opReleaseDetainedLicense.Size = new System.Drawing.Size(459, 38);
            this.opReleaseDetainedLicense.Text = "Release Detained Driving License";
            // 
            // opRetakeTest
            // 
            this.opRetakeTest.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.opRetakeTest.Name = "opRetakeTest";
            this.opRetakeTest.Size = new System.Drawing.Size(459, 38);
            this.opRetakeTest.Text = "Retake Test";
            // 
            // opManageApps
            // 
            this.opManageApps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opLocalApps,
            this.opInternationalApps});
            this.opManageApps.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.opManageApps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opManageApps.Name = "opManageApps";
            this.opManageApps.Size = new System.Drawing.Size(360, 70);
            this.opManageApps.Text = "Manage Applications";
            // 
            // opLocalApps
            // 
            this.opLocalApps.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.opLocalApps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opLocalApps.Name = "opLocalApps";
            this.opLocalApps.Size = new System.Drawing.Size(393, 38);
            this.opLocalApps.Text = "Local Driving License Applications";
            // 
            // opInternationalApps
            // 
            this.opInternationalApps.Image = global::DVLD.Properties.Resources.International_32;
            this.opInternationalApps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opInternationalApps.Name = "opInternationalApps";
            this.opInternationalApps.Size = new System.Drawing.Size(393, 38);
            this.opInternationalApps.Text = "International License Applications";
            // 
            // opDetainLicenses
            // 
            this.opDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opManageDetainedLicenses,
            this.opDetainLicense,
            this.opReleaseDetainedLicenses});
            this.opDetainLicenses.Image = global::DVLD.Properties.Resources.Detain_64;
            this.opDetainLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opDetainLicenses.Name = "opDetainLicenses";
            this.opDetainLicenses.Size = new System.Drawing.Size(360, 70);
            this.opDetainLicenses.Text = "Detain Licenses";
            // 
            // opManageDetainedLicenses
            // 
            this.opManageDetainedLicenses.Image = global::DVLD.Properties.Resources.Detain_32;
            this.opManageDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opManageDetainedLicenses.Name = "opManageDetainedLicenses";
            this.opManageDetainedLicenses.Size = new System.Drawing.Size(333, 38);
            this.opManageDetainedLicenses.Text = "Manage Detained Licenses";
            // 
            // opDetainLicense
            // 
            this.opDetainLicense.Image = global::DVLD.Properties.Resources.Detain_32;
            this.opDetainLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opDetainLicense.Name = "opDetainLicense";
            this.opDetainLicense.Size = new System.Drawing.Size(333, 38);
            this.opDetainLicense.Text = "Detain License";
            // 
            // opReleaseDetainedLicenses
            // 
            this.opReleaseDetainedLicenses.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.opReleaseDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opReleaseDetainedLicenses.Name = "opReleaseDetainedLicenses";
            this.opReleaseDetainedLicenses.Size = new System.Drawing.Size(333, 38);
            this.opReleaseDetainedLicenses.Text = "Release Detained License";
            // 
            // opManageAppTypes
            // 
            this.opManageAppTypes.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.opManageAppTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opManageAppTypes.Name = "opManageAppTypes";
            this.opManageAppTypes.Size = new System.Drawing.Size(360, 70);
            this.opManageAppTypes.Text = "Manage Application Types";
            // 
            // opManageTestTypes
            // 
            this.opManageTestTypes.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.opManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opManageTestTypes.Name = "opManageTestTypes";
            this.opManageTestTypes.Size = new System.Drawing.Size(360, 70);
            this.opManageTestTypes.Text = "Manage Test Types";
            // 
            // opPeople
            // 
            this.opPeople.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.opPeople.Image = global::DVLD.Properties.Resources.People_64;
            this.opPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opPeople.Name = "opPeople";
            this.opPeople.Size = new System.Drawing.Size(145, 68);
            this.opPeople.Text = "People";
            this.opPeople.Click += new System.EventHandler(this.opPeople_Click);
            // 
            // opDrivers
            // 
            this.opDrivers.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.opDrivers.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.opDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opDrivers.Name = "opDrivers";
            this.opDrivers.Size = new System.Drawing.Size(149, 68);
            this.opDrivers.Text = "Drivers";
            // 
            // opUsers
            // 
            this.opUsers.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.opUsers.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.opUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opUsers.Name = "opUsers";
            this.opUsers.Size = new System.Drawing.Size(136, 68);
            this.opUsers.Text = "Users";
            // 
            // opAccountSettings
            // 
            this.opAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCurrentUserInfo,
            this.opChangePassword,
            this.opSignOut});
            this.opAccountSettings.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.opAccountSettings.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.opAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opAccountSettings.Name = "opAccountSettings";
            this.opAccountSettings.Size = new System.Drawing.Size(229, 68);
            this.opAccountSettings.Text = "Account Settings";
            // 
            // opCurrentUserInfo
            // 
            this.opCurrentUserInfo.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.opCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opCurrentUserInfo.Name = "opCurrentUserInfo";
            this.opCurrentUserInfo.Size = new System.Drawing.Size(255, 38);
            this.opCurrentUserInfo.Text = "Current User Info";
            // 
            // opChangePassword
            // 
            this.opChangePassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.opChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opChangePassword.Name = "opChangePassword";
            this.opChangePassword.Size = new System.Drawing.Size(255, 38);
            this.opChangePassword.Text = "Change Password";
            // 
            // opSignOut
            // 
            this.opSignOut.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.opSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opSignOut.Name = "opSignOut";
            this.opSignOut.Size = new System.Drawing.Size(255, 38);
            this.opSignOut.Text = "Sign Out";
            // 
            // pbMainImage
            // 
            this.pbMainImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pbMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainImage.Image = global::DVLD.Properties.Resources.Wheel;
            this.pbMainImage.Location = new System.Drawing.Point(0, 72);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(1546, 581);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 1;
            this.pbMainImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1687, 866);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1546, 653);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.msNavigation);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem opApplications;
        private System.Windows.Forms.ToolStripMenuItem opPeople;
        private System.Windows.Forms.ToolStripMenuItem opDrivers;
        private System.Windows.Forms.ToolStripMenuItem opUsers;
        private System.Windows.Forms.ToolStripMenuItem opAccountSettings;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem opDrivingLicensesApps;
        private System.Windows.Forms.ToolStripMenuItem opManageApps;
        private System.Windows.Forms.ToolStripMenuItem opDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem opManageAppTypes;
        private System.Windows.Forms.ToolStripMenuItem opManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem opNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem opRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem opReplacement;
        private System.Windows.Forms.ToolStripMenuItem opReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem opRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem opLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem opInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem opLocalApps;
        private System.Windows.Forms.ToolStripMenuItem opInternationalApps;
        private System.Windows.Forms.ToolStripMenuItem opManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem opDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem opReleaseDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem opCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem opChangePassword;
        private System.Windows.Forms.ToolStripMenuItem opSignOut;
    }
}


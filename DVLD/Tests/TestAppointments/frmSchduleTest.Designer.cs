namespace DVLD.Tests.TestAppointments
{
    partial class frmSchduleTest
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblRetakeTestAppIDValue = new System.Windows.Forms.Label();
            this.lblRetakeAppFeesValue = new System.Windows.Forms.Label();
            this.lblRetakeTestAppID = new System.Windows.Forms.Label();
            this.lblRetakeAppFees = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocalAppIDValue = new System.Windows.Forms.Label();
            this.lblDrivingClassValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblTrailValue = new System.Windows.Forms.Label();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTrail = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDrivingClass = new System.Windows.Forms.Label();
            this.lblDrivingLicenseAppID = new System.Windows.Forms.Label();
            this.lblSchduleTest = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(85, 91);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(490, 20);
            this.lblMessage.TabIndex = 52;
            this.lblMessage.Text = "Person already sat for the test, appointment is locked";
            this.lblMessage.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(42, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblTotalFeesValue.Location = new System.Drawing.Point(146, 609);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(20, 21);
            this.lblTotalFeesValue.TabIndex = 35;
            this.lblTotalFeesValue.Text = "0";
            // 
            // lblRetakeTestAppIDValue
            // 
            this.lblRetakeTestAppIDValue.AutoSize = true;
            this.lblRetakeTestAppIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblRetakeTestAppIDValue.Location = new System.Drawing.Point(492, 66);
            this.lblRetakeTestAppIDValue.Name = "lblRetakeTestAppIDValue";
            this.lblRetakeTestAppIDValue.Size = new System.Drawing.Size(45, 21);
            this.lblRetakeTestAppIDValue.TabIndex = 15;
            this.lblRetakeTestAppIDValue.Text = "N/A";
            // 
            // lblRetakeAppFeesValue
            // 
            this.lblRetakeAppFeesValue.AutoSize = true;
            this.lblRetakeAppFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblRetakeAppFeesValue.Location = new System.Drawing.Point(200, 66);
            this.lblRetakeAppFeesValue.Name = "lblRetakeAppFeesValue";
            this.lblRetakeAppFeesValue.Size = new System.Drawing.Size(20, 21);
            this.lblRetakeAppFeesValue.TabIndex = 9;
            this.lblRetakeAppFeesValue.Text = "0";
            // 
            // lblRetakeTestAppID
            // 
            this.lblRetakeTestAppID.AutoSize = true;
            this.lblRetakeTestAppID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblRetakeTestAppID.Location = new System.Drawing.Point(298, 66);
            this.lblRetakeTestAppID.Name = "lblRetakeTestAppID";
            this.lblRetakeTestAppID.Size = new System.Drawing.Size(182, 20);
            this.lblRetakeTestAppID.TabIndex = 8;
            this.lblRetakeTestAppID.Text = "Retake Test App ID";
            // 
            // lblRetakeAppFees
            // 
            this.lblRetakeAppFees.AutoSize = true;
            this.lblRetakeAppFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblRetakeAppFees.Location = new System.Drawing.Point(32, 66);
            this.lblRetakeAppFees.Name = "lblRetakeAppFees";
            this.lblRetakeAppFees.Size = new System.Drawing.Size(158, 20);
            this.lblRetakeAppFees.TabIndex = 0;
            this.lblRetakeAppFees.Text = "Retake App Fees";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(506, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.BackColor = System.Drawing.Color.White;
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestAppIDValue);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeAppFeesValue);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestAppID);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeAppFees);
            this.gbRetakeTestInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRetakeTestInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(38, 460);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(602, 128);
            this.gbRetakeTestInfo.TabIndex = 49;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Location = new System.Drawing.Point(276, 383);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(253, 22);
            this.dtpTestDate.TabIndex = 48;
            // 
            // lblLocalAppIDValue
            // 
            this.lblLocalAppIDValue.AutoSize = true;
            this.lblLocalAppIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblLocalAppIDValue.Location = new System.Drawing.Point(272, 145);
            this.lblLocalAppIDValue.Name = "lblLocalAppIDValue";
            this.lblLocalAppIDValue.Size = new System.Drawing.Size(45, 21);
            this.lblLocalAppIDValue.TabIndex = 47;
            this.lblLocalAppIDValue.Text = "N/A";
            // 
            // lblDrivingClassValue
            // 
            this.lblDrivingClassValue.AutoSize = true;
            this.lblDrivingClassValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblDrivingClassValue.Location = new System.Drawing.Point(272, 193);
            this.lblDrivingClassValue.Name = "lblDrivingClassValue";
            this.lblDrivingClassValue.Size = new System.Drawing.Size(37, 21);
            this.lblDrivingClassValue.TabIndex = 46;
            this.lblDrivingClassValue.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(38, 609);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(102, 20);
            this.lblTotalFees.TabIndex = 34;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblNameValue.Location = new System.Drawing.Point(272, 241);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(37, 21);
            this.lblNameValue.TabIndex = 45;
            this.lblNameValue.Text = "???";
            // 
            // lblTrailValue
            // 
            this.lblTrailValue.AutoSize = true;
            this.lblTrailValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblTrailValue.Location = new System.Drawing.Point(272, 289);
            this.lblTrailValue.Name = "lblTrailValue";
            this.lblTrailValue.Size = new System.Drawing.Size(20, 21);
            this.lblTrailValue.TabIndex = 44;
            this.lblTrailValue.Text = "0";
            // 
            // lblFeesValue
            // 
            this.lblFeesValue.AutoSize = true;
            this.lblFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblFeesValue.Location = new System.Drawing.Point(272, 337);
            this.lblFeesValue.Name = "lblFeesValue";
            this.lblFeesValue.Size = new System.Drawing.Size(20, 21);
            this.lblFeesValue.TabIndex = 43;
            this.lblFeesValue.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(38, 241);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Name";
            // 
            // lblTrail
            // 
            this.lblTrail.AutoSize = true;
            this.lblTrail.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrail.Location = new System.Drawing.Point(38, 289);
            this.lblTrail.Name = "lblTrail";
            this.lblTrail.Size = new System.Drawing.Size(51, 20);
            this.lblTrail.TabIndex = 41;
            this.lblTrail.Text = "Trail";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(38, 385);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblFees.Location = new System.Drawing.Point(38, 337);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(50, 20);
            this.lblFees.TabIndex = 39;
            this.lblFees.Text = "Fees";
            // 
            // lblDrivingClass
            // 
            this.lblDrivingClass.AutoSize = true;
            this.lblDrivingClass.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblDrivingClass.Location = new System.Drawing.Point(38, 193);
            this.lblDrivingClass.Name = "lblDrivingClass";
            this.lblDrivingClass.Size = new System.Drawing.Size(126, 20);
            this.lblDrivingClass.TabIndex = 38;
            this.lblDrivingClass.Text = "Driving Class";
            // 
            // lblDrivingLicenseAppID
            // 
            this.lblDrivingLicenseAppID.AutoSize = true;
            this.lblDrivingLicenseAppID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblDrivingLicenseAppID.Location = new System.Drawing.Point(38, 145);
            this.lblDrivingLicenseAppID.Name = "lblDrivingLicenseAppID";
            this.lblDrivingLicenseAppID.Size = new System.Drawing.Size(212, 20);
            this.lblDrivingLicenseAppID.TabIndex = 37;
            this.lblDrivingLicenseAppID.Text = "Driving License App ID";
            // 
            // lblSchduleTest
            // 
            this.lblSchduleTest.AutoSize = true;
            this.lblSchduleTest.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblSchduleTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSchduleTest.Location = new System.Drawing.Point(210, 25);
            this.lblSchduleTest.Name = "lblSchduleTest";
            this.lblSchduleTest.Size = new System.Drawing.Size(248, 40);
            this.lblSchduleTest.TabIndex = 36;
            this.lblSchduleTest.Text = "Schdule Test";
            // 
            // frmSchduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 751);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalFeesValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRetakeTestInfo);
            this.Controls.Add(this.dtpTestDate);
            this.Controls.Add(this.lblLocalAppIDValue);
            this.Controls.Add(this.lblDrivingClassValue);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblTrailValue);
            this.Controls.Add(this.lblFeesValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTrail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblDrivingClass);
            this.Controls.Add(this.lblDrivingLicenseAppID);
            this.Controls.Add(this.lblSchduleTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchduleTest";
            this.Text = "Schdule Test";
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblRetakeTestAppIDValue;
        private System.Windows.Forms.Label lblRetakeAppFeesValue;
        private System.Windows.Forms.Label lblRetakeTestAppID;
        private System.Windows.Forms.Label lblRetakeAppFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Label lblLocalAppIDValue;
        private System.Windows.Forms.Label lblDrivingClassValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblTrailValue;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTrail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDrivingClass;
        private System.Windows.Forms.Label lblDrivingLicenseAppID;
        private System.Windows.Forms.Label lblSchduleTest;
    }
}
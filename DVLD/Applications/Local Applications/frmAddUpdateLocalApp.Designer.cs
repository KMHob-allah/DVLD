namespace DVLD.Applications.LocalApplications
{
    partial class frmAddUpdateLocalApp
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddEditUser = new System.Windows.Forms.Label();
            this.tcPersonApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCeatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationIDValue = new System.Windows.Forms.Label();
            this.errpAppInfoHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcPersonApplicationInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAppInfoHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(322, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(612, 35);
            this.lblHeader.TabIndex = 26;
            this.lblHeader.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(860, 682);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1021, 682);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddEditUser
            // 
            this.lblAddEditUser.AutoSize = true;
            this.lblAddEditUser.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.lblAddEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddEditUser.Location = new System.Drawing.Point(396, -37);
            this.lblAddEditUser.Name = "lblAddEditUser";
            this.lblAddEditUser.Size = new System.Drawing.Size(238, 35);
            this.lblAddEditUser.TabIndex = 22;
            this.lblAddEditUser.Text = "Add New User";
            // 
            // tcPersonApplicationInfo
            // 
            this.tcPersonApplicationInfo.Controls.Add(this.tpPersonInfo);
            this.tcPersonApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcPersonApplicationInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tcPersonApplicationInfo.Location = new System.Drawing.Point(52, 84);
            this.tcPersonApplicationInfo.Name = "tcPersonApplicationInfo";
            this.tcPersonApplicationInfo.SelectedIndex = 0;
            this.tcPersonApplicationInfo.Size = new System.Drawing.Size(1107, 575);
            this.tcPersonApplicationInfo.TabIndex = 25;
            this.tcPersonApplicationInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcPersonApplicationInfo_Selecting);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 30);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1099, 541);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(27, 13);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1045, 467);
            this.ctrlPersonCardWithFilter1.TabIndex = 6;
            this.ctrlPersonCardWithFilter1.WhenPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_WhenPersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(938, 484);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 45);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.panel2);
            this.tpApplicationInfo.Controls.Add(this.panel1);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 30);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(1099, 541);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DVLD.Properties.Resources.LoginInfo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(584, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 529);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCeatedByValue);
            this.panel1.Controls.Add(this.lblCreatedBy);
            this.panel1.Controls.Add(this.lblAppFeesValue);
            this.panel1.Controls.Add(this.lblApplicationFees);
            this.panel1.Controls.Add(this.cbClasses);
            this.panel1.Controls.Add(this.lblLicenseClass);
            this.panel1.Controls.Add(this.lblApplicationDateValue);
            this.panel1.Controls.Add(this.lblApplicationDate);
            this.panel1.Controls.Add(this.lblApplicationID);
            this.panel1.Controls.Add(this.lblApplicationIDValue);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 529);
            this.panel1.TabIndex = 14;
            // 
            // lblCeatedByValue
            // 
            this.lblCeatedByValue.AutoSize = true;
            this.lblCeatedByValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblCeatedByValue.Location = new System.Drawing.Point(217, 239);
            this.lblCeatedByValue.Name = "lblCeatedByValue";
            this.lblCeatedByValue.Size = new System.Drawing.Size(37, 21);
            this.lblCeatedByValue.TabIndex = 20;
            this.lblCeatedByValue.Text = "???";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(42, 236);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(108, 20);
            this.lblCreatedBy.TabIndex = 19;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblAppFeesValue.Location = new System.Drawing.Point(217, 181);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(37, 21);
            this.lblAppFeesValue.TabIndex = 18;
            this.lblAppFeesValue.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.Location = new System.Drawing.Point(42, 179);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(157, 20);
            this.lblApplicationFees.TabIndex = 17;
            this.lblApplicationFees.Text = "Application Fees";
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(217, 289);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(341, 29);
            this.cbClasses.TabIndex = 16;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClass.Location = new System.Drawing.Point(42, 293);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(129, 20);
            this.lblLicenseClass.TabIndex = 15;
            this.lblLicenseClass.Text = "License Class";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblApplicationDateValue.Location = new System.Drawing.Point(217, 121);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(37, 21);
            this.lblApplicationDateValue.TabIndex = 14;
            this.lblApplicationDateValue.Text = "???";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.Location = new System.Drawing.Point(42, 122);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(157, 20);
            this.lblApplicationDate.TabIndex = 13;
            this.lblApplicationDate.Text = "Application Date";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationID.Location = new System.Drawing.Point(42, 65);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(136, 20);
            this.lblApplicationID.TabIndex = 5;
            this.lblApplicationID.Text = "Application ID";
            // 
            // lblApplicationIDValue
            // 
            this.lblApplicationIDValue.AutoSize = true;
            this.lblApplicationIDValue.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblApplicationIDValue.Location = new System.Drawing.Point(217, 65);
            this.lblApplicationIDValue.Name = "lblApplicationIDValue";
            this.lblApplicationIDValue.Size = new System.Drawing.Size(37, 21);
            this.lblApplicationIDValue.TabIndex = 12;
            this.lblApplicationIDValue.Text = "???";
            // 
            // errpAppInfoHandler
            // 
            this.errpAppInfoHandler.ContainerControl = this;
            // 
            // frmAddUpdateLocalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 739);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddEditUser);
            this.Controls.Add(this.tcPersonApplicationInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateLocalApp";
            this.Text = "Add / Update Local Application Info";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalApp_Load);
            this.tcPersonApplicationInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAppInfoHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddEditUser;
        private System.Windows.Forms.TabControl tcPersonApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCeatedByValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblApplicationIDValue;
        private System.Windows.Forms.ErrorProvider errpAppInfoHandler;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}
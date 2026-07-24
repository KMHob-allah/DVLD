namespace DVLD.Users.Controls
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblIsActiveVal = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserNameVal = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserIDVal = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1040, 366);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.BackColor = System.Drawing.Color.White;
            this.gbLoginInfo.Controls.Add(this.lblIsActiveVal);
            this.gbLoginInfo.Controls.Add(this.lblIsActive);
            this.gbLoginInfo.Controls.Add(this.lblUserNameVal);
            this.gbLoginInfo.Controls.Add(this.lblUserName);
            this.gbLoginInfo.Controls.Add(this.lblUserIDVal);
            this.gbLoginInfo.Controls.Add(this.lblUserID);
            this.gbLoginInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbLoginInfo.Location = new System.Drawing.Point(10, 375);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(1033, 106);
            this.gbLoginInfo.TabIndex = 2;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Login Info";
            // 
            // lblIsActiveVal
            // 
            this.lblIsActiveVal.AutoSize = true;
            this.lblIsActiveVal.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblIsActiveVal.Location = new System.Drawing.Point(823, 54);
            this.lblIsActiveVal.Name = "lblIsActiveVal";
            this.lblIsActiveVal.Size = new System.Drawing.Size(37, 21);
            this.lblIsActiveVal.TabIndex = 7;
            this.lblIsActiveVal.Text = "???";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblIsActive.Location = new System.Drawing.Point(701, 54);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(81, 21);
            this.lblIsActive.TabIndex = 6;
            this.lblIsActive.Text = "Is Active";
            // 
            // lblUserNameVal
            // 
            this.lblUserNameVal.AutoSize = true;
            this.lblUserNameVal.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserNameVal.Location = new System.Drawing.Point(564, 54);
            this.lblUserNameVal.Name = "lblUserNameVal";
            this.lblUserNameVal.Size = new System.Drawing.Size(37, 21);
            this.lblUserNameVal.TabIndex = 5;
            this.lblUserNameVal.Text = "???";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserName.Location = new System.Drawing.Point(419, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 21);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserIDVal
            // 
            this.lblUserIDVal.AutoSize = true;
            this.lblUserIDVal.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserIDVal.Location = new System.Drawing.Point(301, 54);
            this.lblUserIDVal.Name = "lblUserIDVal";
            this.lblUserIDVal.Size = new System.Drawing.Size(37, 21);
            this.lblUserIDVal.TabIndex = 3;
            this.lblUserIDVal.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.lblUserID.Location = new System.Drawing.Point(186, 54);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(74, 21);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(1051, 492);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label lblIsActiveVal;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserNameVal;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserIDVal;
        private System.Windows.Forms.Label lblUserID;
    }
}

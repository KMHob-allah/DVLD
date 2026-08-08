namespace DVLD.Licenses
{
    partial class frmIssueLocalDrivingLicense
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
            this.tbNotesValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ctrlLocalAppCard1 = new DVLD.Applications.LocalApplications.ctrlLocalAppCard();
            this.btnIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNotesValue
            // 
            this.tbNotesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotesValue.Location = new System.Drawing.Point(44, 484);
            this.tbNotesValue.Multiline = true;
            this.tbNotesValue.Name = "tbNotesValue";
            this.tbNotesValue.Size = new System.Drawing.Size(1163, 123);
            this.tbNotesValue.TabIndex = 38;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(931, 636);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(41, 455);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(67, 24);
            this.lblNotes.TabIndex = 39;
            this.lblNotes.Text = "Notes";
            // 
            // ctrlLocalAppCard1
            // 
            this.ctrlLocalAppCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalAppCard1.Location = new System.Drawing.Point(28, 50);
            this.ctrlLocalAppCard1.Name = "ctrlLocalAppCard1";
            this.ctrlLocalAppCard1.Size = new System.Drawing.Size(1194, 370);
            this.ctrlLocalAppCard1.TabIndex = 42;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1074, 636);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(133, 46);
            this.btnIssue.TabIndex = 41;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmIssueLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 701);
            this.Controls.Add(this.ctrlLocalAppCard1);
            this.Controls.Add(this.tbNotesValue);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNotes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueLocalDrivingLicense";
            this.Text = "Issue Local Driving License";
            this.Load += new System.EventHandler(this.frmIssueLocalDrivingLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNotesValue;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNotes;
        private Applications.LocalApplications.ctrlLocalAppCard ctrlLocalAppCard1;
    }
}
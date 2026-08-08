namespace DVLD.Licenses.LocalLicenses.Controls
{
    partial class ctrlLicenseCardWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.ctrlLicenseCard1 = new DVLD.Licenses.LocalLicenses.Controls.ctrlLicenseCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbLicenseID);
            this.gbFilter.Controls.Add(this.lblLicenseID);
            this.gbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilter.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(614, 87);
            this.gbFilter.TabIndex = 4;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DVLD.Properties.Resources.search__1_;
            this.btnSearch.Location = new System.Drawing.Point(542, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 58);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.tbLicenseID.Location = new System.Drawing.Point(245, 37);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(277, 27);
            this.tbLicenseID.TabIndex = 2;
            this.tbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicenseID_KeyPress);
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.Location = new System.Drawing.Point(97, 38);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(133, 24);
            this.lblLicenseID.TabIndex = 2;
            this.lblLicenseID.Text = "License ID :";
            // 
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(3, 96);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(1228, 412);
            this.ctrlLicenseCard1.TabIndex = 0;
            // 
            // ctrlLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlLicenseCard1);
            this.Name = "ctrlLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(1232, 510);
            this.Load += new System.EventHandler(this.ctrlLicenseCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLicenseCard ctrlLicenseCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.Label lblLicenseID;
    }
}

namespace DVLD.Tests.TestTypes
{
    partial class frmUpdateTestType
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
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.tbFeesValue = new System.Windows.Forms.TextBox();
            this.tbTitleValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTestFees = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.lblEditTestType = new System.Windows.Forms.Label();
            this.errpEditTestHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.tbTestDescriptionValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errpEditTestHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestTypeID.Location = new System.Drawing.Point(343, 159);
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size(49, 24);
            this.lblTestTypeID.TabIndex = 60;
            this.lblTestTypeID.Text = "???";
            // 
            // tbFeesValue
            // 
            this.tbFeesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbFeesValue.Location = new System.Drawing.Point(343, 457);
            this.tbFeesValue.Name = "tbFeesValue";
            this.tbFeesValue.Size = new System.Drawing.Size(311, 24);
            this.tbFeesValue.TabIndex = 53;
            // 
            // tbTitleValue
            // 
            this.tbTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitleValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbTitleValue.Location = new System.Drawing.Point(343, 220);
            this.tbTitleValue.Name = "tbTitleValue";
            this.tbTitleValue.Size = new System.Drawing.Size(311, 24);
            this.tbTitleValue.TabIndex = 52;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(530, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 46);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(343, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTestFees
            // 
            this.lblTestFees.AutoSize = true;
            this.lblTestFees.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestFees.Location = new System.Drawing.Point(178, 458);
            this.lblTestFees.Name = "lblTestFees";
            this.lblTestFees.Size = new System.Drawing.Size(56, 24);
            this.lblTestFees.TabIndex = 59;
            this.lblTestFees.Text = "Fees";
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestTitle.Location = new System.Drawing.Point(178, 218);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(58, 24);
            this.lblTestTitle.TabIndex = 58;
            this.lblTestTitle.Text = "Title";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestID.Location = new System.Drawing.Point(178, 159);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(85, 24);
            this.lblTestID.TabIndex = 57;
            this.lblTestID.Text = "Test ID";
            // 
            // lblEditTestType
            // 
            this.lblEditTestType.AutoSize = true;
            this.lblEditTestType.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblEditTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditTestType.Location = new System.Drawing.Point(306, 43);
            this.lblEditTestType.Name = "lblEditTestType";
            this.lblEditTestType.Size = new System.Drawing.Size(327, 40);
            this.lblEditTestType.TabIndex = 56;
            this.lblEditTestType.Text = "Update Test Type";
            // 
            // errpEditTestHandler
            // 
            this.errpEditTestHandler.ContainerControl = this;
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestDescription.Location = new System.Drawing.Point(178, 282);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(129, 24);
            this.lblTestDescription.TabIndex = 62;
            this.lblTestDescription.Text = "Description";
            this.lblTestDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTestDescriptionValue
            // 
            this.tbTestDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTestDescriptionValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbTestDescriptionValue.Location = new System.Drawing.Point(343, 282);
            this.tbTestDescriptionValue.Multiline = true;
            this.tbTestDescriptionValue.Name = "tbTestDescriptionValue";
            this.tbTestDescriptionValue.Size = new System.Drawing.Size(311, 137);
            this.tbTestDescriptionValue.TabIndex = 61;
            // 
            // frmUpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 636);
            this.Controls.Add(this.lblTestTypeID);
            this.Controls.Add(this.tbFeesValue);
            this.Controls.Add(this.tbTitleValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTestFees);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.lblEditTestType);
            this.Controls.Add(this.lblTestDescription);
            this.Controls.Add(this.tbTestDescriptionValue);
            this.Name = "frmUpdateTestType";
            this.Text = "frmUpdateTestType";
            ((System.ComponentModel.ISupportInitialize)(this.errpEditTestHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.TextBox tbFeesValue;
        private System.Windows.Forms.TextBox tbTitleValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTestFees;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label lblEditTestType;
        private System.Windows.Forms.ErrorProvider errpEditTestHandler;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.TextBox tbTestDescriptionValue;
    }
}
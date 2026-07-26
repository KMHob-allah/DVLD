namespace DVLD.Applications
{
    partial class frmUpdateAppType
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
            this.lblTypeIDValue = new System.Windows.Forms.Label();
            this.tbFeesValue = new System.Windows.Forms.TextBox();
            this.tbTitleValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTypeFees = new System.Windows.Forms.Label();
            this.lblTypeTitle = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.lblEditApplicationType = new System.Windows.Forms.Label();
            this.errpEditTypeHandler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errpEditTypeHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTypeIDValue
            // 
            this.lblTypeIDValue.AutoSize = true;
            this.lblTypeIDValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeIDValue.Location = new System.Drawing.Point(335, 190);
            this.lblTypeIDValue.Name = "lblTypeIDValue";
            this.lblTypeIDValue.Size = new System.Drawing.Size(49, 24);
            this.lblTypeIDValue.TabIndex = 49;
            this.lblTypeIDValue.Text = "???";
            // 
            // tbFeesValue
            // 
            this.tbFeesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFeesValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbFeesValue.Location = new System.Drawing.Point(339, 310);
            this.tbFeesValue.Name = "tbFeesValue";
            this.tbFeesValue.Size = new System.Drawing.Size(311, 24);
            this.tbFeesValue.TabIndex = 42;
            this.tbFeesValue.TextChanged += new System.EventHandler(this.EditApplicationType_DataChanged);
            this.tbFeesValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFeesValue_KeyPress);
            this.tbFeesValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbFeesValue_Validating);
            // 
            // tbTitleValue
            // 
            this.tbTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitleValue.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.tbTitleValue.Location = new System.Drawing.Point(339, 251);
            this.tbTitleValue.Name = "tbTitleValue";
            this.tbTitleValue.Size = new System.Drawing.Size(311, 24);
            this.tbTitleValue.TabIndex = 41;
            this.tbTitleValue.TextChanged += new System.EventHandler(this.EditApplicationType_DataChanged);
            this.tbTitleValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleValue_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(517, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 46);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(339, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTypeFees
            // 
            this.lblTypeFees.AutoSize = true;
            this.lblTypeFees.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeFees.Location = new System.Drawing.Point(197, 308);
            this.lblTypeFees.Name = "lblTypeFees";
            this.lblTypeFees.Size = new System.Drawing.Size(56, 24);
            this.lblTypeFees.TabIndex = 48;
            this.lblTypeFees.Text = "Fees";
            // 
            // lblTypeTitle
            // 
            this.lblTypeTitle.AutoSize = true;
            this.lblTypeTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeTitle.Location = new System.Drawing.Point(197, 249);
            this.lblTypeTitle.Name = "lblTypeTitle";
            this.lblTypeTitle.Size = new System.Drawing.Size(58, 24);
            this.lblTypeTitle.TabIndex = 47;
            this.lblTypeTitle.Text = "Title";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(197, 190);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(90, 24);
            this.lblTypeID.TabIndex = 46;
            this.lblTypeID.Text = "Type ID";
            // 
            // lblEditApplicationType
            // 
            this.lblEditApplicationType.AutoSize = true;
            this.lblEditApplicationType.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold);
            this.lblEditApplicationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditApplicationType.Location = new System.Drawing.Point(218, 68);
            this.lblEditApplicationType.Name = "lblEditApplicationType";
            this.lblEditApplicationType.Size = new System.Drawing.Size(449, 40);
            this.lblEditApplicationType.TabIndex = 45;
            this.lblEditApplicationType.Text = "Update Application Type";
            // 
            // errpEditTypeHandler
            // 
            this.errpEditTypeHandler.ContainerControl = this;
            // 
            // frmUpdateAppType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 488);
            this.Controls.Add(this.lblTypeIDValue);
            this.Controls.Add(this.tbFeesValue);
            this.Controls.Add(this.tbTitleValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTypeFees);
            this.Controls.Add(this.lblTypeTitle);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.lblEditApplicationType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateAppType";
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmUpdateAppType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpEditTypeHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeIDValue;
        private System.Windows.Forms.TextBox tbFeesValue;
        private System.Windows.Forms.TextBox tbTitleValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTypeFees;
        private System.Windows.Forms.Label lblTypeTitle;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Label lblEditApplicationType;
        private System.Windows.Forms.ErrorProvider errpEditTypeHandler;
    }
}
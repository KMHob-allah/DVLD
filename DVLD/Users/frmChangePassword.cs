using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID;

        public frmChangePassword(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }


        private void _ResetDefaultValue()
        {
            tbCurrentPassword.Text = string.Empty;
            tbNewPasswordValue.Text = string.Empty;
            tbConfirmPasswordValue.Text = string.Empty;

            tbCurrentPassword.Focus();
        }
        private void PasswordFields_textChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) btnSave.Enabled = true;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            ctrlUserCard1.LoadUserInfo(_UserID);

            if(ctrlUserCard1.User == null)
            {
                MessageBox.Show("Could not find user with ID :" + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please Fix the Errors", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            if(ctrlUserCard1.User.ChangePassword(tbNewPasswordValue.Text.Trim()))
            {
                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }

            else MessageBox.Show("An error accured, Password was not changed", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string _UserPassword = tbCurrentPassword.Text.Trim();

            if(string.IsNullOrEmpty(_UserPassword))
            {
                errpChangePasswordHandler.SetError(tbCurrentPassword, "Current password connot be blanck");
                e.Cancel = true;
                return;
            }


            if (_UserPassword != ctrlUserCard1.User.Password.Trim())
            {
                errpChangePasswordHandler.SetError(tbCurrentPassword, "Current password is wrong");
                e.Cancel = true;
            }

            else errpChangePasswordHandler.SetError(tbCurrentPassword, "");
           
        }
        private void tbNewPasswordValue_Validating(object sender, CancelEventArgs e)
        {
            string _NewPassword = tbNewPasswordValue.Text.Trim();


            if (string.IsNullOrEmpty(_NewPassword))
            {
                errpChangePasswordHandler.SetError(tbNewPasswordValue, "New password connot be blanck");
                e.Cancel = true;
                return;
            }


            if (_NewPassword == ctrlUserCard1.User.Password)
            {
                errpChangePasswordHandler.SetError(tbNewPasswordValue, "New password musn't equal current password");
                e.Cancel = true;
            }

            else errpChangePasswordHandler.SetError(tbNewPasswordValue, "");

        }
        private void tbConfirmPasswordValue_Validating(object sender, CancelEventArgs e)
        {
            if ((tbConfirmPasswordValue.Text.Trim() != tbNewPasswordValue.Text.Trim()))
            {
                errpChangePasswordHandler.SetError(tbConfirmPasswordValue, "Confirm password must match new password");
                e.Cancel = true;
            }

            else errpChangePasswordHandler.SetError(tbConfirmPasswordValue, "");
        }      
           
    }
}

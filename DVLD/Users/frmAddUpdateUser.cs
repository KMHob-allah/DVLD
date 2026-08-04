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
    public partial class frmAddUpdateUser : Form
    {
        public event EventHandler UserDataSaved;
        enum eMode : byte { Add, Update }

        private eMode _Mode;

        private clUser _User;

        private int _UserID;

        public frmAddUpdateUser(int UserID)
        {
            _UserID = UserID;
            _Mode = eMode.Update;

            InitializeComponent();
        }
        public frmAddUpdateUser()
        {
            _UserID = -1;
            _Mode = eMode.Add;

            InitializeComponent();
        }

        private void _FillUserInfo()
        {
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;          
            _User.UserName = tbUserNameValue.Text.Trim();
            _User.Password = tbPasswordValue.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
        }
        private void _LoadUserDetails()
        {                   
            lblUserIDValue.Text = _User.UserID.ToString();
            tbUserNameValue.Text = _User.UserName;
            tbPasswordValue.Text = _User.Password;
            tbConfirmPasswordValue.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

        }
        private void _ResetDefaultValues()
        {
            btnSave.Enabled = false;
            btnNext.Enabled = false;

            switch (_Mode)
            {
                case eMode.Add:
                    {
                        lblAddUpdateUser.Text = "Add New User";

                        _User = new clUser();

                        tpLoginInfo.Enabled = false;                       

                        ctrlPersonCardWithFilter1.FilterFocus();

                        break;
                    }

                case eMode.Update:
                    {
                        lblAddUpdateUser.Text = "Update User";

                        _User = clUser.FindByUserID(_UserID);

                        if (_User == null)
                        {
                            MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();

                            return;
                        }

                        tpLoginInfo.Enabled = true;
                       
                        ctrlPersonCardWithFilter1.FilterEnabled = false;

                        break;
                    }
            }
        }


        private void UserLoginInfo_Changed(object sender, EventArgs e)
        {   
            if(!btnSave.Enabled) btnSave.Enabled = true;
        }

        private void ctrlPersonCardWithFilter1_WhenPersonSelected(int PersonID)
        {     
            if(!btnNext.Enabled) btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == eMode.Add)
            {
                if(ctrlPersonCardWithFilter1.PersonID != -1)
                { 
                    if (!clUser.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                    {
                        tpLoginInfo.Enabled = true;
                        btnSave.Enabled = true;
                        tcPersonInfoLoginInfo.SelectedIndex = 1; // Go to Login Info
                    }

                    else
                    {
                        MessageBox.Show("This person is already a user, Please choose another one", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        tpLoginInfo.Enabled = false;
                        ctrlPersonCardWithFilter1.FilterFocus();
                    }
                }

                else
                {
                    MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
            }

            else 
            { 
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
                tcPersonInfoLoginInfo.SelectedIndex = 1;
            }        
        }               
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {                
                MessageBox.Show("Login Information are not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();

            if(_User.Save())
            {
               if(_Mode == eMode.Add) 
                {                     
                    _UserID = _User.UserID;
                    lblUserIDValue.Text = _User.UserID.ToString();
                    _Mode = eMode.Update;
                    lblAddUpdateUser.Text = "Update User";
                }

                MessageBox.Show("User saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                UserDataSaved?.Invoke(this, EventArgs.Empty);

            }

            else MessageBox.Show("User was not saved successfully", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUserNameValue_Validating_1(object sender, CancelEventArgs e)
        {
            string _UserName = tbUserNameValue.Text.Trim();

            if (string.IsNullOrEmpty(_UserName))
            {
                errpLoginInfoHandler.SetError(tbUserNameValue, "This field cannot be blanck");
                e.Cancel = true;
                return;
            }

            bool IsDuplicateInAddMode = (_Mode == eMode.Add && clUser.IsExistByUserName(_UserName));
            bool IsDuplicateInUpdateMode = (_Mode != eMode.Add && _UserName != _User.UserName && clUser.IsExistByUserName(_UserName));

            if (IsDuplicateInAddMode || IsDuplicateInUpdateMode)
            {
                errpLoginInfoHandler.SetError(tbUserNameValue, "User name is used by another person, Please choose another one");
                e.Cancel = true;            
            }

            else
            {
                errpLoginInfoHandler.SetError(tbUserNameValue, "");
            }                
        }
        private void tbPasswordValue_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPasswordValue.Text.Trim()))
            {
                errpLoginInfoHandler.SetError(tbPasswordValue, "Password connot be blanck");
                e.Cancel = true;
            }

            else errpLoginInfoHandler.SetError(tbPasswordValue, "");            

        }
        private void tbConfirmPasswordValue_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbConfirmPasswordValue.Text.Trim() != tbPasswordValue.Text.Trim())
            {
                errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "Confirm password must match password");
                e.Cancel = true;               
            }
            else errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "");

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == eMode.Update) _LoadUserDetails();                               
        }

        private void tcPersonInfoLoginInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpLoginInfo
                &&
                ctrlPersonCardWithFilter1.PersonID != -1
                &&
                !clUser.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
            }

        }
    }
}

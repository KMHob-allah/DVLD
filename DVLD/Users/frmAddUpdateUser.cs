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
        enum eMode { Add, Update }

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

        private void _EnableLoginInfo(bool Enable)
        {
            tbUserNameValue.Enabled = Enable;
            tbPasswordValue.Enabled = Enable;
            tbConfirmPasswordValue.Enabled = Enable;
            chkIsActive.Enabled = Enable;
        }      
        private void _FillUserInfo()
        {
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;          
            _User.UserName = tbUserNameValue.Text;
            _User.Password = tbPasswordValue.Text;
            _User.IsActive = chkIsActive.Checked;
        }
        private void _LoadUserDetails()
        {                   
            lblUserIDValue.Text = _User.UserID.ToString();
            tbUserNameValue.Text = _User.UserName;
            tbPasswordValue.Text = _User.Password;
            tbConfirmPasswordValue.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            
        }

        private void ctrlPersonCardWithFilter1_WhenPersonSelected(int PersonID)
        {
            _EnableLoginInfo(true);

            btnNext.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == eMode.Add)
            {
                if (!clUser.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    _EnableLoginInfo(true);
                    tcPersonInfoLoginInfo.SelectedIndex = 1; // Go to Login Info
                }

                else
                {
                    MessageBox.Show("This person is already a user, Please choose another one", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _EnableLoginInfo(false);
                }
            }
            else tcPersonInfoLoginInfo.SelectedIndex = 1;            
        }               
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {                
                MessageBox.Show("Please fix the errors first", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
               
                UserDataSaved?.Invoke(this, EventArgs.Empty);

            }

            else MessageBox.Show("User was not saved successfully", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcPersonInfoLoginInfo_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpLoginInfo
                && 
                ctrlPersonCardWithFilter1.PersonID != -1 
                && 
                clUser.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID)) _EnableLoginInfo(false);                              
        }
        private void tbPasswordValue_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbPasswordValue.Enabled && string.IsNullOrEmpty(tbPasswordValue.Text.Trim()))
            {
                errpLoginInfoHandler.SetError(tbPasswordValue, "Password connot be blanck");
                //e.Cancel = true;
            }

            else errpLoginInfoHandler.SetError(tbPasswordValue, "");            

        }
        private void tbUserNameValue_Validating_1(object sender, CancelEventArgs e)
        {
            if(tbUserNameValue.Enabled && !string.IsNullOrEmpty(tbUserNameValue.Text.Trim()))
            {
                if (clUser.IsExistByUserName(tbUserNameValue.Text.Trim()))
                {
                    errpLoginInfoHandler.SetError(tbUserNameValue, "User name is used by another person, Please choose another one");
                    //e.Cancel = true;
                }

                else errpLoginInfoHandler.SetError(tbUserNameValue, "");
            }
            else errpLoginInfoHandler.SetError(tbUserNameValue, "This field cannot be blanck");


        }
        private void tbConfirmPasswordValue_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbConfirmPasswordValue.Enabled && tbConfirmPasswordValue.Text.Trim() != tbPasswordValue.Text.Trim())
            {
                errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "Confirm password must match password");
                //e.Cancel = true;               
            }
            else errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "");

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            switch(_Mode)
            {
                case eMode.Add:
                {
                    _User = new clUser();
                    lblAddUpdateUser.Text = "Add New User";
                    break;
                }

                case eMode.Update:
                {
                    _User = clUser.FindByUserID(_UserID);

                    lblAddUpdateUser.Text = "Update User";
                    ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

                    ctrlPersonCardWithFilter1.ShowAddPerson = false;
                    ctrlPersonCardWithFilter1.FilterEnabled = false;

                    _LoadUserDetails();
                    break;
                }

            }           
        }               
    }
}

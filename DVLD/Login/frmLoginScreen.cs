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

namespace DVLD.GlobalSettings
{
    public partial class frmLoginScreen : Form
    {
        enum eLoginResult : byte { Success, InvalidUserNameOrPassword, NotActive }

        clUser _CurrentUser;

        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void _LoadCurrentUserToSystem()
        {
            if(chkRememberMe.Checked) clGlobalSettings.RememberUsernameAndPassword(_CurrentUser.UserName, _CurrentUser.Password);            

            else clGlobalSettings.RememberUsernameAndPassword(string.Empty, string.Empty);

            clGlobalSettings.CurrentUser = _CurrentUser;
        }
        private void _SetDefaultValues()
        {
            tbPassword.Text = string.Empty;
            tbUserName.Text = string.Empty;

            chkRememberMe.Checked = false;
        }
        private eLoginResult _Login()
        {
            _CurrentUser = clUser.FindByUserNameAndPassword(tbUserName.Text.Trim(), tbPassword.Text.Trim());

            if (_CurrentUser == null) return eLoginResult.InvalidUserNameOrPassword;

            // Will Continue If User Was Founded

            if (_CurrentUser.IsActive) return eLoginResult.Success;

            else return eLoginResult.NotActive;    
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            if (!this.ValidateChildren())
            {   
                // Triggered When Impty Fields
                MessageBox.Show("Fields Are Required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            
            switch(_Login())
            {

                case eLoginResult.Success:
                {
                    _LoadCurrentUserToSystem();

                    this.Hide();

                    frmMain frm = new frmMain(this);

                    frm.ShowDialog();

                    break;
                }

                case eLoginResult.InvalidUserNameOrPassword:
                {
                    MessageBox.Show("Invalid user name or password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                case eLoginResult.NotActive:
                {
                    MessageBox.Show("This user is not active, Please contact with your admin", 
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }          
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                errpLoginHandler.SetError(tbUserName, "User Name Is Required");
                e.Cancel = true;
            }           

            else errpLoginHandler.SetError(tbUserName, "");        
        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                errpLoginHandler.SetError(tbPassword, "Password Is Required");
                e.Cancel = true;
            }

            else errpLoginHandler.SetError(tbPassword, "");
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string UserName = string.Empty, Password = string.Empty;

            if (clGlobalSettings.GetStoredCredential(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                _SetDefaultValues();
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmLoginScreen_Shown(object sender, EventArgs e)
        {

        }
    }
}

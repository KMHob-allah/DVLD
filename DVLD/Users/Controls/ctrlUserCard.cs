using DVLD.Properties;
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

namespace DVLD.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID;
        private clUser _User;

        public int UserID 
        {
            get { return this._UserID; }
        }
        public clUser User 
        {            
            get { return _User; } 
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void ResetUserInfo()
        {
            _UserID = -1;

            lblUserIDVal.Text = "???";
            lblUserNameVal.Text = "???";
            lblIsActiveVal.Text = "???";

        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            
            _UserID = _User.UserID;
            lblUserIDVal.Text = _User.UserID.ToString();
            lblUserNameVal.Text = _User.Person.FullName();
            lblIsActiveVal.Text =( _User.IsActive ? "Yes":"No");             
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clUser.FindByUserID(UserID);

            if(_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User with PersonID : " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
            _UserID = UserID;
        }
    }
}

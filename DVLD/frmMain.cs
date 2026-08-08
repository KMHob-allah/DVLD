using DVLD.Applications.ApplicationTypes;
using DVLD.Applications.LocalApplications;
using DVLD.GlobalSettings;
using DVLD.Licenses.LocalLicenses;
using DVLD.People;
using DVLD.Tests.TestTypes;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        private frmLoginScreen _LoginScreen;

        public frmMain(frmLoginScreen LoginScreen)
        {
            InitializeComponent();
            _LoginScreen = LoginScreen;
        }

        private void opPeople_Click(object sender, EventArgs e)
        {
            frmPeopleManagement frm = new frmPeopleManagement();
            frm.ShowDialog();
        }
        private void opUsers_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }
        private void opCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clGlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void opChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clGlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void opSignOut_Click(object sender, EventArgs e)
        {
            clGlobalSettings.CurrentUser = null;
            // Must Refresh UserName And Password When User Change His Password 
            _LoginScreen.Show();
            this.Close();

        }
        private void opManageAppTypes_Click(object sender, EventArgs e)
        {
            frmAppTypesList frm = new frmAppTypesList();
            frm.ShowDialog();
        }
        private void opManageTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypesList frm = new frmTestTypesList();

            frm.ShowDialog();
        }
        private void opLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalApp frm = new frmAddUpdateLocalApp();

            frm.ShowDialog();
        }
        private void opLocalApps_Click(object sender, EventArgs e)
        {
            frmLocalAppsList frm = new frmLocalAppsList();
            frm.ShowDialog();
        }

        private void opRetakeTest_Click(object sender, EventArgs e)
        {
            frmLocalAppsList frm = new frmLocalAppsList();
            frm.ShowDialog();
        }

        private void opRenewDrivingLicense_Click(object sender, EventArgs e)
        {          
        }
    }
}

using DVLD.GlobalSettings;
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

namespace DVLD.Licenses
{
    public partial class frmIssueLocalDrivingLicense : Form
    {
        public event EventHandler LicenseIssued;

        clLicense License;
        clDriver NewDriver;

        int LocalAppID;

        public frmIssueLocalDrivingLicense(int LocalAppID)
        {
            this.LocalAppID = LocalAppID;
            InitializeComponent();           
        }
       
        private void btnIssue_Click(object sender, EventArgs e)
        {          
            int LicenseID = ctrlLocalAppCard1.LocalAppInfo.IssueLicenseForTheFirstTime(tbNotesValue.Text.Trim(), clGlobalSettings.CurrentUser.UserID);
          
            if (LicenseID == -1)
            {
                MessageBox.Show("License Was not Issued ! ",
                  "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
          

            MessageBox.Show($"License Issued With ID : {LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LicenseIssued?.Invoke(null, null);
            this.Close();  
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            clLocalApplication _LocalApp = clLocalApplication.FindByLocalAppID(LocalAppID);

            if (_LocalApp == null)
            {

                MessageBox.Show("No Applicaiton with ID=" + ctrlLocalAppCard1.LocalAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (!_LocalApp.PassedAllTests())
            {

                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            int LicenseID = _LocalApp.GetActiveLicenseIDByPersonID();

            if (LicenseID != -1)
            {

                MessageBox.Show("Person already has License before with License ID =" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            ctrlLocalAppCard1.LoadLocalAppInfo(_LocalApp.LocalApplicationID);
        }
    }
}

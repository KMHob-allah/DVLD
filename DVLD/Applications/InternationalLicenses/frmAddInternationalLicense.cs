using DVLD.Global;
using DVLD.GlobalSettings;
using DVLD.Licenses;
using DVLD.Licenses.InternationalLicenses;
using DVLD.Licenses.LocalLicenses;
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

namespace DVLD.Applications.InternationalLicenses
{
    public partial class frmAddInternationalLicense : Form
    {
        clInternationalLicense InternationalLicense;
        int InternationalLicenseID = -1;

        public frmAddInternationalLicense()
        {
            InitializeComponent();
        }
        public frmAddInternationalLicense(int LicenseID)
        {
            InitializeComponent();
            ctrlLicenseCardWithFilter1.LoadLicenseInfo(LicenseID);
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
        }              

        private void _SetApplicationInfoDefaultValues()
        {

            lblInternationalAppIDValue.Text = "???";
            lblAppDateValue.Text = "???";
            lblIssueDateValue.Text = "???";
            lblAppFeesValue.Text = "???";
            lblInternationalLicenseIDValue.Text = "???";
            lblLocalLicenseIDValue.Text = "???";
            lblExpirationDateValue.Text = "???";
            lblCreatedByUserNameValue.Text = "???";
        }
              
        private void lnklblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlLicenseCardWithFilter1.Licenseinfo.DriverInfo.PersonInfo.PersonID);
            frm.Show();
        }
        private void lnklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseCard frm = new frmInternationalLicenseCard(InternationalLicenseID);
            frm.Show();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue International License?",
               "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }


            if ( ctrlLicenseCardWithFilter1.Licenseinfo.LicenseClassInfo.LicenseClassID  != 3)
            {
                MessageBox.Show("Selected license Should be class 3", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                return;
            }

          
            clApplication App = new clApplication();

            App.ApplicantPersonID = ctrlLicenseCardWithFilter1.Licenseinfo.ApplicationInfo.ApplicantPersonID;
            App.ApplicationDate = DateTime.Now;
            App.ApplicationStatus = clApplication.eApplicationStatus.Completed;
            App.ApplicationType = clApplicationType.eApplicationType.NewInternationalLicense;
            App.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;
            App.LastStatusDate = DateTime.Now;
            App.PaidFees = clLicenseClass.Find(3).ClassFees; // Business Rule            

           if(!App.Save())
            {                
                MessageBox.Show($"Could Not Issue International License, Some Issues Happened", "Connot Detain",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                return;

            }

            InternationalLicense = new clInternationalLicense();

            InternationalLicense.ApplicationID = App.ApplicationID;
            InternationalLicense.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;
            InternationalLicense.DriverID = ctrlLicenseCardWithFilter1.Licenseinfo.DriverID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicense.IsActive = true;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID;

            if(!InternationalLicense.Save())
            {
                MessageBox.Show($"Could Not Issue International License, Some Issues Happened", "Connot Detain",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
            }

            MessageBox.Show($"International License Issued Successfully",
            "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InternationalLicenseID = InternationalLicense.InternationalLicenseID;

            lblInternationalAppIDValue.Text = App.ApplicationID.ToString();
            lblInternationalLicenseIDValue.Text = InternationalLicense.InternationalLicenseID.ToString();

            btnIssue.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            lnklblShowLicenseInfo.Enabled = true;
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddInternationalLicense_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            lnklblShowLicensesHistory.Enabled = false;
            lnklblShowLicenseInfo.Enabled = false;
        }
        private void ctrlLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            if (LicenseID == -1)
            {
                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = false;
                _SetApplicationInfoDefaultValues();
                return;

            }



            if (ctrlLicenseCardWithFilter1.Licenseinfo.IsExpired())
            {
                MessageBox.Show($"Selected License Is Expired", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetApplicationInfoDefaultValues();
                return;
            }

            if (!ctrlLicenseCardWithFilter1.Licenseinfo.IsActive)
            {
                MessageBox.Show($"Could not Issue International License From a Deactivated License", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetApplicationInfoDefaultValues();
                return;
            }

            if (ctrlLicenseCardWithFilter1.Licenseinfo.IsDetained())
            {
                MessageBox.Show($"Could not Issue International License From a Detained License", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetApplicationInfoDefaultValues();
                return;
            }

             InternationalLicenseID = ctrlLicenseCardWithFilter1.Licenseinfo.GetActiveInternationalLicenseID();

            if(InternationalLicenseID != -1)
            {
                MessageBox.Show($"Person already have an active international license with ID : {InternationalLicenseID}", "Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbApplicationInfo.Enabled = false;
                btnIssue.Enabled = false;
                lnklblShowLicenseInfo.Enabled = true;
                lnklblShowLicensesHistory.Enabled = true;
                _SetApplicationInfoDefaultValues();
                return;
            }

            gbApplicationInfo.Enabled = true;

            lblInternationalAppIDValue.Text = "???";
            lblAppDateValue.Text = clFormat.DateToShort(DateTime.Now).ToString();

            lblIssueDateValue.Text = clFormat.DateToShort(DateTime.Now).ToString();
            lblAppFeesValue.Text = clApplicationType.Find(clApplicationType.eApplicationType.NewInternationalLicense).Fees.ToString();

            lblInternationalLicenseIDValue.Text = "???";
            lblLocalLicenseIDValue.Text = ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID.ToString();
            lblCreatedByUserName.Text = clGlobalSettings.CurrentUser.UserName;
            lblExpirationDateValue.Text = DateTime.Now.AddYears(ctrlLicenseCardWithFilter1.Licenseinfo.LicenseClassInfo.DefaultValidityLength).ToString();
            lblCreatedByUserNameValue.Text = clGlobalSettings.CurrentUser.UserName;

            btnIssue.Enabled = true;
            lnklblShowLicenseInfo.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
        }
    }
}

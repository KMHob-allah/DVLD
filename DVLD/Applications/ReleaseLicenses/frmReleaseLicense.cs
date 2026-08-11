using DVLD.Global;
using DVLD.GlobalSettings;
using DVLD.Licenses;
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

namespace DVLD.Applications.ReleaseLicenses
{
    public partial class frmReleaseLicense : Form
    {
        clDetainLicense DetainedLicense;

        public frmReleaseLicense()
        {
            InitializeComponent();
        }
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();

            ctrlLicenseCardWithFilter1.LoadLicenseInfo(LicenseID);
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
        }


        private void _SetDetainInfoDefaultValues()
        {

            lblDetainIDValue.Text = "???";
            lblDetainDateValue.Text = "???";
            lblAppFeesValue.Text = "???";
            lblTotalFeesValue.Text = "???";
            lblLicenseIDValue.Text = "???";
            lblCreatedByUserName.Text = "???";
            lblFineFeesValue.Text = "???";
            lblAppIDValue.Text = "???";
        }                  

        private void lnklblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(ctrlLicenseCardWithFilter1.Licenseinfo.DriverInfo.PersonInfo.PersonID);
            frm.Show();
        }
        private void lnklblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID);
            frm.Show();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release the license?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;
             
           
           

            if (!ctrlLicenseCardWithFilter1.Licenseinfo.Release(clGlobalSettings.CurrentUser.UserID, ref ApplicationID))
            {

                MessageBox.Show($"Could Not Release License, Some Issues Happened", "Connot Detain",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnRelease.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                return;

            }
            

            MessageBox.Show($"License Released Successfully",
            "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ctrlLicenseCardWithFilter1.LoadLicenseInfo(ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID);

            lblAppIDValue.Text = ApplicationID.ToString();

            btnRelease.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            lnklblLicenseInfo.Enabled = true;
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            btnRelease.Enabled = false;
            lnklblShowLicensesHistory.Enabled = false;
            lnklblLicenseInfo.Enabled = false;
        }
        private void ctrlLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            if (LicenseID == -1)
            {
                gbDetainInfo.Enabled = false;
                btnRelease.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = false;
                _SetDetainInfoDefaultValues();
                return;

            }

         

            if (ctrlLicenseCardWithFilter1.Licenseinfo.IsExpired())
            {
                MessageBox.Show($"Selected License Is Expired", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnRelease.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainInfoDefaultValues();
                return;
            }

            if (!ctrlLicenseCardWithFilter1.Licenseinfo.IsActive)
            {
                MessageBox.Show($"Could not Release Deactivated License", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnRelease.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainInfoDefaultValues();
                return;
            }

            if (!ctrlLicenseCardWithFilter1.Licenseinfo.IsDetained())
            {
                MessageBox.Show($"This license is not detained to release", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnRelease.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainInfoDefaultValues();
                return;
            }

            gbDetainInfo.Enabled = true;

            DetainedLicense = clDetainLicense.FindByLicenseID(ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID);

            lblDetainIDValue.Text = DetainedLicense.ID.ToString();
            lblDetainDateValue.Text = DetainedLicense.DetainDate.ToString();
            lblAppFeesValue.Text = clApplicationType.Find(clApplicationType.eApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            lblLicenseIDValue.Text = ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID.ToString();
            lblCreatedByUserName.Text = clGlobalSettings.CurrentUser.UserName;
            lblFineFeesValue.Text = DetainedLicense.FineFees.ToString();
            lblTotalFeesValue.Text = (Convert.ToSingle(lblAppFeesValue.Text) + Convert.ToSingle(lblFineFeesValue.Text)).ToString();


            btnRelease.Enabled = true;
            lnklblLicenseInfo.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
        }
    }
}

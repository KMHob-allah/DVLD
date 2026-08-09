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

namespace DVLD.Applications.LostOrDamagedLicenseApplications
{
    public partial class frmLostOrDamagedLicenseApplications : Form
    {
       
        clLicense _OldLicense;
        clLicense _NewLicense;

        public frmLostOrDamagedLicenseApplications()
        {
            InitializeComponent();
        }

        private void _SetNewAppDefaultValues()
        {

            lblRenewicenseAppIDValue.Text = "???";
            lblAppDateValue.Text = "???";
            lblAppFeesValue.Text = "???";                     
            lblReplacedLicenseIDValue.Text = "???";
            lblOldLicenseIDValue.Text = "???";
            lblCreatedByUserName.Text = "???";
        }
        private float _CalculateAppFees()
        {
            return (rdbtnDamagedLicense.Checked
                ? clApplicationType.Find(clApplicationType.eApplicationType.ReplacementforDamagedDrivingLicense).Fees :
                  clApplicationType.Find(clApplicationType.eApplicationType.ReplacementforLostDrivingLicense).Fees);
        }
        private clLicense.eIssueReason _GetIssueReason()
        {
            return (rdbtnDamagedLicense.Checked ? clLicense.eIssueReason.ReplacementForDamaged : clLicense.eIssueReason.ReplacementForLost);
        }

        private void frmLostOrDamagedLicenseApplications_Load(object sender, EventArgs e)
        {
            btnIssueReplacement.Enabled = false;
            lnklblShowLicensesHistory.Enabled = false;
            lnklblShowNewLicenseInfo.Enabled = false;

            rdbtnDamagedLicense.Checked = true;
        }
             
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue a Replacement for the license?",
               "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            _NewLicense = _OldLicense.Replace(_GetIssueReason(), clGlobalSettings.CurrentUser.UserID);

            if (_NewLicense == null)
            {
                MessageBox.Show($"Could Not Isseu a Replacement For this License, Some Issues Happened", "Connot Issue",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbAppInfoForLicenseReplacement.Enabled = false;
                gbReplacementOptions.Enabled = false;
                btnIssueReplacement.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                return;
            }


            MessageBox.Show($"License Replaced Successfully With ID : {_NewLicense.LicenseID}",
            "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblRenewicenseAppIDValue.Text = _NewLicense.ApplicationID.ToString();

            lblReplacedLicenseIDValue.Text = _NewLicense.LicenseID.ToString();


            btnIssueReplacement.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            lnklblShowNewLicenseInfo.Enabled = true;
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
            gbReplacementOptions.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lnklblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicense.LicenseID);
            frm.Show();
        }
        private void lnklblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlLicenseCardWithFilter1.Licenseinfo.DriverInfo.PersonInfo.PersonID);
            frm.Show();
        }

        private void ctrlLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            if (LicenseID == -1)
            {
                gbAppInfoForLicenseReplacement.Enabled = false;
                gbReplacementOptions.Enabled = false;
                btnIssueReplacement.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = false;
                _SetNewAppDefaultValues();
                return;

            }

            _OldLicense = ctrlLicenseCardWithFilter1.Licenseinfo;

            if (!_OldLicense.IsActive)
            {
                MessageBox.Show($"Selected License Is Not Active", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbReplacementOptions.Enabled = false;
                gbAppInfoForLicenseReplacement.Enabled = false;
                btnIssueReplacement.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetNewAppDefaultValues();
                return;
            }

          

            gbAppInfoForLicenseReplacement.Enabled = true;
            gbReplacementOptions.Enabled = true;

            lblRenewicenseAppIDValue.Text = "???";
            lblAppDateValue.Text = clFormat.DateToShort(DateTime.Now);
            lblAppFeesValue.Text = _CalculateAppFees().ToString();
            lblReplacedLicenseIDValue.Text = "???";
            lblOldLicenseIDValue.Text = _OldLicense.LicenseID.ToString();
            lblCreatedByUserNameValue.Text = clGlobalSettings.CurrentUser.UserName.ToString();

         
            btnIssueReplacement.Enabled = true;
            lnklblShowNewLicenseInfo.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
        }

        private void rdbtnLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnLostLicense.Checked)
            {
                this.Text = "Replacement For Lost License";
                lblHeader.Text = "Replacement For Lost License";

                lblAppFeesValue.Text = _CalculateAppFees().ToString();
            }
        }
        private void rdbtnDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDamagedLicense.Checked)
            {
                this.Text = "Replacement For Damaged License";
                lblHeader.Text = "Replacement For Damaged License";

                lblAppFeesValue.Text = _CalculateAppFees().ToString();
            }
        }
    }
}

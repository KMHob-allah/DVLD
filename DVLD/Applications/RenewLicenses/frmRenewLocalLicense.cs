using DVLD.Global;
using DVLD.GlobalSettings;
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

namespace DVLD.Licenses.RenewLicenses
{
    public partial class frmRenewLocalLicense : Form
    {

        clLicense _OldLicense;
        clLicense _NewLicense;
      
        public frmRenewLocalLicense()
        {
            InitializeComponent();

        }        
       

        private void _SetNewAppDefaultValues()
        {

            lblRenewicenseAppIDValue.Text = "???";
            lblAppDateValue.Text = "???";
            lblIssueDateValue.Text = "???";
            lblAppFeesValue.Text = "???";
            lblLicenseFeesValue.Text = "???";
            lblNotes.Text = string.Empty;
            lblRenewedLicenseIDValue.Text = "???";
            lblOldLicenseIDValue.Text = "???";
            lblExpirationDateValue.Text = "???";
            lblCreatedByUserName.Text = "???";
            lblTotalFees.Text = "???";
        }            

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew the license?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            _NewLicense = _OldLicense.Renew(_OldLicense.Notes, clGlobalSettings.CurrentUser.UserID);

            if (_NewLicense == null)
            {
                MessageBox.Show($"Could Not Renew License, Some Issues Happened", "Connot Issue",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbNewLicenseInfoApp.Enabled = false;
                btnRenew.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                return;
            }


            MessageBox.Show($"License Renewed Successfully With ID : {_NewLicense.LicenseID}",
            "License Renewed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblRenewicenseAppIDValue.Text = _NewLicense.ApplicationID.ToString();
           
            lblRenewedLicenseIDValue.Text = _NewLicense.LicenseID.ToString();
            

            btnRenew.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            lnklblShowNewLicenseInfo.Enabled = true;
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
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

        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            lnklblShowLicensesHistory.Enabled = false;
            lnklblShowNewLicenseInfo.Enabled = false;
        }

        private void ctrlLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            if (LicenseID == -1)
            {
                gbNewLicenseInfoApp.Enabled = false;
                btnRenew.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = false;
                _SetNewAppDefaultValues();
                return;

            }

            _OldLicense = ctrlLicenseCardWithFilter1.Licenseinfo;

            if (_OldLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"Selected License Is Not Expired Yet, It Will Expire on {_OldLicense.ExpirationDate}", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbNewLicenseInfoApp.Enabled = false;
                btnRenew.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetNewAppDefaultValues();
                return;
            }

            if (!_OldLicense.IsActive)
            {
                MessageBox.Show($"Could not Renew Deactivated License", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbNewLicenseInfoApp.Enabled = false;
                btnRenew.Enabled = false;
                lnklblShowNewLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetNewAppDefaultValues();
                return;
            }

            gbNewLicenseInfoApp.Enabled = true;

            lblRenewicenseAppIDValue.Text = "???";

            lblAppDateValue.Text = clFormat.DateToShort(DateTime.Now);
            lblIssueDateValue.Text = clFormat.DateToShort(DateTime.Now);
            lblAppFeesValue.Text = clApplicationType.Find(clApplicationType.eApplicationType.RenewDrivingLicenseService).Fees.ToString();
            lblLicenseFeesValue.Text = clLicenseClass.Find(_OldLicense.LicenseClassID).ClassFees.ToString();
            lblNotes.Text = _OldLicense.Notes;
            lblRenewedLicenseIDValue.Text = "???";
            lblOldLicenseIDValue.Text = _OldLicense.LicenseID.ToString();
            lblExpirationDateValue.Text = clFormat.DateToShort(DateTime.Now.AddYears(clLicenseClass.Find(_OldLicense.LicenseClassID).DefaultValidityLength));
            lblCreatedByUserNameValue.Text = clGlobalSettings.CurrentUser.UserID.ToString();
            lblTotalFeesValue.Text = (Convert.ToSingle(lblAppFeesValue.Text) + Convert.ToSingle(lblLicenseFeesValue.Text)).ToString();

            btnRenew.Enabled = true;
            lnklblShowNewLicenseInfo.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            
        }
    }
}

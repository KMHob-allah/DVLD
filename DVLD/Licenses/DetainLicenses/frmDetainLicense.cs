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

namespace DVLD.Licenses.DetainLicenses
{
    public partial class frmDetainLicense : Form
    {
        clLicense License;
        public frmDetainLicense()
        {
            InitializeComponent();
        }      

        private void _SetDetainLicenseDefaultValues()
        {

            lblDetainIDValue.Text = "???";
            lblDetainDateValue.Text = "???";
            tbFineFees.Text = string.Empty;
            lblLicenseIDValue.Text = "???";
            lblCreatedByUserName.Text = "???";            
        }
      
        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Det the license?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if(!this.ValidateChildren())
            {
                MessageBox.Show("You did not type Fine Fees",
                 "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int DetainID = License.Detain(Convert.ToSingle(tbFineFees.Text.Trim()), clGlobalSettings.CurrentUser.UserID);

           if (DetainID == -1)
            {
                
                MessageBox.Show($"Could Not Detain License, Some Issues Happened", "Connot Detain",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnDetain.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                return;
                
            }

            clDetainLicense DetainedLicense = clDetainLicense.Find(DetainID);

            MessageBox.Show($"License Detained Successfully With ID : {DetainedLicense.ID}",
            "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblDetainIDValue.Text = DetainedLicense.ID.ToString();

            btnDetain.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            lnklblLicenseInfo.Enabled = true;
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
            tbFineFees.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(License.LicenseID);
            frm.Show();
        }
        private void lnklblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(ctrlLicenseCardWithFilter1.Licenseinfo.DriverInfo.PersonInfo.PersonID);
            frm.Show();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
            lnklblShowLicensesHistory.Enabled = false;
            lnklblLicenseInfo.Enabled = false;
            tbFineFees.Enabled = false;
        }
        private void ctrlLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            if (LicenseID == -1)
            {
                gbDetainInfo.Enabled = false;
                btnDetain.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = false;
                _SetDetainLicenseDefaultValues();
                return;

            }

            License = ctrlLicenseCardWithFilter1.Licenseinfo;
            
            if (License.IsExpired())
            {
                MessageBox.Show($"Selected License Is Expired", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnDetain.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainLicenseDefaultValues();
                return;
            }

            if (!License.IsActive)
            {
                MessageBox.Show($"Could not Detain Deactivated License", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnDetain.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainLicenseDefaultValues();
                return;
            }

            if(License.IsDetained())
            {
                MessageBox.Show($"This license is already detained", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                gbDetainInfo.Enabled = false;
                btnDetain.Enabled = false;
                lnklblLicenseInfo.Enabled = false;
                lnklblShowLicensesHistory.Enabled = true;
                _SetDetainLicenseDefaultValues();
                return;
            }

            gbDetainInfo.Enabled = true;

            lblDetainIDValue.Text = "???";
            lblDetainDateValue.Text = clFormat.DateToShort(DateTime.Now);
            lblLicenseIDValue.Text = ctrlLicenseCardWithFilter1.Licenseinfo.LicenseID.ToString();
            lblCreatedByUserName.Text = clGlobalSettings.CurrentUser.UserID.ToString();

            btnDetain.Enabled = true;
            lnklblLicenseInfo.Enabled = false;
            lnklblShowLicensesHistory.Enabled = true;
            tbFineFees.Enabled = true;
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFineFees.Text)) 
            {
                errpFeesHandler.SetError(tbFineFees, "This field is required");
             e.Cancel = true;
            }
            
            else {errpFeesHandler.SetError(tbFineFees, "");
                e.Cancel = false;
            }
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

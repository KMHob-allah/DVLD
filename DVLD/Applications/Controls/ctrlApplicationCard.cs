using DVLD.People;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Controls
{
    public partial class ctrlApplicationCard : UserControl
    {
        private clApplication _Application;
        private int _ApplicationID;

        public clApplication ApplicationInfo
        {
            get { return _Application; }
        }
        
        public ctrlApplicationCard()
        {
            InitializeComponent();
        }

        public void SetDefaultValues()
        {
           
            lblAppIDValue.Text = "???";
            lblStatusValue.Text = "???";
            lblFeesValue.Text = "???";
            lblTypeValue.Text = "???";
            lblApplicantValue.Text = "???";
            lblDateValue.Text = "???";
            lblStatusDateValue.Text = "???";
            lblCreatedByValue.Text = "???";

            lnklblViewPersonInfo.Enabled = false;
        }
        private void _FillAppInfo()
        {          
            lblAppIDValue.Text = _Application.ApplicationID.ToString();
            lblStatusValue.Text = _Application.ApplicationStatus.ToString();
            lblFeesValue.Text = _Application.PaidFees.ToString();
            lblTypeValue.Text = _Application.ApplicationType.ToString();
            lblApplicantValue.Text = _Application.PersonInfo.FullName();
            lblDateValue.Text = _Application.ApplicationDate.ToString();
            lblStatusDateValue.Text = _Application.LastStatusDate.ToString();
            lblCreatedByValue.Text = _Application.UserInfo.UserName;

            lnklblViewPersonInfo.Enabled = true;
        }
        public void LoadApplicationInfo(int ApplicationID)
        {
            _ApplicationID = ApplicationID;

            _Application = clApplication.Find(ApplicationID);

            if (_Application == null)
            {
                SetDefaultValues();
                MessageBox.Show("No Application  with ID : " + _ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillAppInfo();
        }      

        private void lnklblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)        
        {
            frmPersonInfo frm = new frmPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();

        }
    }
}

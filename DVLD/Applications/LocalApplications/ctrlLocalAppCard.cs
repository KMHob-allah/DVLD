using DVLD.Applications.Controls;
using DVLD.People;
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

namespace DVLD.Applications.LocalApplications
{
    public partial class ctrlLocalAppCard : UserControl
    {
        public event EventHandler LocalApplicationInfoChanged;

        private clLocalApplication _LocalApp;
        private int _LocalAppID;


        public clLocalApplication LocalAppInfo
        {
            get{return _LocalApp;}
        }
        public int LocalAppID
        {
            get{return _LocalAppID;}
        }

        public ctrlLocalAppCard()
        {
            InitializeComponent();
            ctrlApplicationCard1.ApplicationInfoChanged += WhenApplicationInfoChanged;
        }       

        public void _SetDefaultValues()
        {
            lblDrivingLicenseAppIDValue.Text = "???";
            lblLicenseClassValue.Text ="???";
            lblPassedTestsValue.Text = "???";

            ctrlApplicationCard1.SetDefaultValues();
        }
        private void _FillLocalAppInfo()
       {

            lblDrivingLicenseAppIDValue.Text = _LocalApp.LocalApplicationID.ToString();
            lblLicenseClassValue.Text = _LocalApp.LicenseClassInfo.ClassName;
            lblPassedTestsValue.Text = "0/3"; // Fixed Untill I Continue 

            ctrlApplicationCard1.LoadApplicationInfo(_LocalApp.ApplicationID);

       }
        public void LoadLocalAppInfo(int LocalAppID)
        {
            _LocalAppID = LocalAppID;

            _LocalApp = clLocalApplication.FindByLocalAppID(LocalAppID);

            if (_LocalApp == null)
            {
                _SetDefaultValues();
                MessageBox.Show("No Local Application  with ID : " + _LocalAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            _FillLocalAppInfo();           
        }

        private void WhenApplicationInfoChanged(object sender, EventArgs e)
        {
            LocalApplicationInfoChanged?.Invoke(this, null);
        }
           

    }
}

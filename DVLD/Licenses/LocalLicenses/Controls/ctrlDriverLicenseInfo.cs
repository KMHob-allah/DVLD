using DVLD.Global;
using DVLD.GlobalSettings;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Drivers
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public clLicense License {  get; private set;  }

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }     

        private void _LoadPersonImage()
        {
            string ImagePath = License.ApplicationInfo.PersonInfo.ImagePath;

            if (string.IsNullOrEmpty(ImagePath))
            {
                pbPersonImage.Image = (License.ApplicationInfo.PersonInfo.IsMale() ? Resources.DefaultMale : Resources.DefaultFemale);
                return;
            }

            if(File.Exists(ImagePath)) pbPersonImage.ImageLocation = ImagePath;

            else MessageBox.Show("Could Not Find This Image : {ImagePath}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillLicenseInfo()
        {
            lblClassNameValue.Text = License.LicenseClassInfo.ClassName;
            lblFullNameValue.Text = License.ApplicationInfo.PersonInfo.FullName();
            lblLicenseIDValue.Text = License.LicenseID.ToString();
            lblNationalNumberValue.Text = License.ApplicationInfo.PersonInfo.NationalNumber;
            lblGenderValue.Text = License.ApplicationInfo.PersonInfo.stGender();
            lblIssueDateValue.Text = clFormat.DateToShort(License.IssueDate);
            lblIssueReasonValue.Text = License.strIssueReason();
            lblNotesValue.Text = License.Notes;
            lblIsActiveValue.Text = (License.IsActive  ? "Yes" : "No");
            lblBirthDateValue.Text = License.ApplicationInfo.PersonInfo.BirthDate.ToString();
            lblDriverIDValue.Text = License.DriverID.ToString(); 
            lblExpirationDateValue.Text = clFormat.DateToShort(License.ExpirationDate);
            lblIsDetainedValue.Text = (License.IsDetained() ? "Yes" : "No");

            _LoadPersonImage();           
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            License = clLicense.Find(LicenseID);

            if(License == null) 
            {
                MessageBox.Show($"Connot Find License With ID = {LicenseID}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLicenseInfo();
        }


    }
}

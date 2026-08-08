using DVLD.Global;
using DVLD.Properties;
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
using System.IO;
namespace DVLD.Licenses.LocalLicenses.Controls
{
    public partial class ctrlLicenseCard : UserControl
    {
        public event Action<int> LicenseSelected;

        public ctrlLicenseCard()
        {
            InitializeComponent();
        }

        public clLicense License { get; private set; }
        
        private void _LoadPersonImage()
        {
            string ImagePath = License.ApplicationInfo.PersonInfo.ImagePath;

            if (string.IsNullOrEmpty(ImagePath))
            {
                pbPersonImage.Image = (License.ApplicationInfo.PersonInfo.IsMale() ? Resources.DefaultMale : Resources.DefaultFemale);
                return;
            }

            if (File.Exists(ImagePath)) pbPersonImage.ImageLocation = ImagePath;

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
            lblIsActiveValue.Text = (License.IsActive ? "Yes" : "No");
            lblBirthDateValue.Text = License.ApplicationInfo.PersonInfo.BirthDate.ToString();
            lblDriverIDValue.Text = License.DriverID.ToString();
            lblExpirationDateValue.Text = clFormat.DateToShort(License.ExpirationDate);
            lblIsDetainedValue.Text = (License.IsDetained() ? "Yes" : "No");

            _LoadPersonImage();
        }
        public void _SetDefaultValues()
        {
            lblClassNameValue.Text = "???";
            lblFullNameValue.Text = "???";
            lblLicenseIDValue.Text = "???";
            lblNationalNumberValue.Text = "???";
            lblGenderValue.Text = "???";
            lblIssueDateValue.Text = "???";
            lblIssueReasonValue.Text = "???";
            lblNotesValue.Text = "???";
            lblIsActiveValue.Text = "???";
            lblBirthDateValue.Text = "???";
            lblDriverIDValue.Text = "???";
            lblExpirationDateValue.Text = "???";
            lblIsDetainedValue.Text = "???";

            pbPersonImage.Image = Resources.DefaultMale;
        }
        public void WhenLicenseSelected(int LicenseID)
        {
            LicenseSelected?.Invoke(LicenseID);
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            License = clLicense.Find(LicenseID);

            if (License == null)
            {
                _SetDefaultValues();
                MessageBox.Show($"Connot Find License With ID = {LicenseID}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLicenseInfo();
            WhenLicenseSelected(LicenseID);

        }

    }
}

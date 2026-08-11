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

namespace DVLD.Applications.InternationalLicenses
{
    public partial class ctrlInternationalLicenseCard : UserControl
    {
        public ctrlInternationalLicenseCard()
        {
            InitializeComponent();
        }


        public clInternationalLicense InternationalLicense { get; private set; }

        private void _LoadPersonImage()
        {
            string ImagePath = InternationalLicense.ApplicationInfo.PersonInfo.ImagePath;

            if (string.IsNullOrEmpty(ImagePath))
            {
                pbPersonImage.Image = (InternationalLicense.ApplicationInfo.PersonInfo.IsMale() ? Resources.DefaultMale : Resources.DefaultFemale);
                return;
            }

            if (File.Exists(ImagePath)) pbPersonImage.ImageLocation = ImagePath;

            else MessageBox.Show($"Could Not Find This Image : {ImagePath}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillInternationalLicenseInfo()
        {
            lblFullNameValue.Text = InternationalLicense.ApplicationInfo.PersonInfo.FullName();
            lblInternationalLicenseIDValue.Text = InternationalLicense.ApplicationInfo.PersonInfo.FullName();
            lblLicenseIDValue.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNumberValue.Text = InternationalLicense.ApplicationInfo.PersonInfo.NationalNumber;
            lblGenderValue.Text = InternationalLicense.ApplicationInfo.PersonInfo.stGender();
            lblIssueDateValue.Text = clFormat.DateToShort(InternationalLicense.IssueDate).ToString();
            lblAppIDValue.Text = InternationalLicense.ApplicationID.ToString();
            lblIsActiveValue.Text = InternationalLicense.IsActive ? "Yes" : "No";
            lblBirthDateValue.Text = InternationalLicense.ApplicationInfo.PersonInfo.BirthDate.ToString();
            lblDriverIDValue.Text = InternationalLicense.DriverID.ToString();
            lblExpirationDateValue.Text = clFormat.DateToShort(InternationalLicense.ExpirationDate).ToString();


            _LoadPersonImage();
        }
        public void _SetDefaultValues()
        {
            lblFullNameValue.Text = "???";
            lblInternationalLicenseIDValue.Text = "???";
            lblLicenseIDValue.Text = "???";
            lblNationalNumberValue.Text = "???";
            lblGenderValue.Text = "???";
            lblIssueDateValue.Text = "???";
            lblAppIDValue.Text = "???";
            lblIsActiveValue.Text = "???";
            lblBirthDateValue.Text = "???";
            lblDriverIDValue.Text = "???";
            lblExpirationDateValue.Text = "???";

            pbPersonImage.Image = Resources.DefaultMale;
        }     

        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            InternationalLicense = clInternationalLicense.Find(InternationalLicenseID);

            if (InternationalLicense == null)
            {
                MessageBox.Show($"Connot Find International License With ID = {InternationalLicenseID}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetDefaultValues();
                return;
            }

            _FillInternationalLicenseInfo();
        }
    }
}

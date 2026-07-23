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

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public event EventHandler PersonCardChanged;

        private clPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clPerson PersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            bool HasImage = false;

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                if (File.Exists(_Person.ImagePath))
                { 
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                    HasImage = true;
                }

                else MessageBox.Show("Could not find this image: = " + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
            if(!HasImage)
            { 
                if (_Person.IsMale()) pbPersonImage.Image = Resources.DefaultMale;

                else pbPersonImage.Image = Resources.DefaultFemale;       
            }    

        }
        private void _FillPersonInfo()
        {
            lnklblEditPersonInfo.Enabled = true;

            _PersonID = _Person.PersonID;
            lblPersonIDValue.Text = _Person.PersonID.ToString();
            lblNationalNumberValue.Text = _Person.NationalNumber;
            lblFullNameValue.Text = _Person.FullName();
            lblGenderValue.Text = _Person.stGender();
            lblEmailValue.Text = (string.IsNullOrEmpty(_Person.Email) ? "Doesn't Have" : _Person.Email);
            lblPhoneValue.Text = _Person.Phone;
            lblBirthDateValue.Text = _Person.BirthDate.ToShortDateString();
            lblCountryValue.Text = _Person.CountryInfo.CountryName;
            lblAddressVal.Text = _Person.Address;

            _LoadPersonImage();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;

            lblPersonIDValue.Text = "???";
            lblNationalNumberValue.Text = "???";
            lblFullNameValue.Text = "???";
            lblGenderValue.Text = "???";
            lblEmailValue.Text = "???";
            lblAddressVal.Text = "???";
            lblBirthDateValue.Text = "???";
            lblPhoneValue.Text = "???";
            lblCountryValue.Text = "???";

            pbPersonImage.Image = Resources.DefaultMale;

            lnklblEditPersonInfo.Enabled = false;

        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clPerson.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID : " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNumber)
        {
            _Person = clPerson.Find(NationalNumber);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National Number : " + NationalNumber.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
     
        private void lnklblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.PersonDataSaved += PersonData_Changed;
            frm.ShowDialog();                 
        }
        private void PersonData_Changed(object sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
            PersonCardChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

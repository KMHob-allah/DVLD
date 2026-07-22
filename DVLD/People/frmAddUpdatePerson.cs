using DVLD.Global;
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
using static DVLD_Business.clPerson;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void PersonDataSavedEventHandler(object sender, int PersonID);

        public event PersonDataSavedEventHandler PersonDataSaved;
        public enum eMode { Add, Update };

        private eMode _Mode;

        private int _PersonID;
        clPerson _Person;

        public frmAddUpdatePerson()
        {
            _Mode = eMode.Add;
            _PersonID = -1;
            InitializeComponent();
        }    
        public frmAddUpdatePerson(int PersonID)
        {
            _Mode = eMode.Update;
            _PersonID = PersonID;
            InitializeComponent();

        }

        private void _FillcbCountries()
        {
           cbCountries.DataSource = clCountry.GetAllCountries();
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            
        }
        private void _FillPersonInfo()
        {
            _Person.FirstName = tbFirstNameValue.Text.Trim();
            _Person.SecondName = tbSecondNameValue.Text.Trim();
            _Person.ThirdName = tbThirdNameValue.Text.Trim();
            _Person.LastName = tbLastNameValue.Text.Trim();

            _Person.NationalNumber = tbNationalNumberValue.Text.Trim();

            _Person.Email = tbEmailValue.Text.Trim();
            _Person.Phone = tbPhoneValue.Text.Trim();
            _Person.Address = tbAddressValue.Text.Trim();
            _Person.BirthDate = dtpBirthDateValue.Value;

            _Person.Gender = (rdbtnMale.Checked ? clPerson.eGender.Male : clPerson.eGender.Female);
            
            _Person.NationalityCountryID = Convert.ToInt32(cbCountries.SelectedValue);

            if (pbPersonImage.ImageLocation != null) _Person.ImagePath = pbPersonImage.ImageLocation;
            else _Person.ImagePath = string.Empty;
        }
        private void _SetTitle(string Title)
        {
            lblAddEditPerson.Text = Title;
        }
        private void _ResetDefaultImage()
        {
            pbPersonImage.Image = rdbtnMale.Checked ? Resources.DefaultMale :Resources.DefaultFemale;           
        }
        private void _ResetTextBoxes()
        {
            tbFirstNameValue.Text = string.Empty;
            tbSecondNameValue.Text = string.Empty;
            tbThirdNameValue.Text = string.Empty;
            tbLastNameValue.Text = string.Empty;
            tbNationalNumberValue.Text = string.Empty;
            rdbtnMale.Checked = true;
            tbPhoneValue.Text = string.Empty;
            tbEmailValue.Text = string.Empty;
            tbAddressValue.Text = string.Empty;
        }
        private void _SetDefaultCountry()
        {
            clCountry Country = clCountry.Find("Egypt");

            if (Country != null) cbCountries.SelectedValue = Country.CountryID;
            else cbCountries.SelectedValue = 51; // Egypt ID


        }

        private void _ApplyBirthDateRules()
        {
            // we set the max date to 18 years from today, and set the default value the same.
           
            dtpBirthDateValue.MaxDate = DateTime.Now.AddYears(-18);
            
            dtpBirthDateValue.Value = dtpBirthDateValue.MaxDate;
            
            dtpBirthDateValue.MinDate = DateTime.Now.AddYears(-100); // should not allow adding age more than 100 years
        }
        private void _ResetDefualtValues()
        {
            _FillcbCountries();

            if (_Mode == eMode.Add)
            {
                _SetTitle("Add New Person");
                _Person = new clPerson();
            }

            else _SetTitle("Update Person");

            _ResetDefaultImage();

            _ApplyBirthDateRules();

            _SetDefaultCountry();

            _ResetTextBoxes();

            lnklblRemoveImage.Visible = (pbPersonImage.ImageLocation != null);
            
        }
        private void _LoadPersonDetails()
        {
            _Person = clPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            tbFirstNameValue.Text = _Person.FirstName;
            tbSecondNameValue.Text = _Person.SecondName;
            tbThirdNameValue.Text = _Person.ThirdName;
            tbLastNameValue.Text = _Person.LastName;
            tbNationalNumberValue.Text = _Person.NationalNumber;
            dtpBirthDateValue.Value = _Person.BirthDate;

            if (_Person.IsMale()) rdbtnMale.Checked = true;
            else rdbtnFemale.Checked = true;

            tbAddressValue.Text = _Person.Address;
            tbPhoneValue.Text = _Person.Phone;
            tbEmailValue.Text = _Person.Email;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            if (!string.IsNullOrEmpty(_Person.ImagePath )) pbPersonImage.ImageLocation = _Person.ImagePath;            

            lnklblRemoveImage.Visible = !string.IsNullOrEmpty(_Person.ImagePath);

        }       
        
        private bool _HandlePersonImage()
        {            
            if (_Person.ImagePath != pbPersonImage.ImageLocation) // True When Image Is Changed
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {                   
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }   

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox CurrentTextBox = ((TextBox)sender);

            if (string.IsNullOrEmpty(CurrentTextBox.Text.Trim()))
            {
                e.Cancel = true;
                errpAddEditHandler.SetError(CurrentTextBox, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errpAddEditHandler.SetError(CurrentTextBox, null);
            }

        }        

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == eMode.Update) _LoadPersonDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, Put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage()) return;
                     
            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                _Mode = eMode.Update;

                _SetTitle("Update Person");

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PersonDataSaved?.Invoke(this, _Person.PersonID);
            }

            else MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)  pbPersonImage.Image = Resources.DefaultMale;
        }
        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null) pbPersonImage.Image = Resources.DefaultFemale;
        }

        private void lnklblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            _ResetDefaultImage();

            lnklblRemoveImage.Visible = false;
        }
        private void lnklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {               
                string selectedFilePath = OpenFileDialog.FileName;

                pbPersonImage.Load(selectedFilePath);

                lnklblRemoveImage.Visible = true;                
            }
        }

        private void tbNationalNumberValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNumberValue.Text.Trim()))
            {
                e.Cancel = true;
                errpAddEditHandler.SetError(tbNationalNumberValue, "This field is required!");
                return;
            }

            else errpAddEditHandler.SetError(tbNationalNumberValue, null);
             
            if (tbNationalNumberValue.Text.Trim() != _Person.NationalNumber && clPerson.IsExist(tbNationalNumberValue.Text.Trim()))
            {
                e.Cancel = true;
                errpAddEditHandler.SetError(tbNationalNumberValue, "National Number is used by another person!");
            }

            else errpAddEditHandler.SetError(tbNationalNumberValue, null);            

        }
        private void tbEmailValue_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmailValue.Text.Trim() == "")
                return;
        
            if (!clValidation.IsValidateEmail(tbEmailValue.Text))
            {
                e.Cancel = true;
                errpAddEditHandler.SetError(tbEmailValue, "Invalid Email Address Format!");
            }

            else errpAddEditHandler.SetError(tbEmailValue, null);
        }
    }
}

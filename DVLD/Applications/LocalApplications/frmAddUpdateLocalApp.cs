using DVLD.Global;
using DVLD.GlobalSettings;
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
using static DVLD_Business.clApplication;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DVLD.Applications.LocalApplications
{
    public partial class frmAddUpdateLocalApp : Form
    {
        //private void tbUserNameValue_Validating_1(object sender, CancelEventArgs e)
        //{
        //    string _UserName = tbUserNameValue.Text.Trim();

        //    if (string.IsNullOrEmpty(_UserName))
        //    {
        //        errpLoginInfoHandler.SetError(tbUserNameValue, "This field cannot be blanck");
        //        e.Cancel = true;
        //        return;
        //    }

        //    bool IsDuplicateInAddMode = (_Mode == eMode.Add && clUser.IsExistByUserName(_UserName));
        //    bool IsDuplicateInUpdateMode = (_Mode != eMode.Add && _UserName != _User.UserName && clUser.IsExistByUserName(_UserName));

        //    if (IsDuplicateInAddMode || IsDuplicateInUpdateMode)
        //    {
        //        errpLoginInfoHandler.SetError(tbUserNameValue, "User name is used by another person, Please choose another one");
        //        e.Cancel = true;
        //    }

        //    else
        //    {
        //        errpLoginInfoHandler.SetError(tbUserNameValue, "");
        //    }
        //}


        //private void tbPasswordValue_Validating_1(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(tbPasswordValue.Text.Trim()))
        //    {
        //        errpLoginInfoHandler.SetError(tbPasswordValue, "Password connot be blanck");
        //        e.Cancel = true;
        //    }

        //    else errpLoginInfoHandler.SetError(tbPasswordValue, "");

        //}
        //private void tbConfirmPasswordValue_Validating_1(object sender, CancelEventArgs e)
        //{
        //    if (tbConfirmPasswordValue.Text.Trim() != tbPasswordValue.Text.Trim())
        //    {
        //        errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "Confirm password must match password");
        //        e.Cancel = true;
        //    }
        //    else errpLoginInfoHandler.SetError(tbConfirmPasswordValue, "");

        //}


        //private void tcPersonInfoLoginInfo_Selecting(object sender, TabControlCancelEventArgs e)
        //{
        //    if (e.TabPage == tpLoginInfo
        //        &&
        //        ctrlPersonCardWithFilter1.PersonID != -1
        //        &&
        //        !clUser.IsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
        //    {
        //        btnSave.Enabled = true;
        //        tpLoginInfo.Enabled = true;
        //    }

        //}

        public event EventHandler LocalApplication_DataSaved;
        enum eMode { Add, Update }

        private eMode _Mode;

        clLocalApplication _LocalApplication;

        int _LocalAppID;

        public frmAddUpdateLocalApp()
        {
            _LocalAppID = -1;
            _Mode = eMode.Add;

            InitializeComponent();
        }
        public frmAddUpdateLocalApp(int LocalAppID)
        {
            _LocalAppID = LocalAppID;
            _Mode = eMode.Update;

            InitializeComponent();
        }


        private void _FillLocalApplicationInfo()
        {
            
            if(_Mode == eMode.Update)
            {
                _LocalApplication.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;
                _LocalApplication.LicenseClassID = Convert.ToInt32(cbClasses.SelectedValue);

                return;
            }

            // Will continue just in add mode

            _LocalApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;

            _LocalApplication.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;

            _LocalApplication.PaidFees = Convert.ToSingle(lblAppFeesValue.Text);

            _LocalApplication.ApplicationDate = DateTime.Now;
            _LocalApplication.LastStatusDate = _LocalApplication.ApplicationDate;
            _LocalApplication.ApplicationType = clApplicationType.eApplicationType.NewLocalDrivingLicenseService;
            _LocalApplication.ApplicationStatus = clApplication.eApplicationStatus.New;

            _LocalApplication.LicenseClassID = Convert.ToInt32(cbClasses.SelectedValue);
        }
        private void _ResetDefaultValues()
        {
            btnSave.Enabled = false;
            btnNext.Enabled = false;

            _FillcbClasses();

            switch (_Mode)
            {
                case eMode.Add:
                    {
                        lblHeader.Text = "Add New Driving License Application";

                        _LocalApplication = new clLocalApplication();

                        tpApplicationInfo.Enabled = false;

                        ctrlPersonCardWithFilter1.FilterFocus();

                        _SetLocalAppInfo();

                        break;
                    }

                case eMode.Update:
                    {
                        lblHeader.Text = "Update Local Driving License Application";                        

                        tpApplicationInfo.Enabled = true;

                        ctrlPersonCardWithFilter1.FilterEnabled = false;

                        break;
                    }
            }

        }
        private void _LoadLocalAppInfo()
        {
            // Update Mode
            _LocalApplication = clLocalApplication.FindByLocalAppID(_LocalAppID);

            if (_LocalApplication == null)
            {
                MessageBox.Show("No Local Application with ID = " + _LocalAppID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalApplication.ApplicantPersonID);

            lblApplicationIDValue.Text = _LocalApplication.ApplicationID.ToString();
            lblApplicationDateValue.Text = clFormat.DateToShort( _LocalApplication.ApplicationDate);
            lblAppFeesValue.Text = _LocalApplication.PaidFees.ToString();
            lblCeatedByValue.Text = _LocalApplication.UserInfo.UserName.ToString();

            cbClasses.ValueMember = _LocalApplication.LicenseClassID.ToString();

        }
        private void _FillcbClasses()
        {
            cbClasses.DataSource = clLicenseClass.GetAllLicenseClasses();

            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "LicenseClassID";

            cbClasses.SelectedValue = 3; // "Class 3 - Ordinary driving license";
        }
        private void _SetLocalAppInfo()
        {
            lblApplicationDateValue.Text =Global.clFormat.DateToShort( DateTime.Now);
            lblAppFeesValue.Text = clApplicationType.Find(clApplicationType.eApplicationType.NewInternationalLicense).Fees.ToString(); // Temporary
            lblCeatedByValue.Text = clGlobalSettings.CurrentUser.UserName;
        }


        private void ctrlPersonCardWithFilter1_WhenPersonSelected(int obj)
        {
            if (!btnNext.Enabled) btnNext.Enabled = true;
        }
        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) btnSave.Enabled = true;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == eMode.Add)
            {
                if (ctrlPersonCardWithFilter1.PersonID != -1)
                {
                    tpApplicationInfo.Enabled = true;
                    btnSave.Enabled = true;
                    tcPersonApplicationInfo.SelectedIndex = 1; // Go to Login Info                                       
                }

                else
                {
                    MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
            }

            else
            {
                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
                tcPersonApplicationInfo.SelectedIndex = 1;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            _FillLocalApplicationInfo();

            clLocalApplication.eSaveResult _SaveResult = _LocalApplication.Save();

            switch(_SaveResult)
            {
                case clLocalApplication.eSaveResult.FaildHasActiveLicense:
                {
                    MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class",
                        "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                case clLocalApplication.eSaveResult.FaildHasActiveApp:
                {
                    MessageBox.Show("Choose another License Class, The selected Person Already have an active application for the selected class",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                case clLocalApplication.eSaveResult.FaildLessThanMinAge:
                {
                    MessageBox.Show("Sorry, The applicant does not meet the minimum legal age requirenment for this license class",
                        "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                case clLocalApplication.eSaveResult.Success:
                {
                    if (_Mode == eMode.Add)
                    {
                        lblApplicationIDValue.Text = _LocalApplication.LocalApplicationID.ToString();

                        _LocalAppID = _LocalApplication.LocalApplicationID;

                        _Mode = eMode.Update;
                        lblAddEditUser.Text = "Update Local Driving License Application";
                    }

                    MessageBox.Show("Application saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlPersonCardWithFilter1.FilterEnabled = false;
                    btnSave.Enabled = false;
                    LocalApplication_DataSaved?.Invoke(this, EventArgs.Empty);

                    break;
                }

                case clLocalApplication.eSaveResult.Faild:
                {
                    MessageBox.Show("Application was not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    break;
                }
            }           
                
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateLocalApp_Load(object sender, EventArgs e)
        {           
            _ResetDefaultValues();          

            if (_Mode == eMode.Update) _LoadLocalAppInfo();
        }

        private void tcPersonApplicationInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpApplicationInfo)
            {
                if (ctrlPersonCardWithFilter1.PersonID == -1)
                { 
                    btnSave.Enabled = false;
                    tpApplicationInfo.Enabled = false;
                }

                else
                {
                    btnSave.Enabled = true ;
                    tpApplicationInfo.Enabled = true;
                }
            }

            



        }
    }
}

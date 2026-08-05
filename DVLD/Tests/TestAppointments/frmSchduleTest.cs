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
using static DVLD.Tests.TestAppointments.frmSchduleTest;
using static DVLD_Business.clApplicationType;

namespace DVLD.Tests.TestAppointments
{
    public partial class frmSchduleTest : Form
    {
        public event EventHandler AppointmentDataSaved;
        public enum eMode : byte { Add,Update}
        public enum eCreationMode : byte { FirstTime, Retake}

        clTestAppointment _TestAppointment;
        clTestType.eTestType _TestTypeID;
        clLocalApplication _LocalApp;
        clTestType _TestType;


        int _AppointmentID;
        int _LocalAppID;
        
        eCreationMode _CreationMode;
        eMode _Mode;

        // Update Mode
        public frmSchduleTest(int AppointmentID)
        {
            this._AppointmentID = AppointmentID;

            _Mode = eMode.Update;

            InitializeComponent();
        }

        // Add Mode
        public frmSchduleTest(int LocalAppID ,clTestType.eTestType TestTypeID)
        {            
            this._LocalAppID = LocalAppID;

            this._TestTypeID = TestTypeID;

            this._AppointmentID = -1;

            _Mode = eMode.Add;

            InitializeComponent();
        }

        private void _SetTestAppointmentInfo()
        {
            lblLocalAppIDValue.Text = _LocalApp.LocalApplicationID.ToString();
            lblDrivingClassValue.Text = _LocalApp.LicenseClassInfo.ClassName;
            lblNameValue.Text = _LocalApp.PersonInfo.FullName();
            lblTrailValue.Text = _LocalApp.TotalTrailsPerTest(_TestTypeID).ToString();
            lblFeesValue.Text = clTestType.Find(_TestTypeID).Fees.ToString();

            dtpTestDate.MinDate = DateTime.Today;
            dtpTestDate.Text = DateTime.Now.ToString();

            lblTotalFeesValue.Text = _CalcTotalFees().ToString();
        }
        private void _SetDefaultValues()
        {            
            if (_Mode == eMode.Add)
            {
                _LocalApp = clLocalApplication.FindByLocalAppID(_LocalAppID);

                if (_LocalApp == null)
                {
                    MessageBox.Show("Error: No Local Driving License Application with ID : " + _LocalAppID.ToString(),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }

                _TestType = clTestType.Find(_TestTypeID);
                _TestAppointment = new clTestAppointment();

                _CreationMode = (_LocalApp.DoesAttendTestType(_TestType.ID) ? eCreationMode.Retake : eCreationMode.FirstTime);

                _SetTestAppointmentInfo();                           
            }

            else
            {
                _TestAppointment = clTestAppointment.Find(_AppointmentID);

                if (_TestAppointment == null)
                {
                    MessageBox.Show("Error: No Appointment with ID = " + _AppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }

                _LocalAppID = _TestAppointment.LocalAppID;
                _TestTypeID = _TestAppointment.TestType;

                _LocalApp = _TestAppointment.LocalApplicationInfo;
                _TestType = clTestType.Find(_TestTypeID);

                _CreationMode = (_TestAppointment.LocalApplicationInfo.DoesAttendTestType(_TestType.ID) ? eCreationMode.Retake : eCreationMode.FirstTime);
            }
            
            switch (_TestTypeID)
            {

                case clTestType.eTestType.Vision:
                {
                        this.Text = "Schdule Vision Test";
                        lblSchduleTestHeader.Text = "Schdule Vision Test";
                        break;
                }

                case clTestType.eTestType.Written:
                {
                        this.Text = "Schdule Written Test";
                        lblSchduleTestHeader.Text = "Schdule Written Test";
                        break;
                }

                case clTestType.eTestType.Street:
                {
                        this.Text = "Schdule Street Test";
                        lblSchduleTestHeader.Text = "Schdule Street Test";
                        break;
                }

            }

            switch(_CreationMode)
            {
                case eCreationMode.Retake:
                {
                    lblSchduleTestHeader.Text = "Schedule Retake Test";
                    lblRetakeAppFeesValue.Text = clApplicationType.Find(clApplicationType.eApplicationType.RetakeTest).Fees.ToString();
                    gbRetakeTestInfo.Enabled = true;
                    lblRetakeTestAppIDValue.Text = "N/A";
                    break;
                }

                case eCreationMode.FirstTime:
                {
                    gbRetakeTestInfo.Enabled = false;
                    lblRetakeAppFeesValue.Text = "0";
                    lblRetakeTestAppIDValue.Text = "N/A";
                    break;
                }
            }

            if (!_HandleActiveTestAppointmentConstraint()) return;

            if (!_HandleAppointmentLockedConstraint()) return;

            if (!_HandlePrviousTestConstraint()) return;

        }
        private float _CalcTotalFees()
        {
           return (Convert.ToSingle(lblFeesValue.Text) + Convert.ToSingle(lblRetakeAppFeesValue.Text));
        }
        private void _LoadTestAppointmentInfo()
        {                     
            lblLocalAppIDValue.Text = _TestAppointment.LocalAppID.ToString();
            lblDrivingClassValue.Text = _TestAppointment.LocalApplicationInfo.LicenseClassInfo.ClassName;
            lblNameValue.Text = _TestAppointment.LocalApplicationInfo.PersonInfo.FullName();
            lblTrailValue.Text = _TestAppointment.LocalApplicationInfo.TotalTrailsPerTest(_TestTypeID).ToString();
            lblFeesValue.Text = _TestAppointment.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0) dtpTestDate.MinDate = DateTime.Now;
            else dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

            dtpTestDate.Text = _TestAppointment.AppointmentDate.ToString();
            lblTotalFeesValue.Text = _CalcTotalFees().ToString();           

            if(_TestAppointment.RetakeTestAppID != -1)
            {
                lblRetakeTestAppIDValue.Text = _TestAppointment.RetakeTestAppID.ToString();
                lblRetakeAppFeesValue.Text = _TestAppointment.ApplicationInfo.PaidFees.ToString();                         
            }            

        }
        private void _FillTestAppointment()
        {
            _TestAppointment.TestType = _TestTypeID;
            _TestAppointment.LocalAppID = Convert.ToInt32(lblLocalAppIDValue.Text);

            if (_Mode == eMode.Add) _TestAppointment.AppointmentDate = DateTime.Now;

            else _TestAppointment.AppointmentDate = (DateTime)dtpTestDate.Value;

            _TestAppointment.PaidFees = Convert.ToSingle(lblTotalFeesValue.Text);
            _TestAppointment.CreatedByUserID = GlobalSettings.clGlobalSettings.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            if(int.TryParse(lblRetakeTestAppIDValue.Text, out int RetakeTestAppID))
            {
                _TestAppointment.RetakeTestAppID = RetakeTestAppID;
            }
            else  _TestAppointment.RetakeTestAppID = -1;
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == eMode.Add && clLocalApplication.HassAppointmentForTestType(_LocalAppID, true, (int)_TestTypeID))
            {
                lblMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {           
            if (_TestAppointment.IsLocked)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Person already sat for the test, appointment is locked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }

            else lblMessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            switch (_TestTypeID)
            {
                case clTestType.eTestType.Vision:
                    lblMessage.Visible = false;
                    return true;

                case clTestType.eTestType.Written:
                   
                    if (!_LocalApp.DoesAttendTestType(clTestType.eTestType.Vision))
                    {
                        lblMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

                case clTestType.eTestType.Street:
                   
                    if (!_LocalApp.DoesAttendTestType(clTestType.eTestType.Written))
                    {
                        lblMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                   
                    else
                    {
                        lblMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }

                    return true;

            }

            return true;

        }
        private bool _HandleRetakeApplication()
        {
           
            if (_Mode == eMode.Add && _CreationMode == eCreationMode.Retake)
            {
                clApplication Application = new clApplication();

                Application.ApplicantPersonID = _LocalApp.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationType = clApplicationType.eApplicationType.RetakeTest;
                Application.ApplicationStatus = clApplication.eApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clApplicationType.Find(eApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestAppID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestAppID = Application.ApplicationID;

            }
            return true;
        }

        private void frmSchduleTest_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();
            
            if(_Mode == eMode.Update) _LoadTestAppointmentInfo();            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication()) return;

            _FillTestAppointment();

            if(_TestAppointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppointmentDataSaved?.Invoke(this, null);
                this.Close();
            }

            else MessageBox.Show("Sorry, Appointment Was not Saved ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



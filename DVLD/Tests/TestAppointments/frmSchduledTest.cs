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

namespace DVLD.Tests.TestAppointments
{
    public partial class frmSchduledTest : Form
    {
        //public event EventHandler PersonPassed;
        public event EventHandler TestResultSaved;

        int AppointmentID;        
        public frmSchduledTest(int AppointmentID)
        {
            this.AppointmentID = AppointmentID;
            InitializeComponent();
        }



        //int _AppointmentID;
        //clLocalDrivingLicenseApp _LocalApp;
        //clTestType TestType;
        //clAppointment Appointment = new clAppointment();
        //clTest Test = new clTest();

        //public void LoadTestInfo(int _AppointmentID)
        //{
        //    rdbtnPass.Checked = true;
        //    Appointment = clAppointment.Find(_AppointmentID);

        //    _LocalApp = clLocalDrivingLicenseApp.Find(Appointment.LocalDrivingLicenseApplicationID);

        //    _LocalApp.ApplciationInfo = clApplication.Find(_LocalApp.ApplicationID);

        //    _LocalApp.ApplciationInfo.PersonInfo = clPerson.Find(_LocalApp.ApplciationInfo.ApplicantPersonID);

        //    lblLocalAppIDValue.Text = _LocalApp.LocalApplicationID.ToString();
        //    lblDrivingClassValue.Text = clLicenseClass.FindClassNameByID(_LocalApp.LicenseClassID);
        //    lblNameValue.Text = _LocalApp.ApplciationInfo.PersonInfo.FullName();
        //    lblTrailValue.Text = Trail.ToString();
        //    lblDateValue.Text = Appointment.AppointmentDate.ToString();
        //    lblFeesValue.Text = Appointment.PaidFees.ToString();


        //}
        //private void frmSchduledTest_Load(object sender, EventArgs e)
        //{
        //    LoadTestInfo(_AppointmentID);
        //}
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        //private void _FillTestInfo(clTest Test)
        //{
        //    // MustFix Created user ID
        //    Test.TestAppointmentID = _AppointmentID;
        //    Test.TestResult = rdbtnPass.Checked ? true : false;
        //    Test.CreatedByUserID = 1;
        //    frmSchduleTest.Trail += (Test.TestResult ? 0 : 1);
        //}
        //private bool _SaveTestResult()
        //{
        //    _FillTestInfo(Test);

        //    int Result = Test.Save();

        //    if (Result != -1)
        //    {
        //        Test.TestID = Result;
        //        Appointment.IsLocked = true;
        //        Appointment.UpdateAppointment();
        //        return true;
        //    }
        //    else return false;
        //}
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save",
        //        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        if (_SaveTestResult())
        //        {
        //            MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            if (rdbtnPass.Checked) PersonPassed?.Invoke(this, EventArgs.Empty);
        //            TestResultSaved?.Invoke(this, EventArgs.Empty);

        //            this.Close();
        //        }

        //        else
        //        {
        //            MessageBox.Show("Data didn't saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            this.Close();
        //        }
        //    }
        //}







    }
}

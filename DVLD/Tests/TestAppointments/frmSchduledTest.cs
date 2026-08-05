using DVLD.GlobalSettings;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Tests.TestAppointments
{
    public partial class frmSchduledTest : Form
    {
        public event EventHandler TestDataSaved;


        clTestAppointment _Appointment;
        clTest _Test;

        int _AppointmentID;

        public frmSchduledTest(int AppointmentID)
        {
            this._AppointmentID = AppointmentID;

            InitializeComponent();
        }

        public void LoadTestInfo(int _AppointmentID)
        {           
            _Appointment = clTestAppointment.Find(_AppointmentID);
           
            if (_Appointment == null)
            {
                MessageBox.Show($"Connot Find Appointment With ID : {_AppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            } 
         

            if (_Appointment.IsLocked)
            {
                rdbtnFail.Enabled = false;
                rdbtnPass.Enabled = false;
                btnSave.Enabled = false;
                tbNotesValue.Enabled = false;
            }

            else
            {
                rdbtnFail.Enabled = true;
                rdbtnPass.Enabled = true;
                btnSave.Enabled = true;
                tbNotesValue.Enabled = true;
            }

            if (_Appointment.LocalApplicationInfo.DoesPassedTestType(_Appointment.TestType)) rdbtnPass.Checked = true;
            else rdbtnFail.Checked = true;

            lblLocalAppIDValue.Text = _Appointment.LocalApplicationInfo.LocalApplicationID.ToString();
            lblDrivingClassValue.Text = _Appointment.LocalApplicationInfo.LicenseClassInfo.ClassName;
            lblNameValue.Text = _Appointment.LocalApplicationInfo.PersonInfo.FullName();
            lblTrailValue.Text = _Appointment.LocalApplicationInfo.TotalTrailsPerTest(_Appointment.TestType).ToString();
            lblDateValue.Text = _Appointment.AppointmentDate.ToString();
            lblFeesValue.Text = _Appointment.PaidFees.ToString();



        }
        private void _FillTestInfo()
        {
            _Test = new clTest();

            _Test.AppointmentID = _AppointmentID;
            _Test.Result = rdbtnPass.Checked ? true : false;
            _Test.CreatedByUserID = clGlobalSettings.CurrentUser.UserID;
            _Test.Notes = tbNotesValue.Text;            
        }
     
   
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save",
               "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _FillTestInfo();
                              
                if (_Test.Save())
                {
                    lblTestIDValue.Text = _Test.ID.ToString();
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TestDataSaved?.Invoke(this, EventArgs.Empty);

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Data didn't saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSchduledTest_Load(object sender, EventArgs e)
        {
            LoadTestInfo(_AppointmentID);
        }
    }
}

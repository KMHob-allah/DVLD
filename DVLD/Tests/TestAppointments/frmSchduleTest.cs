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
    public partial class frmSchduleTest : Form
    {
        public enum eMode { Add,Update}

        clTestAppointment TestAppointment;
        clLocalApplication LocalApp;
        clTestType TestType;

        clTestType.eTestType TestTypeID;

        int AppointmentID;
        int LocalAppID;
        
        eMode _Mode;


        public frmSchduleTest(int AppointmentID)
        {
            this.AppointmentID = AppointmentID;

            _Mode = eMode.Update;

            InitializeComponent();
        }
        public frmSchduleTest(int LocalAppID ,clTestType.eTestType TestTypeID)
        {
            this.LocalAppID = LocalAppID;

            this.TestTypeID = TestTypeID;

            this.AppointmentID = -1;

            _Mode = eMode.Add;

            InitializeComponent();
        }


        private void _SetDefaultValues()
        {
            lblMessage.Visible = false;

            if(_Mode == eMode.Add)
            {
                LocalApp = clLocalApplication.FindByLocalAppID(LocalAppID);
                TestType = clTestType.Find(TestTypeID);               
            }

            else
            {
                TestAppointment = clTestAppointment.Find(AppointmentID);
                LocalAppID = TestAppointment.LocalAppID;
                TestTypeID = TestAppointment.TestType;
            }

            switch (TestTypeID)
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
        }
        private float _CalcTotalFees()
        {
           return (Convert.ToSingle(lblFeesValue.Text) + Convert.ToSingle(lblRetakeAppFeesValue.Text));
        }
        private void _LoadTestAppointmentInfo()
        {          
            if(_Mode == eMode.Add)
            {
                lblLocalAppIDValue.Text = LocalApp.LocalApplicationID.ToString();
                lblDrivingClassValue.Text = LocalApp.LicenseClassInfo.ClassName;
                lblNameValue.Text = LocalApp.PersonInfo.FullName();
                lblTrailValue.Text = LocalApp.TotalTrailsPerTest(TestTypeID).ToString();
                lblFeesValue.Text = clTestType.Find(TestTypeID).Fees.ToString();
                dtpTestDate.Text = DateTime.Now.ToString();
                lblTotalFeesValue.Text = _CalcTotalFees().ToString();

                //if (TestAppointment.RetakeTestAppID == -1)
                //{
                //    gbRetakeTestInfo.Enabled = false;
                //    return;
                //}

                //lblRetakeTestAppIDValue.Text = TestAppointment.ApplicationInfo.ApplicationID.ToString();
                //lblRetakeAppFeesValue.Text = TestAppointment.ApplicationInfo.PaidFees.ToString();
            }

            else
            {
                lblLocalAppIDValue.Text = TestAppointment.LocalAppID.ToString();
                lblDrivingClassValue.Text = TestAppointment.LocalApplicationInfo.LicenseClassInfo.ClassName;
                lblNameValue.Text = TestAppointment.LocalApplicationInfo.PersonInfo.FullName();
                lblTrailValue.Text = TestAppointment.LocalApplicationInfo.TotalTrailsPerTest(TestTypeID).ToString();
                lblFeesValue.Text = TestAppointment.PaidFees.ToString();
                dtpTestDate.Text = TestAppointment.AppointmentDate.ToString();
                lblTotalFeesValue.Text = _CalcTotalFees().ToString();

                if(TestAppointment.RetakeTestAppID == -1)
                {
                    gbRetakeTestInfo.Enabled = false;
                    return;
                }

                lblRetakeTestAppIDValue.Text = TestAppointment.ApplicationInfo.ApplicationID.ToString();
                lblRetakeAppFeesValue.Text = TestAppointment.ApplicationInfo.PaidFees.ToString();          
            } 
        }

        private void frmSchduleTest_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();

            _LoadTestAppointmentInfo();            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



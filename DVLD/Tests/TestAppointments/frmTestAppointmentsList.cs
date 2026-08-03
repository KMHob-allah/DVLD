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
    public partial class frmTestAppointmentsList : Form
    {
        //public event EventHandler AppointmentDataChanged;

        public enum eTestType { Vision = 1, Written, Street }


        eTestType CurrentTest;
        //bool PassedTest = false;
        int LocalAppID;

        public frmTestAppointmentsList(int LocalAppID, eTestType Test)
        {
            this.LocalAppID = LocalAppID;

            this.CurrentTest = Test;

            InitializeComponent();
        }

        private void _SetAppointmentsListHeaders()
        {
            dgvAppointmentsList.Columns[0].HeaderText = "Appointment ID";

            dgvAppointmentsList.Columns[1].HeaderText = "Appointment Date";

            dgvAppointmentsList.Columns[2].HeaderText = " Paid Fees";

            dgvAppointmentsList.Columns[3].HeaderText = "Is Locked";

                            
        }
        private void _SetAppointmentTestType()
        {
            switch (CurrentTest)
            {
                case eTestType.Vision:

                    lblHeader.Text = "Vision Test Appointment";
                    break;

                case eTestType.Written:

                    lblHeader.Text = "Written Test Appointment";
                    break;

                case eTestType.Street:

                    lblHeader.Text = "Street Test Appointment";
                    break;

            }
        }
        private void _LoadAppointmentList(object sender, EventArgs e)
        {
            DataTable dtAppointmentsList = clTestAppointment.GetAppointmentsListForLocalApp(LocalAppID, (int)CurrentTest);

            if (dtAppointmentsList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvAppointmentsList.DataSource = dtAppointmentsList;
                _SetAppointmentsListHeaders();
            }
        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvAppointmentsList.RowCount.ToString()}";
        }


        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            //if (clLocalApplication.ha(LocalAppID, true, (int)CurrentTest))
            //{
            //    MessageBox.Show("Person already has an active appointment for this test, You cannot add a new appointment",
            //        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //if (PassedTest)
            //{
            //    MessageBox.Show("Person already passed this test before, You can only retake faild tests",
            //       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //else
            //{
            //    frmSchduleTest.eStatus Status = frmSchduleTest.Trail > 0 ? frmSchduleTest.eStatus.Retake : frmSchduleTest.eStatus.FirstTime;
            //    frmSchduleTest frm = new frmSchduleTest(LocalAppID, -1, Status, CurrentTest, frmSchduleTest.eMode.Add, false);
            //    frm.AppointmentSaved += _LoadAppointmentList;
            //    frm.AppointmentSaved += _ResetRecords;
            //    frm.ShowDialog();
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opEdit_Click(object sender, EventArgs e)
        {
            //int TestAppointmentID = Convert.ToInt32(dgvAppointmentsList.CurrentRow.Cells["TestAppointmentID"].Value);
            //if (Convert.ToBoolean(dgvAppointmentsList.CurrentRow.Cells["IsLocked"].Value) == true)
            //{
            //    frmSchduleTest frm = new frmSchduleTest(LocalAppID, TestAppointmentID, frmSchduleTest.eStatus.FirstTime, CurrentTest, frmSchduleTest.eMode.Update, true);
            //    //frm.AppointmentSaved += WhenTestPassed;
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    frmSchduleTest frm = new frmSchduleTest(LocalAppID, TestAppointmentID, frmSchduleTest.eStatus.FirstTime, CurrentTest, frmSchduleTest.eMode.Update, false);
            //    frm.AppointmentSaved += WhenTestPassed;
            //    frm.ShowDialog();
            //}
        }
        private void opTakeTest_Click(object sender, EventArgs e)
        {
            //if (PassedTest)
            //{
            //    MessageBox.Show("Person already passed this test before, You can only retake faild tests",
            //        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //frmSchduledTest frm = new frmSchduledTest(Convert.ToInt32(dgvAppointmentsList.CurrentRow.Cells["TestAppointmentID"].Value));
            //frm.PersonPassed += WhenTestPassed;
            //frm.TestResultSaved += WhenAppointmentDataChanged;
            //frm.ShowDialog();
        }

        private void cmsTestOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAppointmentsList.Rows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        void frmTestAppointmentsList_Load(object sender, EventArgs e)
         {
            _SetAppointmentTestType();
            _LoadAppointmentList(this, EventArgs.Empty);
            _ResetRecords(this, EventArgs.Empty);
            ctrlLocalAppCard1.LoadLocalAppInfo(LocalAppID);
         }

        //private void WhenTestPassed(object sender, EventArgs e)
        //{
        //    PassedTest = true;
        //}

        //private void WhenAppointmentDataChanged(object sender, EventArgs e)
        //{
        //    _LoadAppointmentList(this, EventArgs.Empty);
        //    AppointmentDataChanged?.Invoke(this, EventArgs.Empty);

        //}
    }
}

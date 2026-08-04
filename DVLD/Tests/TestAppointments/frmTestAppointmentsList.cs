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



        clTestType.eTestType CurrentTest;
        int LocalAppID;

        public frmTestAppointmentsList(int LocalAppID, clTestType.eTestType Test)
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
                case clTestType.eTestType.Vision:

                    lblHeader.Text = "Vision Test Appointment";
                    break;

                case clTestType.eTestType.Written:

                    lblHeader.Text = "Written Test Appointment";
                    break;

                case clTestType.eTestType.Street:

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

            if (ctrlLocalAppCard1.LocalAppInfo.HasAppointmentForTestType(true, CurrentTest))
            {
                MessageBox.Show("Person already has an active appointment for this test, You cannot add a new appointment",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ctrlLocalAppCard1.LocalAppInfo.DoesPassedTestType(CurrentTest))
            {
                MessageBox.Show("Person already passed this test before, You can only retake faild tests",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            frmSchduleTest frm = new frmSchduleTest(LocalAppID,CurrentTest);
            frm.AppointmentDataSaved += _LoadAppointmentList;
            frm.AppointmentDataSaved += _ResetRecords;
            frm.ShowDialog();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opEdit_Click(object sender, EventArgs e)
        {
            frmSchduleTest frm = new frmSchduleTest(Convert.ToInt32(dgvAppointmentsList.CurrentRow.Cells[0].Value));
            frm.AppointmentDataSaved += _LoadAppointmentList;
            frm.AppointmentDataSaved += _ResetRecords;
            frm.ShowDialog();          
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

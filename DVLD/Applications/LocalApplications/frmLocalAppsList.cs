using DVLD.People;
using DVLD.Tests.TestAppointments;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalApplications
{
    public partial class frmLocalAppsList : Form
    {
        static private DataTable dtLocalAppsList = clLocalApplication.GetAllLocalAppsList();
        static private DataView dvLocalAppsList = dtLocalAppsList.DefaultView;
       
        
        public frmLocalAppsList()
        {
            InitializeComponent();
        }

        private void _FilterLocalAppsListRows(string ColumnName, string Value)
        {
            string _Value = Value.Trim();
         

            if (tbUserFilterationValue.Text == string.Empty) dvLocalAppsList.RowFilter = string.Empty;

            else
            {
                if (cbFilters.SelectedItem.ToString() == "Local Application ID") 
                {
                    dvLocalAppsList.RowFilter = $"LocalAppID = '{Convert.ToInt32(_Value)}'";
                }

                else dvLocalAppsList.RowFilter = $"{ColumnName} LIKE '{_Value}%'";
            }

            _ResetRecords(this, EventArgs.Empty);
        }
        private void _SetLocalAppsListHeaders()
        {
            dgvLocalAppsList.Columns[0].HeaderText = "Local Application ID";

            dgvLocalAppsList.Columns[1].HeaderText = "Driving Class";

            dgvLocalAppsList.Columns[2].HeaderText = "National Number";

            dgvLocalAppsList.Columns[3].HeaderText = "Full Name";

            dgvLocalAppsList.Columns[4].HeaderText = "Application Date";

            dgvLocalAppsList.Columns[5].HeaderText = "Passed Tests";

            dgvLocalAppsList.Columns[6].HeaderText = "Status";
        }
        private void _RefreshLocalAppsList(object sender, EventArgs e)
        {
            dtLocalAppsList = clLocalApplication.GetAllLocalAppsList();
            dvLocalAppsList = dtLocalAppsList.DefaultView;
            dgvLocalAppsList.DataSource = dvLocalAppsList;
        }
        private void _FillComboBoxList()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("Local Application ID");
            cbFilters.Items.Add("National Number");
            cbFilters.Items.Add("Full Name");
            cbFilters.Items.Add("Status");
        }
        private void _LoadLocalAppsList()
        {
            if (dtLocalAppsList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvLocalAppsList.DataSource = dvLocalAppsList;

                _SetLocalAppsListHeaders();
            }

        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvLocalAppsList.RowCount.ToString()}";
        }

        private void _HandleTestsEnablity(bool VisionTestEnablity, bool WrittenTestEnablity, bool StreetTestEnablity)
        {
            opSchduleVisionTest.Enabled = VisionTestEnablity;
            opSchduleWrittenTest.Enabled = WrittenTestEnablity;
            opSchduleStreetTest.Enabled = StreetTestEnablity;

        }
        private void _ResetcmsOptions()
        {
            opShowAppDetails.Enabled = true;
            opEditApplication.Enabled = true;
            opDeleteApplication.Enabled = true;
            opCancelApplication.Enabled = true;
            opSchduleTests.Enabled = true;
            opIssueDrivingLicenseFirstTime.Enabled = true;
            opShowLicense.Enabled = true;
            opShowPersonLicenseHistory.Enabled = true;
        }
        private void _HandleEnablityOptions()
        {
            int LocalAppID = Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value);
            int PassedTests = Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells["PassedTestCount"].Value);
            
            clLocalApplication LocalApp = clLocalApplication.FindByLocalAppID(LocalAppID);           

            _ResetcmsOptions();

            bool IsPassedVisionTest  = LocalApp.DoesPassedTestType(clTestType.eTestType.Vision);
            bool IsPassedWrittenTest = LocalApp.DoesPassedTestType(clTestType.eTestType.Written);
            bool IsPassedStreetTest  = LocalApp.DoesPassedTestType(clTestType.eTestType.Street);
            bool IsLicenseIssued     = LocalApp.IsLicenseIssued();

            clApplication.eApplicationStatus Status = LocalApp.ApplicationStatus;

            opEditApplication.Enabled = (Status == clApplication.eApplicationStatus.New && !IsPassedVisionTest && !LocalApp.HasAnyAppointment());
            
            opDeleteApplication.Enabled = ((Status == clApplication.eApplicationStatus.New || Status == clApplication.eApplicationStatus.Cancelled) && !IsPassedVisionTest && !LocalApp.HasAnyAppointment());

            opCancelApplication.Enabled = (Status == clApplication.eApplicationStatus.New && !IsPassedVisionTest);

            opSchduleTests.Enabled = (Status == clApplication.eApplicationStatus.New && !IsPassedStreetTest);

            opSchduleVisionTest.Enabled = (opSchduleTests.Enabled && !IsPassedVisionTest);

            opSchduleWrittenTest.Enabled = (opSchduleTests.Enabled && IsPassedVisionTest);

            opSchduleStreetTest.Enabled = (opSchduleTests.Enabled && IsPassedWrittenTest);

            opIssueDrivingLicenseFirstTime.Enabled = (Status == clApplication.eApplicationStatus.New && IsPassedStreetTest && !IsLicenseIssued);

            opShowLicense.Enabled = (Status == clApplication.eApplicationStatus.New && IsLicenseIssued);            
        }

        private void btnNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalApp frm = new frmAddUpdateLocalApp();
            frm.LocalApplicationDataSaved += WhenLocalAppInfoChanged;
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opShowAppDetails_Click(object sender, EventArgs e)
        {
            frmLocalAppInfo frm = new frmLocalAppInfo(Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value));
            frm.LocalAppInfoChanged += WhenLocalAppInfoChanged;            
            frm.ShowDialog();
        }
        private void opEditApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalApp frm = new frmAddUpdateLocalApp(Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value));
            frm.LocalApplicationDataSaved += WhenLocalAppInfoChanged;
            frm.ShowDialog();
        }
        private void opDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Application?",
               "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LocalAppID = Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value);

                clLocalApplication LocalApp = clLocalApplication.FindByLocalAppID(LocalAppID);
                if(LocalApp != null)
                {
                    try
                    {

                        if (LocalApp.Delete())
                        {
                            MessageBox.Show("Deleted successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshLocalAppsList(this, EventArgs.Empty);
                            _ResetRecords(this, EventArgs.Empty);
                        }

                        else MessageBox.Show("Application was not Deleted, Because it has data linked to it", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (SqlException)
                    {
                        MessageBox.Show("Could not delete the application", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Log Later
                    }
                }               
            }
        }
        private void opCancelApplication_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Are you sure you want to cancel this Application?",
            "Confirm Cancelation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LocalAppID = Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value);
                clLocalApplication LocalApplication = clLocalApplication.FindByLocalAppID(LocalAppID);
                if(LocalApplication != null)
                {
                        if (LocalApplication.Cancel())
                        {
                            MessageBox.Show("Application cancelled successfully",
                             "Cancelation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshLocalAppsList(this, null);
                            _ResetRecords(this, null);
                        }

                        else MessageBox.Show("Could not cancel the application",
                             "Cancelation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    

            }
        
        }

        private void UnImplementedFeatures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature didn't implemented yet", "UnImplemented Feature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterLocalAppsListRows(cbFilters.SelectedItem.ToString().Replace(" ", ""), tbUserFilterationValue.Text);

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbUserFilterationValue.Visible = false;
            }

            else
            {
                tbUserFilterationValue.Visible = true;
                tbUserFilterationValue.Text = string.Empty;
                tbUserFilterationValue.Focus();
            }

        }
        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "Local Application ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            }

        }
        private void cmsApplicationOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLocalAppsList.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            _HandleEnablityOptions();

        }

        private void frmLocalAppsList_Load(object sender, EventArgs e)
        {
            _FillComboBoxList();
            _LoadLocalAppsList();
            _ResetRecords(this, EventArgs.Empty);

            cbFilters.SelectedIndex = 0;

        }
        private void WhenLocalAppInfoChanged(object sender, EventArgs e)
        {
            _RefreshLocalAppsList(sender, EventArgs.Empty);
            _ResetRecords(sender, EventArgs.Empty);
        }

        private void opSchduleVisionTest_Click(object sender, EventArgs e)
        {
            frmTestAppointmentsList frm = new frmTestAppointmentsList(Convert.ToInt32(dgvLocalAppsList.CurrentRow.Cells[0].Value),
                clTestType.eTestType.Vision);
            frm.ShowDialog();
        }
    }
}

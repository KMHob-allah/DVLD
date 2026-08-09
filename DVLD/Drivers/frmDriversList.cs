using DVLD.Licenses;
using DVLD.People;
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

namespace DVLD.Drivers
{
    public partial class frmDriversList : Form
    {
        static private DataTable dtDriversList = clDriver.GetAllDrivers();
        static private DataView dvDriversList = dtDriversList.DefaultView;

        public frmDriversList()
        {
            InitializeComponent();
        }

        private void _SetDriverListHeaders()
        {
            dgvDriversList.Columns[0].HeaderText = "Driver ID";

            dgvDriversList.Columns[1].HeaderText = "Person ID";

            dgvDriversList.Columns[2].HeaderText = "National Number";

            dgvDriversList.Columns[3].HeaderText = "Full Name";

            dgvDriversList.Columns[4].HeaderText = "Date";

            dgvDriversList.Columns[5].HeaderText = "Active Licenses";

        }
        private void _LoadDriversList()
        {
            if (dtDriversList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvDriversList.DataSource = dvDriversList;

                _SetDriverListHeaders();
            }

        }
        private void _ResetRecords()
        {
            lblRecords.Text = $"# Records: {dgvDriversList.RowCount.ToString()}";
        }       
        private void _FillcbFilters()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("Driver ID");
            cbFilters.Items.Add("Person ID");
            cbFilters.Items.Add("National Number");
            cbFilters.Items.Add("Full Name");
            cbFilters.SelectedIndex = 0;
        }
        private void _RefreshPeopleList(object sender, EventArgs e)
        {
            dtDriversList = clDriver.GetAllDrivers();
            dvDriversList = dtDriversList.DefaultView;
            dgvDriversList.DataSource = dvDriversList;
            _ResetRecords();
        }



        private void _FilterLocalAppListRows(string ColumnName, string Value)
        {
            string _ColumnName = ColumnName.Replace(" ", "");
            string _Value = Value.Trim();

            if (tbUserFilterationValue.Text == string.Empty)
            {
                dvDriversList.RowFilter = string.Empty;
            }

            else
            {
                if (cbFilters.SelectedItem.ToString() == "Driver ID" || cbFilters.SelectedItem.ToString() == "Person ID")
                {
                    dvDriversList.RowFilter = $"[{_ColumnName}] = '{Convert.ToInt32(_Value)}'";
                }
                else
                {
                    dvDriversList.RowFilter = $"[{_ColumnName}] LIKE '{_Value}%'";
                }
            }

            _ResetRecords();
        }

        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterLocalAppListRows(cbFilters.SelectedItem.ToString(), tbUserFilterationValue.Text.Trim());

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() != "None")
            {
                tbUserFilterationValue.Visible = true;
                tbUserFilterationValue.Text = string.Empty;
                tbUserFilterationValue.Focus();
            }

            else tbUserFilterationValue.Visible = false;
        }

        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "Driver ID" || cbFilters.SelectedItem.ToString() == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDriversList_Load(object sender, EventArgs e)
        {
            _LoadDriversList();
            _FillcbFilters();
            _ResetRecords();
        }

        private void opShowPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(Convert.ToInt32(dgvDriversList.CurrentRow.Cells["PersonID"].Value));
            frm.PersonInfo_Changed += _RefreshPeopleList;
            frm.Show();
        }

        private void opShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(Convert.ToInt32(dgvDriversList.CurrentRow.Cells["PersonID"].Value));
            frm.Show();
        }

        private void UnImplementedFeatures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature didn't implemented yet", "UnImplemented Feature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmsDriverOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDriversList.Rows.Count == 0)
            {
                e.Cancel = true;
            }
        
    }
    }
}

using DVLD.Applications.InternationalLicenses;
using DVLD.People;
using DVLD.Users;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.InternationalLicenses
{
    public partial class frmInternationalLicensesList : Form
    {

        static private DataTable dtInternationalLicenses = clInternationalLicense.GetAllInternationalLicenses();
        static private DataView dvInternationalLicenses = dtInternationalLicenses.DefaultView;

        public frmInternationalLicensesList()
        {
            InitializeComponent();
        }


        private void _FillcbActivationStatusList()
        {
            cbActivationStatus.Items.Add("All");
            cbActivationStatus.Items.Add("Yes");
            cbActivationStatus.Items.Add("No");

            cbActivationStatus.SelectedIndex = 0;
        }
        private void _FillcbFiltersList()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("International License ID");
            cbFilters.Items.Add("Application ID");
            cbFilters.Items.Add("Driver ID");
            cbFilters.Items.Add("Local License ID");
            cbFilters.Items.Add("IsActive");
            cbFilters.SelectedIndex = 0;
        }
        private void _SetdgvInternationalLicensesListHeaders()
        {
            dgvInternationalLicenses.Columns[0].HeaderText = "International License ID";

            dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";

            dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
            
            dgvInternationalLicenses.Columns[3].HeaderText = "Local License ID";

            dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
            dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
            dgvInternationalLicenses.Columns[4].HeaderText = "Is Active";
        }
        private void _LoadInternationalLicensesList()
        {
            if (dtInternationalLicenses == null || dtInternationalLicenses.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvInternationalLicenses.DataSource = dvInternationalLicenses;

                _SetdgvInternationalLicensesListHeaders();
            }
        }
        private void _RefreshInternationalLicensesList(object sender, EventArgs e)
        {
            dtInternationalLicenses = clUser.GetAllUsers();
            dvInternationalLicenses = dtInternationalLicenses.DefaultView;

            _LoadInternationalLicensesList();
        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvInternationalLicenses.RowCount.ToString()}";
        }
        private void _FilterUsersListRows(string ColumnName, string Value)
        {
            string _Value = Value.Trim();
            string _ColumnName = ColumnName.Replace(" ", "");

            if (string.IsNullOrEmpty(_Value))
            {
                dvInternationalLicenses.RowFilter = string.Empty;
                return;
            }

            switch (_ColumnName)
            {
                case "None":
                    {
                        dvInternationalLicenses.RowFilter = string.Empty;
                        break;
                    }

                case "IsActive":
                    {
                        if (string.IsNullOrEmpty(_Value)) dvInternationalLicenses.RowFilter = string.Empty;

                        else dvInternationalLicenses.RowFilter = $"{_ColumnName} = {Convert.ToByte(_Value)}";

                        break;
                    }

                default: 
                    {
                        if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "InternationalLicenseID" || 
                            cbFilters.SelectedItem.ToString().Replace(" ", "") == "ApplicationID" ||
                            cbFilters.SelectedItem.ToString().Replace(" ", "") == "DriverID" ||
                            cbFilters.SelectedItem.ToString().Replace(" ", "") == "LocalLicenseID")
                        {
                            dvInternationalLicenses.RowFilter = $"{_ColumnName} = '{Convert.ToInt32(_Value)}'";
                        }

                        else dvInternationalLicenses.RowFilter = $"{_ColumnName} LIKE '{_Value}%'";

                        break;
                    }

            }
        }
          
      
        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "InternationalLicenseID" ||
                cbFilters.SelectedItem.ToString().Replace(" ", "") == "ApplicationID" ||
                cbFilters.SelectedItem.ToString().Replace(" ", "") == "DriverID" ||
                cbFilters.SelectedItem.ToString().Replace(" ", "") == "LocalLicenseID"
                )
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            }
        }
        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterUsersListRows(cbFilters.SelectedItem.ToString(), tbUserFilterationValue.Text);
            _ResetRecords(this, EventArgs.Empty);
        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbUserFilterationValue.Visible = false;
                cbActivationStatus.Visible = false;
                dvInternationalLicenses.RowFilter = string.Empty;
                return;
            }


            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "IsActive")
            {
                tbUserFilterationValue.Visible = false;
                cbActivationStatus.Visible = true;
                cbActivationStatus.SelectedIndex = 0; // All
                cbActivationStatus.Focus();

            }

            else
            {
                tbUserFilterationValue.Visible = true;
                cbActivationStatus.Visible = false;
                tbUserFilterationValue.Text = string.Empty;
                tbUserFilterationValue.Focus();
            }

            dvInternationalLicenses.RowFilter = string.Empty;
        }
        private void cbActivationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbActivationStatus.SelectedItem.ToString())
            {
                case "All":
                    {
                        _FilterUsersListRows(cbFilters.SelectedItem.ToString(), ""); // All
                        break;
                    }

                case "Yes":
                    {
                        _FilterUsersListRows(cbFilters.SelectedItem.ToString(), "1"); // Yes
                        break;
                    }

                case "No":
                    {
                        _FilterUsersListRows(cbFilters.SelectedItem.ToString(), "0"); // No
                        break;
                    }
            }

            _ResetRecords(this, EventArgs.Empty);
        }

        private void opShowPersonDetails_Click(object sender, EventArgs e)
        {
            clDriver Driver = clDriver.FindByDriverID(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells["DriverID"].Value));

            frmPersonInfo frm = new frmPersonInfo(Driver.PersonID);
            frm.Show();
        }
        private void opShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells["InternationalLicenseID"].Value));
            frm.Show();
        }
        private void opShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clDriver Driver = clDriver.FindByDriverID(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells["DriverID"].Value));

            frmLicenseHistory frm = new frmLicenseHistory(Driver.PersonID);
            frm.Show();
        }

        private void frmInternationalLicensesList_Load(object sender, EventArgs e)
        {
            _FillcbFiltersList();
            _FillcbActivationStatusList();
            _LoadInternationalLicensesList();
            _ResetRecords(this, EventArgs.Empty);
        }

        private void btnAddInternationaLicense_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.InternationalLicenseAdded += _RefreshInternationalLicensesList;
            frm.InternationalLicenseAdded += _ResetRecords;
            frm.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

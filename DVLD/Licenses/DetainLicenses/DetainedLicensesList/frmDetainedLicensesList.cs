using DVLD.Applications.ReleaseLicenses;
using DVLD.Licenses.LocalLicenses;
using DVLD.People;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD.Licenses.DetainLicenses.DetainedLicensesList
{
    public partial class frmDetainedLicensesList : Form
    {
        static private DataTable dtDetainedLicenses = clDetainLicense.GetAllDetainedLicenses();
        static private DataView dvDetainedLicenses = dtDetainedLicenses.DefaultView;

        public frmDetainedLicensesList()
        {
            InitializeComponent();
        }

        private void _SetDetainedLicensesListHeaders()
        {
            dgvDetainedLicenses.Columns[0].HeaderText = "Detain ID";

            dgvDetainedLicenses.Columns[1].HeaderText = "License ID";

            dgvDetainedLicenses.Columns[2].HeaderText = "Detain Date";

            dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";

            dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";

            dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";

            dgvDetainedLicenses.Columns[6].HeaderText = "National Number";

            dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";

            dgvDetainedLicenses.Columns[8].HeaderText = "Release Application ID";         
        }
        private void _FillComboBoxList()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("Detain ID");
            cbFilters.Items.Add("Is Released");
            cbFilters.Items.Add("National Number");
            cbFilters.Items.Add("Full Name");
            cbFilters.Items.Add("Release Application ID");
            cbFilters.SelectedIndex = 0;
        }
        private void _FillcbReleaseList()
        {
            cbReleaseList.Items.Add("All");
            cbReleaseList.Items.Add("Yes");
            cbReleaseList.Items.Add("No");

            cbReleaseList.SelectedIndex = 0;
        }
        private void _LoadDetainedLicensesList()
        {
            if (dtDetainedLicenses == null || dtDetainedLicenses.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvDetainedLicenses.DataSource = dvDetainedLicenses;

                _SetDetainedLicensesListHeaders();
            }

        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvDetainedLicenses.RowCount.ToString()}";
        }
        private void _FilterDetainedLicensesListRows(string ColumnName, string Value)
        {
            string _Value = Value.Trim();
            string _ColumnName = ColumnName.Replace(" ", "");

            if (string.IsNullOrEmpty(_Value))
            {
                dvDetainedLicenses.RowFilter = string.Empty;
                return;
            }

            switch (_ColumnName)
            {
                case "None":
                {
                    dvDetainedLicenses.RowFilter = string.Empty;
                    break;
                }

                case "IsReleased":
                {
                    if (string.IsNullOrEmpty(_Value)) dvDetainedLicenses.RowFilter = string.Empty;

                    else dvDetainedLicenses.RowFilter = $"{_ColumnName} = {Convert.ToByte(_Value)}";

                    break;
                }

                default: 
                {
                    if (tbUserFilterationValue.Text == string.Empty) dvDetainedLicenses.RowFilter = string.Empty;

                    else
                    {
                        if (_ColumnName == "DetainID" || _ColumnName == "ReleaseApplicationID") dvDetainedLicenses.RowFilter = $"{_ColumnName} = '{Convert.ToInt32(_Value)}'";

                        else dvDetainedLicenses.RowFilter = $"{_ColumnName} LIKE '{_Value}%'";
                    }

                    break;
                }

            }     
            
            _ResetRecords(this, EventArgs.Empty);
        }
        private void _RefreshPeopleList(object sender, EventArgs e)
        {
            dtDetainedLicenses = clPerson.GetAllPeopleList();
            dvDetainedLicenses = dtDetainedLicenses.DefaultView;
            dgvDetainedLicenses.DataSource = dvDetainedLicenses;

            _LoadDetainedLicensesList();
        }
        private void WhenLicenseDataChanged(object sender, EventArgs e)
        {
            _RefreshPeopleList(sender, EventArgs.Empty);
            _ResetRecords(sender, EventArgs.Empty);
        }     

       
        private void frmDetainedLicensesList_Load(object sender, EventArgs e)
        {
            _FillComboBoxList();
            _FillcbReleaseList();
            _LoadDetainedLicensesList();
            _ResetRecords(this, EventArgs.Empty);

            cbFilters.SelectedIndex = 0;
        }

        private void cbReleaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbReleaseList.SelectedItem.ToString())
            {
                case "All":
                    {
                        _FilterDetainedLicensesListRows(cbFilters.SelectedItem.ToString(), ""); // All
                        break;
                    }

                case "Yes":
                    {
                        _FilterDetainedLicensesListRows(cbFilters.SelectedItem.ToString(), "1"); // Yes
                        break;
                    }

                case "No":
                    {
                        _FilterDetainedLicensesListRows(cbFilters.SelectedItem.ToString(), "0"); // No
                        break;
                    }
            }

            _ResetRecords(this, EventArgs.Empty);
        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbUserFilterationValue.Visible = false;
                cbReleaseList.Visible = false;
                dvDetainedLicenses.RowFilter = string.Empty;
                return;
            }


            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "IsReleased")
            {
                tbUserFilterationValue.Visible = false;
                cbReleaseList.Visible = true;
                cbReleaseList.SelectedIndex = 0; // All
                cbReleaseList.Focus();

            }

            else
            {
                tbUserFilterationValue.Visible = true;
                cbReleaseList.Visible = false;
                tbUserFilterationValue.Text = string.Empty;
                tbUserFilterationValue.Focus();
            }

            dvDetainedLicenses.RowFilter = string.Empty;
        }

        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterDetainedLicensesListRows(cbFilters.SelectedItem.ToString().Replace(" ", ""), tbUserFilterationValue.Text);

        }
        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "DetainID" ||
                cbFilters.SelectedItem.ToString().Replace(" ","") == "ReleaseApplicationID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            }
        }


        private void cmsLicenseOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            if (Convert.ToBoolean(dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value )== true)
            {
                opReleaseDetainedLicense.Enabled = false;
            }
            else opReleaseDetainedLicense.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.LicenseReleased += WhenLicenseDataChanged;
            frm.Show();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.LicenseDetained += WhenLicenseDataChanged;
            frm.Show();
        }


        private void opShowPersonDetails_Click(object sender, EventArgs e)
        {
            clPerson Person = clPerson.Find(dgvDetainedLicenses.CurrentRow.Cells["NationalNumber"].Value.ToString());

            frmPersonInfo frm = new frmPersonInfo(Person.PersonID);

            frm.PersonInfo_Changed += WhenLicenseDataChanged;

            frm.Show();
        }
        private void opShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value));
            frm.Show();
        }
        private void opShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clPerson Person = clPerson.Find(dgvDetainedLicenses.CurrentRow.Cells["NationalNumber"].Value.ToString());

            frmLicenseHistory frm = new frmLicenseHistory(Person.PersonID);
            frm.Show();
        }
        private void opReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value));
            frm.LicenseReleased += WhenLicenseDataChanged;
            frm.Show();
        }

    }
}

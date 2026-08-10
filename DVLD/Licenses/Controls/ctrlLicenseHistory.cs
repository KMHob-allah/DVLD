using DVLD.Licenses.LocalLicenses;
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

namespace DVLD.Licenses.Controls
{
    public partial class ctrlLicenseHistory : UserControl
    {
        private DataTable dtLocalLicensesList;
        private DataTable dtInternationalLicensesList;

        clPerson Person;
        clDriver Driver;
      
        public ctrlLicenseHistory()
        {
            InitializeComponent();
        }

        private void _SetLocalLicensesListHeaders()
        {
            dgvLocalLicenses.Columns[0].HeaderText = "License ID";

            dgvLocalLicenses.Columns[1].HeaderText = "Application ID";

            dgvLocalLicenses.Columns[2].HeaderText = "Class Name";

            dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";

            dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";

            dgvLocalLicenses.Columns[5].HeaderText = "Is Active";

          
        }
        private void _SetInternationalLicensesListHeaders()
        {
            dgvInternationalLicenses.Columns[0].HeaderText = "International License ID";

            dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";

            dgvInternationalLicenses.Columns[2].HeaderText = "Local License ID";

            dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";

            dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";

            dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";


        }

        private void _ResetLocalLicensesRecords()
        {
            lblLocalLicensesRecords.Text = $"# Records: {dgvLocalLicenses.RowCount.ToString()}";
        }
        private void _ResetInternationalLicensesRecords()
        {
            lblInternationalLicensesRecords.Text = $"# Records: {dgvInternationalLicenses.RowCount.ToString()}";
        }

        private void _LoadLocalLicenses()
        {
            dtLocalLicensesList = clDriver.GetLocalLicenses(Driver.ID);

            if (dtLocalLicensesList == null || dtLocalLicensesList.Rows.Count == 0) lblNoLocalLicenses.Visible = true;

            else
            {
                lblNoLocalLicenses.Visible = false;
                dgvLocalLicenses.DataSource = dtLocalLicensesList;

                _SetLocalLicensesListHeaders();
            }

            _ResetLocalLicensesRecords();
        }
        private void _LoadInternationalLicenses()
        {
            dtInternationalLicensesList = clDriver.GetInternationalLicenses(Driver.ID);

            if (dtInternationalLicensesList == null || dtInternationalLicensesList.Rows.Count == 0) lblNoInternationalLicenses.Visible = true;

            else
            {
                lblNoInternationalLicenses.Visible = false;
                dgvInternationalLicenses.DataSource = dtInternationalLicensesList;

                _SetInternationalLicensesListHeaders();
            }

            _ResetInternationalLicensesRecords();
        }

        public void LoadLicensesHistory(int PersonID)
        {
            Person = clPerson.Find(PersonID);
            
            if (Person == null)
            {
                MessageBox.Show("Could not find this person ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Driver = clDriver.FindByPersonID(Person.PersonID);

            if (Driver == null)
            {
                MessageBox.Show("Could not find driver licenses history", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicenses();

            _LoadInternationalLicenses();            
        }

        private void opShowLicenseDetails_Click(object sender, EventArgs e)
        {
            if(tcDriverLicenses.SelectedTab == tpLocalLicenses)
            {
                frmLicenseInfo frm = new frmLicenseInfo((Convert.ToInt32(dgvLocalLicenses.CurrentRow.Cells[0].Value)));
                frm.Show();
            }

            // working here
        }

        private void cmsLicenseOptions_Opening(object sender, CancelEventArgs e)
        {
            if (tcDriverLicenses.SelectedTab == tpLocalLicenses)
            {
                if (dgvLocalLicenses.Rows.Count == 0)
                {
                    e.Cancel = true;
                }
                else e.Cancel = false;
            }
            else e.Cancel = true;
        }
    }
}

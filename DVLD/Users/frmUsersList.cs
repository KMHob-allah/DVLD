using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmUsersList : Form
    {
        static private DataTable dtUsersList = clUser.GetAllUsers();
        static private DataView dvUsersList = dtUsersList.DefaultView;

        public frmUsersList()
        {
            InitializeComponent();
        }
       
        private void _FillcbFiltersList()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("Person ID");
            cbFilters.Items.Add("User ID");
            cbFilters.Items.Add("User Name");
            cbFilters.Items.Add("Full Name");
            cbFilters.Items.Add("IsActive");
            cbFilters.SelectedIndex = 0;
        }
        private void _FillcbActivationStatusList()
        {
            cbActivationStatus.Items.Add("All");
            cbActivationStatus.Items.Add("Yes");
            cbActivationStatus.Items.Add("No");

            cbActivationStatus.SelectedIndex = 0;
        }
        private void _SetdgvUsersListHeaders()
        {
            dgvUsersList.Columns[0].HeaderText = "Person ID";

            dgvUsersList.Columns[1].HeaderText = "User ID";

            dgvUsersList.Columns[2].HeaderText = "Full Name";

            dgvUsersList.Columns[3].HeaderText = "User Name";

            dgvUsersList.Columns[4].HeaderText = "Is Active";           
        }
        private void _LoadUsersList()
        {
            if (dtUsersList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;
                dgvUsersList.DataSource = dvUsersList;

                _SetdgvUsersListHeaders();
            }
        } 

        private void _RefreshUsersList(object sender, EventArgs e)
        {
            dtUsersList = clUser.GetAllUsers();
            dvUsersList = dtUsersList.DefaultView;

            _LoadUsersList();            
        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvUsersList.RowCount.ToString()}";
        }
        private void _FilterUsersListRows(string ColumnName, string Value)
        {
            string _Value = Value.Trim();
            string _ColumnName = ColumnName.Replace(" ", "");

            if(string.IsNullOrEmpty(_Value))
            {
                dvUsersList.RowFilter = string.Empty;
                return;
            }

            switch(_ColumnName)
            {
                case "None":
                {
                    dvUsersList.RowFilter = string.Empty;
                    break ;
                }

                case "IsActive":
                {
                    if (string.IsNullOrEmpty(_Value)) dvUsersList.RowFilter = string.Empty;

                    else dvUsersList.RowFilter = $"{_ColumnName} = {Convert.ToByte(_Value)}";

                    break;
                }

                default: // User Name, Full Name etc
                {
                    if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "PersonID" || cbFilters.SelectedItem.ToString().Replace(" ", "") == "UserID")
                    {
                        dvUsersList.RowFilter = $"{_ColumnName} = '{Convert.ToInt32(_Value)}'";
                    }                   

                    else dvUsersList.RowFilter = $"{_ColumnName} LIKE '{_Value}%'";

                    break;
                }

            }                                  
        }
        
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.UserDataSaved += _RefreshUsersList;
            frm.UserDataSaved += _ResetRecords;
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _FillcbFiltersList();
            _FillcbActivationStatusList();
            _LoadUsersList();
            _ResetRecords(this, EventArgs.Empty);
        }

        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "PersonID" 
                || 
                cbFilters.SelectedItem.ToString().Replace(" ", "") == "UserID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;                
            }

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbUserFilterationValue.Visible = false;
                cbActivationStatus.Visible = false;
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
            
            dvUsersList.RowFilter = string.Empty;

        }
        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterUsersListRows(cbFilters.SelectedItem.ToString(), tbUserFilterationValue.Text);
            _ResetRecords(this, EventArgs.Empty);
        }
        private void cbActivationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbActivationStatus.SelectedItem.ToString())
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

        private void opShowDetails_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(Convert.ToInt32(dgvUsersList.CurrentRow.Cells["UserID"].Value));
            // refresh when User Info Updated
            frm.ShowDialog();
        }
        private void opAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();

            frm.UserDataSaved += _RefreshUsersList;
            frm.UserDataSaved += _ResetRecords;

            frm.ShowDialog();
        }
        private void opEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(Convert.ToInt32(dgvUsersList.CurrentRow.Cells["UserID"].Value));
            frm.UserDataSaved += _RefreshUsersList;
            frm.UserDataSaved += _ResetRecords;
            frm.ShowDialog();

        }
        private void opSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature didn't implemented yet", "UnImplemented Feature", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void opSendSMS_Click(object sender, EventArgs e)
        {
           MessageBox.Show("This feature didn't implemented yet", "UnImplemented Feature", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void opDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (clUser.Delete(Convert.ToInt32(dgvUsersList.CurrentRow.Cells["UserID"].Value)))
                    {
                        MessageBox.Show("Deleted successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        _RefreshUsersList(this, EventArgs.Empty);
                        _ResetRecords(this, EventArgs.Empty);
                    }
                }

                catch (SqlException)
                {
                    MessageBox.Show("Connot delete this User becase it is linked to other records", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Log Later
                }

            }
        }
        private void opChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(Convert.ToInt32(dgvUsersList.CurrentRow.Cells["UserID"].Value));
            frm.ShowDialog();

        }

        private void cmsUserOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvUsersList.Rows.Count == 0)
            {
                e.Cancel = true;
            }
        }
    }
}

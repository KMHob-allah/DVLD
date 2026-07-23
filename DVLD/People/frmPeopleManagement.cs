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
using System.IO;
namespace DVLD.People
{
    public partial class frmPeopleManagement : Form
    {
        static private DataTable dtPeopleList = clPerson.GetAllPeopleList();
        static private DataView dvPeopleList = dtPeopleList.DefaultView;
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private void _FillComboBoxList()
        {
            cbFilters.Items.Add("None");
            cbFilters.Items.Add("Person ID");
            cbFilters.Items.Add("National Number");
            cbFilters.Items.Add("First Name");
            cbFilters.Items.Add("Second Name");
            cbFilters.Items.Add("Third Name");
            cbFilters.Items.Add("Last Name");
            cbFilters.Items.Add("Gender");
            cbFilters.Items.Add("Nationality");
            cbFilters.Items.Add("Phone");
            cbFilters.Items.Add("Email");       
        }
        private void _SetdgvPeopleListHeaders()
        {
            dgvPeopleList.Columns[0].HeaderText = "Person ID";

            dgvPeopleList.Columns[1].HeaderText = "National Number";

            dgvPeopleList.Columns[2].HeaderText = "First Name";

            dgvPeopleList.Columns[3].HeaderText = "Second Name";

            dgvPeopleList.Columns[4].HeaderText = "Third Name";

            dgvPeopleList.Columns[5].HeaderText = "Last Name";

            dgvPeopleList.Columns[6].HeaderText = "Gender";

            dgvPeopleList.Columns[7].HeaderText = "BirthDate";

            dgvPeopleList.Columns[8].HeaderText = "Nationality";

            dgvPeopleList.Columns[9].HeaderText = "Phone";

            dgvPeopleList.Columns[10].HeaderText = "Email";
        }
        private void _LoadPeopleList()
        {
            if (dtPeopleList.Rows.Count == 0) lblNoData.Visible = true;
            
            else
            {
                lblNoData.Visible = false;
                dgvPeopleList.DataSource = dvPeopleList;

                _SetdgvPeopleListHeaders();
            }

        }
        private void _ResetRecords(object sender, EventArgs e)
        {
            lblRecords.Text = $"# Records: {dgvPeopleList.RowCount.ToString()}";
        }
        private void _FilterPeopleListRows(string ColumnName, string Value)
        {
            if (tbUserFilterationValue.Text == string.Empty) dvPeopleList.RowFilter = string.Empty;            

            else
            {
                if (cbFilters.SelectedItem.ToString() == "PersonID") dvPeopleList.RowFilter = $"{ColumnName} = '{Convert.ToInt32(Value)}'";
               
                else dvPeopleList.RowFilter = $"{ColumnName} LIKE '{Value}%'";               
            }

            _ResetRecords(this, EventArgs.Empty);
        }
        private void _RefreshPeopleList(object sender, EventArgs e)
        {
            dtPeopleList = clPerson.GetAllPeopleList();
            dvPeopleList = dtPeopleList.DefaultView;
            dgvPeopleList.DataSource = dvPeopleList;
        }


        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            _FillComboBoxList();
            _LoadPeopleList();
            _ResetRecords(this, EventArgs.Empty);

            cbFilters.SelectedIndex = 0;
        }
        private void WhenPerson_AddedOrUpdated(object sender, int PersonID)
        {
            _RefreshPeopleList(sender, EventArgs.Empty);
            _ResetRecords(sender, EventArgs.Empty);
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
        private void tbUserFilterationValue_TextChanged(object sender, EventArgs e)
        {
            _FilterPeopleListRows(cbFilters.SelectedItem.ToString().Replace(" ",""), tbUserFilterationValue.Text);
        }

        private void tbUserFilterationValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString().Replace(" ", "") == "PersonID" || cbFilters.SelectedItem.ToString() == "Phone")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();

            frm.PersonDataSaved += WhenPerson_AddedOrUpdated;            

            frm.ShowDialog();
        }
        private void opShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(Convert.ToInt32(dgvPeopleList.CurrentRow.Cells["PersonID"].Value));

            frm.PersonInfo_Changed += _RefreshPeopleList;
            frm.PersonInfo_Changed += _ResetRecords;

            frm.ShowDialog();
        }
        private void opDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int PersonID = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells["PersonID"].Value);

                try
                {
                    clPerson Person = clPerson.Find(PersonID);
                    string ImagePath = Person.ImagePath;

                    if (clPerson.Delete(PersonID))
                    {

                        if(!string.IsNullOrEmpty(Person.ImagePath)) 
                        {
                            try
                            {
                                File.Delete(ImagePath);
                            }

                            catch(IOException)
                            {
                                // Log Later
                            }
                        }

                        MessageBox.Show("Deleted successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshPeopleList(this, EventArgs.Empty);
                        _ResetRecords(this, EventArgs.Empty);
                    }
                    
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Log Later
                }              
            }
        }
        private void opAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.PersonDataSaved += WhenPerson_AddedOrUpdated;
            frm.ShowDialog();

        }
        private void opEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(Convert.ToInt32(dgvPeopleList.CurrentRow.Cells["PersonID"].Value));
            frm.PersonDataSaved += WhenPerson_AddedOrUpdated;
            frm.ShowDialog();
        }
        private void UnImplementedFeatures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature didn't implemented yet", "UnImplemented Feature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmsPersonOptions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPeopleList.Rows.Count == 0)
            { 
                e.Cancel = true;
            }
        }
    }
}

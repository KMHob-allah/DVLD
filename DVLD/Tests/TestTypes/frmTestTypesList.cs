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

namespace DVLD.Tests.TestTypes
{
    public partial class frmTestTypesList : Form
    {
        public frmTestTypesList()
        {
            InitializeComponent();
        }

        private void _ResetRecords()
        {
            lblRecords.Text = $"# Records: {dgvTestTypesList.Rows.Count.ToString()}";
        }
        private void _SetTestTypesListHeaders()
        {
            dgvTestTypesList.Columns[0].HeaderText = "ID";

            dgvTestTypesList.Columns[1].HeaderText = "Title";

            dgvTestTypesList.Columns[2].HeaderText = "Description";

            dgvTestTypesList.Columns[3].HeaderText = "Fees";
        }    
        private void _LoadTestTypesList(object sender, EventArgs e)
        {
            dgvTestTypesList.DataSource = clTestType.GetAllTestTypes();

            if (dgvTestTypesList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;

                _SetTestTypesListHeaders();
            }
        }

        private void opEditType_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((clTestType.eTestType)Convert.ToInt32(dgvTestTypesList.CurrentRow.Cells["TestTypeID"].Value));
            frm.TestType_DataChanged += _LoadTestTypesList;
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypesList_Load(object sender, EventArgs e)
        {
            _LoadTestTypesList(this, null);
            _ResetRecords();
        }
    }
}

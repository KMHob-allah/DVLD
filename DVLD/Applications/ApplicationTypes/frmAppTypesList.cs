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

namespace DVLD.Applications.ApplicationTypes
{
    public partial class frmAppTypesList : Form
    {
        public frmAppTypesList()
        {
            InitializeComponent();
        }

        private void _ResetRecords()
        {
            lblRecords.Text = $"# Records: {dgvAppTypesList.RowCount.ToString()}";
        }
        private void _SetAppTypesListHeaders()
        {
            dgvAppTypesList.Columns[0].HeaderText = "ID";

            dgvAppTypesList.Columns[1].HeaderText = "Title";

            dgvAppTypesList.Columns[2].HeaderText = "Fees";           
        }
        private void _LoadApplicationTypesList(object sender, EventArgs e)
        {
            dgvAppTypesList.DataSource = clApplicationType.GetAllAppTypes();
            
            if (dgvAppTypesList.Rows.Count == 0) lblNoData.Visible = true;

            else
            {
                lblNoData.Visible = false;

                _SetAppTypesListHeaders();
            }
        }
                   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opEditType_Click(object sender, EventArgs e)
        {
            frmUpdateAppType frm = new frmUpdateAppType((clApplicationType.eApplicationType)dgvAppTypesList.CurrentRow.Cells["ApplicationTypeID"].Value);
            
            frm.ApplicationType_DataChanged += _LoadApplicationTypesList;
           
            frm.ShowDialog();
        }

        private void frmAppTypesList_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypesList(this , null);
            _ResetRecords();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();

            //frm.PersonDataSaved += _RefreshPeopleList(this, EventArgs.Empty);
            //frm.PersonDataSaved += _ResetRecords(this, EventArgs.Empty);

            frm.ShowDialog();
        }

        private void opShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(Convert.ToInt32(dgvPeopleList.CurrentRow.Cells["PersonID"].Value));
            //frm.PersonInfo_Changed += _RefreshPeopleList(this, EventArgs.Empty);
            //frm.PersonDataSaved += _ResetRecords(this, EventArgs.Empty);

            frm.ShowDialog();
        }
    }
}

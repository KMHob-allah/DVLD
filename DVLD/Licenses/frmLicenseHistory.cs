using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmLicenseHistory : Form
    {
        int PersonID;
        public frmLicenseHistory(int PersonID)
        {
            this.PersonID = PersonID;
            InitializeComponent();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            ctrlLicenseHistory1.LoadLicensesHistory(PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

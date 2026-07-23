using DVLD.People.Controls;
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
    public partial class frmPersonInfo : Form
    {
        public event EventHandler PersonInfo_Changed;
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();

            ctrlPersonCard1.PersonCardChanged += PersonData_Changed;
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PersonData_Changed(object sender, EventArgs e)
        {
            PersonInfo_Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}

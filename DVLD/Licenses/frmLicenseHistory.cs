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
    }
}

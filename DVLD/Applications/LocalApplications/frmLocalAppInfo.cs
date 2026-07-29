using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalApplications
{
    public partial class frmLocalAppInfo : Form
    {
        public frmLocalAppInfo(int LocalAppID)
        {
            ctrlLocalAppCard1.LoadLocalAppInfo(LocalAppID);

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

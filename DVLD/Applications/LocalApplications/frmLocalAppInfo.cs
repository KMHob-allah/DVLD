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
        public event EventHandler LocalAppInfoChanged;
        public frmLocalAppInfo(int LocalAppID)
        {

            InitializeComponent();
            ctrlLocalAppCard1.LocalApplicationInfoChanged += WhenLocalApp_DataChanged;
            ctrlLocalAppCard1.LoadLocalAppInfo(LocalAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhenLocalApp_DataChanged(object sender, EventArgs e)
        {
            LocalAppInfoChanged?.Invoke(this, EventArgs.Empty);
        }

    }
}

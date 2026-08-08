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

namespace DVLD.Licenses.LocalLicenses.Controls
{
    public partial class ctrlLicenseCardWithFilter : UserControl
    {
        public event Action<int> LicenseSelected;

        private bool _FilterEnabled = true;

        public clLicense Licenseinfo
        {
            get { return ctrlLicenseCard1.License; }
        }
        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }

            get { return _FilterEnabled; }
        }

        public ctrlLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlLicenseCardWithFilter_Load(object sender, EventArgs e)
        {
            tbLicenseID.Focus();
            ctrlLicenseCard1._SetDefaultValues();
        }      
        public void LoadLicenseInfo(int LicenseID)
        {
            tbLicenseID.Text = LicenseID.ToString();
            ctrlLicenseCard1.LoadLicenseInfo(LicenseID);

            if (ctrlLicenseCard1.License != null) WhenLicenseSelected(ctrlLicenseCard1.License.LicenseID);
        }

        protected virtual void WhenLicenseSelected(int LicenseID)
        {
            LicenseSelected?.Invoke(LicenseID);
        }   
        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) btnSearch.PerformClick();

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLicenseID.Text.Trim())) return;
            
            int LicenseID = Convert.ToInt32(tbLicenseID.Text.Trim());

            ctrlLicenseCard1.LoadLicenseInfo(LicenseID);

            WhenLicenseSelected(LicenseID);
        }
    }
}


using DVLD.People;
using DVLD.People.Controls;
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
    public partial class ctrlLIcenseInfoWithFilter : UserControl
    {
        //public event Action<int> LicenseSelected;


        //private bool _FilterEnabled = true;


        ////public clLicense Licenseinfo
        ////{
        ////    get { return ctrlLicenseInfo1.License; }
        ////}
        ////public bool FilterEnabled
        ////{
        ////    set
        ////    {
        ////        _FilterEnabled = value;
        ////        gbFilter.Enabled = _FilterEnabled;
        ////    }

        ////    get {return _FilterEnabled;}
        ////}


        public ctrlLIcenseInfoWithFilter()
        {
            InitializeComponent();
        }

        //private void ctrlLIcenseInfoWithFilter_Load(object sender, EventArgs e)
        //{
        //    tbLicenseID.Focus();
        //    ctrlLicenseInfo1._SetDefaultValues();
        //}
        //public void LoadLicenseInfo(int LicenseID)
        //{
        //    tbLicenseID.Text = LicenseID.ToString();
        //    ctrlLicenseInfo1.LoadLicenseInfo(LicenseID);
        //}             



        //protected virtual void WhenLicenseSelected(int LicenseID)
        //{
        //    LicenseSelected?.Invoke(LicenseID);
        //}
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    ctrlLicenseInfo1.LoadLicenseInfo(Convert.ToInt32(tbLicenseID.Text.Trim()));

        //}       
        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  btnSearch.PerformClick();           

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

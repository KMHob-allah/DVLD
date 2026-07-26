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

namespace DVLD.Applications
{
    public partial class frmUpdateAppType : Form
    {
        public event EventHandler ApplicationType_DataChanged;

        clApplicationType _ApplicationType;
        int _AppTypeID;

        public frmUpdateAppType(int AppTypeID)
        {
            _AppTypeID = AppTypeID;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the errors first", "Fix Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillTypeInfo();

            if (_ApplicationType.UpdateTypeInfo())
            {
                MessageBox.Show("Application Type Info Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                ApplicationType_DataChanged?.Invoke(this, EventArgs.Empty);
            }

            else MessageBox.Show("Application Type Info was not Updated", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateAppType_Load(object sender, EventArgs e)
        {
            _ApplicationType = clApplicationType.Find(_AppTypeID);

            if (_ApplicationType != null)
            {
                lblTypeIDValue.Text = _ApplicationType.ID.ToString();
                tbTitleValue.Text = _ApplicationType.Title.ToString();
                tbFeesValue.Text = _ApplicationType.Fees.ToString();
            }

            else
            {
                _SetInitValues();
            }

            btnSave.Enabled = false;
        }

        private void EditApplicationType_DataChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) btnSave.Enabled = true;
        }
        private void _SetInitValues()
        {

            lblTypeIDValue.Text = "???";
            tbTitleValue.Text = string.Empty;
            tbFeesValue.Text = string.Empty;
        }
        private void _FillTypeInfo()
        {
            _ApplicationType.Title = tbTitleValue.Text.Trim();
            _ApplicationType.Fees = Convert.ToSingle(tbFeesValue.Text.Trim());
        }
     
        private void tbFeesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDigitOrControl = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);

            bool IsDecimalPoint = (e.KeyChar == '.') && (!tbFeesValue.Text.Contains("."));

            if (!IsDigitOrControl && !IsDecimalPoint) e.Handled = true;
        }
        private void tbFeesValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFeesValue.Text.Trim())) errpEditTypeHandler.SetError(tbFeesValue, "Required Field");

            else errpEditTypeHandler.SetError(tbFeesValue, "");
        }
        private void tbTitleValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitleValue.Text.Trim())) errpEditTypeHandler.SetError(tbTitleValue, "Required Field");

            else errpEditTypeHandler.SetError(tbTitleValue, "");
        }

    }
}

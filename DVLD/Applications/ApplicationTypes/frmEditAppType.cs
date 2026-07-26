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
    public partial class frmEditAppType : Form
    {
        public event EventHandler ApplicationType_DataChanged;

        clApplicationType _ApplicationType;
        int _AppTypeID;

        public frmEditAppType(int AppTypeID)
        {
            _AppTypeID = AppTypeID;
            InitializeComponent();
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
            _ApplicationType.AppTypeTitle = tbTitleValue.Text.Trim();
            _ApplicationType.AppTypeFees = Convert.ToSingle(tbFeesValue.Text);
        }

        private void frmEditAppType_Load(object sender, EventArgs e)
        {
            _ApplicationType = clApplicationType.Find(_AppTypeID);

            if (_ApplicationType != null)
            {
                lblTypeIDValue.Text = _ApplicationType.AppTypeID.ToString();
                tbTitleValue.Text = _ApplicationType.AppTypeTitle.ToString();
                tbFeesValue.Text = _ApplicationType.AppTypeFees.ToString();
            }

            else
            {
                _SetInitValues();
            }

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the errors first", "Fix Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ApplicationType.UpdateTypeInfo(tbTitleValue.Text.Trim(), Convert.ToSingle(tbFeesValue.Text.Trim())))
            {
                MessageBox.Show("Application Type Info Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                ApplicationType_DataChanged?.Invoke(this, EventArgs.Empty);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

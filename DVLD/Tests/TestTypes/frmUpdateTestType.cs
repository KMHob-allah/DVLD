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

namespace DVLD.Tests.TestTypes
{
    public partial class frmUpdateTestType : Form
    {
        public event EventHandler TestType_DataChanged;

        clTestType _TestType;
        clTestType.eTestType _TestTypeID;

        public frmUpdateTestType(clTestType.eTestType TestTypeID)
        {
            _TestTypeID = TestTypeID;

            InitializeComponent();
        }

        private void UpdateTestType_DataChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) btnSave.Enabled = true;
        }
        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _TestType = clTestType.Find(_TestTypeID);

            if (_TestType != null)
            {
                lblTestTypeID.Text = ((int)_TestType.ID).ToString();
                tbTitleValue.Text = _TestType.Title.ToString();
                tbTestDescriptionValue.Text = _TestType.Description.ToString();
                tbFeesValue.Text = _TestType.Fees.ToString();
            }

            else _SetDefaultValues();            

            btnSave.Enabled = false;

        }
        private void _SetDefaultValues()
        {

            lblTestTypeID.Text = "???";
            tbTitleValue.Text = string.Empty;
            tbTestDescriptionValue.Text = string.Empty;
            tbFeesValue.Text = string.Empty;
        }
        private void _FillTestTypeInfo()
        {
            _TestType.Title = tbTitleValue.Text.Trim();
            _TestType.Description = tbTestDescriptionValue.Text.Trim();
            _TestType.Fees = Convert.ToSingle(tbFeesValue.Text.Trim());
        }

        private void tbTestDescriptionValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestDescriptionValue.Text.Trim()))
            {
                errpEditTestHandler.SetError(tbTestDescriptionValue, "Required Field");
            }

            else errpEditTestHandler.SetError(tbTestDescriptionValue, "");

        }
        private void tbTitleValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitleValue.Text.Trim()))
            {
                errpEditTestHandler.SetError(tbTitleValue, "Required Field");
            }

            else errpEditTestHandler.SetError(tbTitleValue, "");

        }
        private void tbFeesValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFeesValue.Text.Trim()))
            {
                errpEditTestHandler.SetError(tbFeesValue, "Required Field");
            }

            else errpEditTestHandler.SetError(tbFeesValue, "");

        }

        private void tbFeesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDigitOrControl = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);

            bool IsDecimalPoint = (e.KeyChar == '.') && (!tbFeesValue.Text.Contains("."));

            if (!IsDigitOrControl && !IsDecimalPoint) e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the errors first", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillTestTypeInfo();

            if (_TestType.UpdateTestInfo())
            {
                MessageBox.Show("Test Type Info Updated Successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;

                TestType_DataChanged?.Invoke(this, EventArgs.Empty);
            }

            else MessageBox.Show("Test Type Info was not Updated", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}

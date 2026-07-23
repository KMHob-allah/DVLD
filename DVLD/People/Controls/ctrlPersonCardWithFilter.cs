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

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> WhenPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = WhenPersonSelected;

            if (handler != null) handler(PersonID);             
        }


        private bool _ShowAddPerson = true;
        private bool _FilterEnabled = true;

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
        public clPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.PersonInfo; }
        }

        private void _FillcbFilters()
        {
            cbFilters.Items.Add("Person ID");
            cbFilters.Items.Add("National Number");
        }
        public void FilterFocus()
        {
            tbUserFilterValue.Focus();
        }       

        public void LoadPersonInfo(int PersonID)
        {
            cbFilters.SelectedIndex = 0;
            tbUserFilterValue.Text = PersonID.ToString();
            Search();
        }
        private void Search()
        {
            switch (cbFilters.Text)
            {
                case "Person ID":

                    ctrlPersonCard1.LoadPersonInfo(Convert.ToInt32(tbUserFilterValue.Text));
                    break;

                case "National Number":

                    ctrlPersonCard1.LoadPersonInfo(tbUserFilterValue.Text);
                    break;

                default:

                    break;
            }

            if (WhenPersonSelected != null && FilterEnabled) PersonSelected(ctrlPersonCard1.PersonID);
        }        
        
        private void PersonDataSaved(object sender, int PersonID)
        {
            cbFilters.SelectedIndex = 0; // PersonID

            tbUserFilterValue.Text = PersonID.ToString();

            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnAddNewPerson_Click_1(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.PersonDataSaved += PersonDataSaved; 
            frm.ShowDialog();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, Put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Search();

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUserFilterValue.Text = string.Empty;
            tbUserFilterValue.Focus();

        }
        private void tbUserFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errpSearchHandler.SetError(tbUserFilterValue, "This field is required!");
            }

            else errpSearchHandler.SetError(tbUserFilterValue, null);


        }
        private void tbUserFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) btnSearch.PerformClick(); // When Enter Pressed          

            if (cbFilters.Text == "Person ID") e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ctrlPersonCardWithFilter_Load_1(object sender, EventArgs e)
        {
            _FillcbFilters();

            cbFilters.SelectedIndex = 1;
            tbUserFilterValue.Focus();
        }
    }
}

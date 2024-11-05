using ConversionApp;
using CustomerData;

namespace CustomerMaintenanceGUI
{
    public partial class frmAddModifyCustomer : Form
    {
        public bool IsAddition;
        public Customer? customer;
        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            LoadState();
            if (IsAddition)
            {
                this.Text = "Add Customer";
            }
            else
            {
                this.Text = "Modify Customer";
            }
        }

        private void LoadState()
        {
            List<State> list = new List<State>();
            list = StateDB.GetStates();
            cboStates.DataSource = list;
            cboStates.DisplayMember = "StateName"; //Displayed to the user
            cboStates.ValueMember = "StateCode"; // Value associated with the option selection, ideally always primary key of DB.
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidatorUtils.IsPresent(txtName) &&
                ValidatorUtils.IsPresent(txtAddress) &&
                ValidatorUtils.IsPresent(txtCity) &&
                ValidatorUtils.IsPresent(txtZipCode)
                )
            {
                if (IsAddition)
                {
                    customer = new Customer();
                    FillCustomer();
                }
                else //modify customer
                {
                    //
                }
            }

        }

        private void FillCustomer()
        {
            customer = new Customer();
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.ZipCode = txtZipCode.Text;
            customer.State = cboStates.SelectedValue.ToString();
        }
    }
}

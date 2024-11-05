using ConversionApp;
using CustomerData;

namespace CustomerMaintenanceGUI
{
    public partial class frmCustomerMaintenance : Form
    {
        Customer? selectedCustomer = null;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (ValidatorUtils.IsPresent(txtCustomerID) && ValidatorUtils.IsNonNegative(txtCustomerID))
            {
                int customerID = Convert.ToInt32(txtCustomerID.Text);
                selectedCustomer = CustomerDB.GetCustomer(customerID);

                if (selectedCustomer != null)
                {
                    DisplayCustomer();
                    //enable modify button here.
                }
                else
                {
                    MessageBox.Show($"There is no customer with id {customerID}");
                    ClearCustomer();

                }
            }
        }

        private void DisplayCustomer()
        {
            if (selectedCustomer != null)
            {
                txtCustomerID.Text = selectedCustomer.CustomerId.ToString();
                txtName.Text = selectedCustomer.Name;
                txtAddress.Text = selectedCustomer.Address;
                txtCity.Text = selectedCustomer.City;
                txtState.Text = selectedCustomer.State;
                txtZipCode.Text = selectedCustomer.ZipCode;
            }
        }

        private void ClearCustomer()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            //seet flag to indicate that this is creation of a new customer
            secondForm.IsAddition = true;
            secondForm.customer = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedCustomer = secondForm.customer;
                CustomerDB.AddCustomer(selectedCustomer);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            secondForm.IsAddition = false; // Prompting modification
            secondForm.customer = selectedCustomer;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (selectedCustomer != null)
                {
                    //           
                }
            }
        }
    }
}
// Watch from the 2 hour mark and forward.
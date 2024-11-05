namespace CustomerData

{

    public class CustomerDB

    {

        /// <summary>

        ///  Retreives customer based on their id 

        /// </summary>

        /// <param name="customerID"></param>

        /// <returns></returns>

        public static Customer GetCustomer(int customerID)

        {

            Customer? customer = null;

            using (MMABooksContext db = new MMABooksContext())

            {

                customer = db.Customers.Find(customerID);

            }

            return customer;
        }

        public static void AddCustomer(Customer customer)
        {
            using (MMABooksContext db = new MMABooksContext())
            {
                if (customer != null)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
            }
        }

    }

}

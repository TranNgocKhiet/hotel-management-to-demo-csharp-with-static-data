using BusinessObjects;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static List<Customer> customers;

        static CustomerDAO()
        {
            Customer customer1 = new Customer(3, "William Shakespeare", "0903939393",  "WilliamShakespeare@FUMiniHotel.org", new DateOnly(1990, 02, 02),  1,   "123@");
            Customer customer2 = new Customer(5, "Elizabeth Taylor", "0903939377", "ElizabethTaylor@FUMiniHotel.org", new DateOnly(1991, 03, 03), 1, "144@");
            Customer customer3 = new Customer(8, "James Cameron", "0903946582", "JamesCameron@FUMiniHotel.org", new DateOnly(1992, 11, 10), 1, "443@");
            Customer customer4 = new Customer(9, "Charles Dickens", "0903955633", "CharlesDickens @FUMiniHotel.org", new DateOnly(1991, 12, 05),  1, "563@");
            Customer customer5 = new Customer(10, "George Orwell", "0913933493", "GeorgeOrwell@FUMiniHotel.org", new DateOnly(1993, 12, 24), 1, "177@");
            Customer customer6 = new Customer(11, "Victoria Beckham", "0983246773", "VictoriaBeckham@FUMiniHotel.org", new DateOnly(1990, 09, 09), 1, "54@");

            customers = new List<Customer> { customer1, customer2, customer3, customer4, customer5, customer6 };
            customers = new List<Customer> { customer1, customer2, customer3, customer4, customer5, customer6 };
        }

        public static List<Customer> GetCustomers()
        {
            return customers;
        }

        public static Customer GetCustomer (int id)
        {
            foreach (Customer customer in customers.ToList())
            {
                if (customer.CustomerID == id)
                    return customer;
            }

            return null;
        }

        public static Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            Customer authenticareCustomer = new Customer();
            foreach (var customer in customers)
            {
                if (customer.EmailAddress.Equals(email) && customer.Password.Equals(password))
                {
                    authenticareCustomer = customer;
                    break;
                }
            }
            return authenticareCustomer;
        }

        public static void AddCustomer(Customer customer)
        {
            if (customers == null)
            {
                customers = new List<Customer>();
            }
            customers.Add(customer);
        }

        public static void UpdateCustomer(Customer customer)
        {
            foreach(Customer c in customers.ToList())
            {
                if (c.CustomerID == customer.CustomerID)
                {
                    c.CustomerID = customer.CustomerID;
                    c.CustomerFullName = customer.CustomerFullName;
                    c.Telephone = customer.Telephone;
                    c.EmailAddress = customer.EmailAddress;
                    c.CustomerBirthday = customer.CustomerBirthday;
                    c.Password = customer.Password;
                }
            }
        }

        public static void RemoveCustomer(Customer customer)
        {
            if (customers != null && customers.Contains(customer))
            {
                customers.Remove(customer);
            }
        }
    }
}

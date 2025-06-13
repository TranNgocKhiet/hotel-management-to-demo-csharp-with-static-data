using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static CustomerRepository customerRepository;
        public static CustomerRepository Instance => customerRepository ??= new CustomerRepository();

        public List<Customer> customers = new List<Customer>();

        public CustomerRepository() {}

        public Customer GetByEmailAndPassword(string email, string password) => CustomerDAO.GetCustomerByEmailAndPassword(email, password);

        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();

        public Customer GetCustomer(int customerId) => CustomerDAO.GetCustomer(customerId);


        public void AddCustomer(Customer customer) => CustomerDAO.AddCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.UpdateCustomer(customer);

        public void RemoveCustomer(Customer customer) => CustomerDAO.RemoveCustomer(customer);
    }
}

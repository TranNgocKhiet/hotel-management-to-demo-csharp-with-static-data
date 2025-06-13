using BusinessObjects;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository iCustomerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            iCustomerRepository = new CustomerRepository();
        }

        public Customer Login(string email, string password)
        {
            return iCustomerRepository.GetByEmailAndPassword(email, password);
        }
        public void AddCustomer(Customer customer)
        {
            iCustomerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            iCustomerRepository.UpdateCustomer(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            iCustomerRepository.RemoveCustomer(customer);
        }

        public List<Customer> GetCustomers()
        {
            return iCustomerRepository.GetCustomers();
        }

        public Customer GetCustomer(int customerId)
        {
            return iCustomerRepository.GetCustomer(customerId);
        }
    }
}

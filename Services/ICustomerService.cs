using BusinessObjects;

namespace Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomer(int customerId);
        Customer Login(string email, string password);
    }
}

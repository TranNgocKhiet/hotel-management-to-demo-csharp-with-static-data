using BusinessObjects;

namespace Repositories
{
    public interface ICustomerRepository
    {
        Customer GetByEmailAndPassword(string email, string password);
        Customer GetCustomer(int customerId);
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
    }
}

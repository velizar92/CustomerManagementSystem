using CustomerManagementSystem.Models;

namespace CustomerManagementSystem.Services
{
    public interface ICustomerService
    {
        IReadOnlyCollection<Customer> GetAllCustomers();

        Customer? GetCustomerById(int id);

        void CreateCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(int id);
    }
}

using CustomerManagementSystem.Models;

namespace CustomerManagementSystem.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private int _nextCustomerId = 8;

        private List<Customer> _customers =
        [
            new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com",
                PhoneNumber = "+1-555-0101",
                CustomerStatus = CustomerStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-5)
            },
            new Customer
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Smith",
                Email = "anna.smith@email.com",
                PhoneNumber = "+1-555-0102",
                CustomerStatus = CustomerStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-2)
            },
            new Customer
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Brown",
                Email = "michael.brown@email.com",
                PhoneNumber = "+1-555-0103",
                CustomerStatus = CustomerStatus.Inactive,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt = DateTime.Now.AddDays(-60)
            },
            new Customer
            {
                Id = 4,
                FirstName = "Emily",
                LastName = "Johnson",
                Email = "emily.johnson@email.com",
                PhoneNumber = "+1-555-0104",
                CustomerStatus = CustomerStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now.AddDays(-1)
            },
            new Customer
            {
                Id = 5,
                FirstName = "David",
                LastName = "Wilson",
                Email = "david.wilson@email.com",
                PhoneNumber = "+1-555-0105",
                CustomerStatus = CustomerStatus.Suspended,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt = DateTime.Now.AddDays(-20)
            },
            new Customer
            {
                Id = 6,
                FirstName = "Sophia",
                LastName = "Martinez",
                Email = "sophia.martinez@email.com",
                PhoneNumber = "+1-555-0106",
                CustomerStatus = CustomerStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-3),
                UpdatedAt = DateTime.Now.AddDays(-1)
            },
            new Customer
            {
                Id = 7,
                FirstName = "James",
                LastName = "Anderson",
                Email = "james.anderson@email.com",
                PhoneNumber = "+1-555-0107",
                CustomerStatus = CustomerStatus.Inactive,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt = DateTime.Now.AddDays(-100)
            }
        ];

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer object is null", nameof(customer));
            }

            customer.Id = _nextCustomerId;
            customer.CreatedAt = DateTime.Now;
            customer.UpdatedAt = DateTime.Now;

            _nextCustomerId++;

            _customers.Add(customer);
        }

        public bool DeleteCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return false;
            }

            _customers.Remove(customer);
            return true;
        }

        public IReadOnlyCollection<Customer> GetAllCustomers()
        {
            return _customers.AsReadOnly();
        }

        public Customer? GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public bool UpdateCustomer(Customer customer)
        {
            var customerForUpdate = _customers.FirstOrDefault(c => c.Id == customer.Id);

            if (customerForUpdate == null)
            {
                return false;
            }

            if (customerForUpdate != null)
            {
                customerForUpdate.FirstName = customer.FirstName;
                customerForUpdate.LastName = customer.LastName;
                customerForUpdate.Email = customer.Email;
                customerForUpdate.PhoneNumber = customer.PhoneNumber;
                customerForUpdate.CustomerStatus = customer.CustomerStatus;

                customerForUpdate.UpdatedAt = DateTime.Now;
            }

            return true;
        }
    }
}

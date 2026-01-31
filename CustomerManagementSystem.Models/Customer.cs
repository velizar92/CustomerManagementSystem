namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CustomerStatus CustomerStatus { get; set; } = CustomerStatus.Active;
    }
}

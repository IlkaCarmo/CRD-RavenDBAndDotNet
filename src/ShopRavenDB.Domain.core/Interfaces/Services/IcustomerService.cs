namespace ShopRavenDB.Domain.core.Interfaces.Services
{
    public interface IcustomerService
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(string id);
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(string id);
    }
}

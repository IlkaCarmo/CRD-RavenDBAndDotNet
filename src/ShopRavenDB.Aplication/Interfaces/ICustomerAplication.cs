
namespace ShopRavenDB.Aplication.Interfaces
{
    public interface IcustomerAplication
    {
        void AddCustomer(CustomerDto customer);
        void UpdateCustomer(CustomerDto customer);
        void DeleteCustomer(CustomerDto customer);
        IEnumerable<CustomerDto> GetCustomer();
        CustomerDto GetCustomerById(int id);
    }
}

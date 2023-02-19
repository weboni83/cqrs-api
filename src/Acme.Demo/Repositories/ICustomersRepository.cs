using Acme.Demo.Dtos;

namespace Acme.Demo.Repositories
{
    public interface ICustomersRepository
    {
        Task<CustomerDto> GetCustomer(string id);

        Task<CustomerDto> GetCustomersAsync();
    }
}

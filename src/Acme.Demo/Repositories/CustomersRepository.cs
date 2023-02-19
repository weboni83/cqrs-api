using Acme.Demo.Dtos;

namespace Acme.Demo.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        public Task<CustomerDto> GetCustomer(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

    }
}

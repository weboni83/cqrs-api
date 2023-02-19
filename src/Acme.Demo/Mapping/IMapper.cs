using Acme.Demo.Dtos;
using Acme.Demo.Response;

namespace Acme.Demo.Mapping
{
    public interface IMapper
    {
        CustomerResponse MapCustomerDtoToCustomerResponse(CustomerDto customer);
    }
}

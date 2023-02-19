using Acme.Demo.Dtos;
using Acme.Demo.Response;

namespace Acme.Demo.Mapping
{
    public class Mapper :
        IMapper
    {
        public CustomerResponse MapCustomerDtoToCustomerResponse(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public List<CustomerResponse> MapCustomerDtoToCustomerResponse(List<CustomerDto> customer) 
        {
            throw new NotImplementedException();
        }
    }
}

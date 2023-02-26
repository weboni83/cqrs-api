using Acme.Demo.Mapping;
using Acme.Demo.Repositories;
using Acme.Demo.Request;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {

        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomersRepository _customersRepository;
        private readonly IMapper _mapper;

        public CustomersController(ILogger<CustomersController> logger
            ,ICustomersRepository customersRepository
            ,IMapper mapper)
        {
            _logger = logger;
            _customersRepository = customersRepository;
            _mapper = mapper;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request)
        {
            var customer = await _customersRepository.GetCustomer(request.CustomerId);
            _logger.LogInformation($"created order for customer : {customer.Id}");

            var customerResponse = _mapper.MapCustomerDtoToCustomerResponse(customer);
            return CreatedAtAction("GetCustomer", new { customerId = customer.Id }, customerResponse);
        }


        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomer(string customerId)
        {
            var customer = await _customersRepository.GetCustomer(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            var customerResponse = _mapper.MapCustomerDtoToCustomerResponse(customer);
            return Ok(customerResponse);

        }


        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customersRepository.GetCustomersAsync();
            var customerResponses = _mapper.MapCustomerDtoToCustomerResponse(customers);
            return Ok(customerResponses);
        }

        
    }
}

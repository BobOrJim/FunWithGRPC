using Grpc.Core;

namespace GRPCServer.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();
            _logger.LogInformation($"Request recieved, not im digging up data for UserId =  {request.UserId}");

            //Swap with my db
            if (request.UserId == 1)
            {
                output.FirstName = "John";
                output.LastName = "Doe";
                output.Email = "John@gmail.com";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Jane";
                output.LastName = "Doe";
                output.Email = "Jane@gmail.com";
            }
            else
            {
                output.FirstName = "Jan";
                output.LastName = "Bannan";
                output.Email = "Jan@gmail.com";
            }

            return Task.FromResult(output);
        }
    }
}


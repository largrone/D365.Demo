using Microsoft.Dynamics.DataEntities;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Client;

namespace D365.Demo.Odata
{
    internal class DemoReadCreatedCustomer : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoReadCreatedCustomer> _logger;

        public DemoReadCreatedCustomer(D365Service service, ILogger<DemoReadCreatedCustomer> logger) => (_service, _logger) = (service, logger);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("DemoReadCreatedCustomer");

            var query = from Customers
                  in _service.D365.Customers
                        where Customers.CustomerAccount == "30061"
                        select Customers;

            DataServiceCollection<Customer> customers = new DataServiceCollection<Customer>(query);

            //Query
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Query: {customer.CustomerAccount} {customer.Name}");
            }
        }
    }
}

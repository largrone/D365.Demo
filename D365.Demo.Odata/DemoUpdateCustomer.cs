using Microsoft.Dynamics.DataEntities;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Client;

namespace D365.Demo.Odata
{
    internal class DemoUpdateCustomer : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoUpdateCustomer> _logger;

        public DemoUpdateCustomer(D365Service service, ILogger<DemoUpdateCustomer> logger) => (_service, _logger) = (service, logger);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("DemoUpdateCustomer");

            try
            {
                var query = from Customer
                    in _service.D365.Customers
                            where Customer.CustomerAccount == "30061"// &&
                            //CustomerV3.DataAreaId == "USMF"
                            select Customer;

                DataServiceCollection<Customer> customersToUpdate = new DataServiceCollection<Customer>(query);

                Customer customer = customersToUpdate[0];
                customer.NameAlias = "KomplettNytt navn 1";
                _service.D365.UpdateObject(customer);


                /*
                foreach (var cust in customersToUpdate)
                {
                    cust.Name = "Nytt navn 2";
                    context.UpdateObject(cust);
                }
                */

                DataServiceResponse response = _service.D365.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset); // Batch with Single Changeset ensure the saved changed runs in all-or-nothing mode.

                Console.WriteLine(string.Format("Kunde {0} - oppdatert !", customersToUpdate[0].NameAlias));

            }
            catch (DataServiceRequestException e)
            {
                Console.WriteLine(string.Format("Kunde - Save Failed ! "));
                _logger.LogError(e, "Kunde - Save failed!");
            }

        }
    }
}

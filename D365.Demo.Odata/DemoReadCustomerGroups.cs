using Microsoft.Dynamics.DataEntities;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Client;

namespace D365.Demo.Odata
{
    internal class DemoReadCustomerGroups : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoReadCustomerGroups> _logger;

        public DemoReadCustomerGroups(D365Service service, ILogger<DemoReadCustomerGroups> logger) => (_service, _logger) = (service, logger);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("DemoReadCustomerGroups");
            var query = from CustomerGroup
                              in _service.D365.CustomerGroups
                        where CustomerGroup.CustomerGroupId == "40"
                        select CustomerGroup;

            DataServiceCollection<CustomerGroup> customerGroups = new DataServiceCollection<CustomerGroup>(query);


            //Query
            foreach (CustomerGroup customerGroup in customerGroups)
            {
                Console.WriteLine("Query: {0},{1},{2}", customerGroup.CustomerGroupId,
                                                 customerGroup.Description,
                                                 customerGroup.PaymentTermId);
            }

            //Alle
            foreach (var custGroup in _service.D365.CustomerGroups.AddQueryOption("cross-company", true))
            //foreach (var custGroup in context.CustomerGroups.AsEnumerable())
            {
                Console.WriteLine("Foreach: Id: {0} Description: {1} DataAreaId: {2}", custGroup.CustomerGroupId, custGroup.Description, custGroup.DataAreaId);
            }

        }
    }
}

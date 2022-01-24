using Microsoft.Dynamics.DataEntities;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Client;

namespace D365.Demo.Odata
{
    internal class DemoCreateCustomer : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoCreateCustomer> _logger;

        public DemoCreateCustomer(D365Service service, ILogger<DemoCreateCustomer> logger) => (_service, _logger) = (service, logger);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("DemoCreateCustomer");


            string newCustomer = "";
            try
            {
                /*
                DataServiceCollection<VATNumTable> vatNumTableCollection = new DataServiceCollection<VATNumTable>(_service.D365);
                VATNumTable vatNumTable = new VATNumTable();
                vatNumTableCollection.Add(vatNumTable);
                vatNumTable.VATNum = "Komplett test";
                vatNumTable.CountryRegionId = "NOR";
                vatNumTable.Name = "Komplett test";
                vatNumTable.DataAreaId = "USMF";
                */

                /*
                DataServiceResponse vatNumResponse = _service.D365.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset); // Batch with Single Changeset ensure the saved changed runs in all-or-nothing mode.

                foreach (ChangeOperationResponse r in vatNumResponse)
                    if (r.Headers.ContainsKey("Location"))
                    {
                        Console.WriteLine("New customer created: {0}", vatNumTable.VATNum);
                        Console.WriteLine(r.Headers["Location"]);
                    }
               */

                DataServiceCollection<Customer> customerCollection = new DataServiceCollection<Customer>(_service.D365);
                Customer customer = new Customer();
                customerCollection.Add(customer);
                customer.CustomerAccount = "30061";
                customer.NameAlias = "Komplett test";
                customer.Name = "Komplett test";
                customer.CustomerGroupId = "40";
                customer.SalesCurrencyCode = "EUR";
                customer.PartyType = "Organization";
                customer.AddressDescription = "Hovedadresse";
                customer.AddressStreet = "Hovedveien 1";
                customer.AddressZipCode = "1337";
                customer.AddressCity = "Sandvika";
                customer.AddressCountryRegionId = "NOR";
                //customer.OrganizationNumber = "30061";
                //customer.TaxExemptNumber = "30066";
                customer.SalesTaxGroup = "FL";
                customer.LanguageId = "en-us";
                customer.PaymentTerms = "Net10";
                //customer.PaymentMethod = "OCR";
                //customer.PaymentIdType = "KID";
                //customer.DefaultDimensionDisplayValue = "-1200---*----";

                //var cust = context.Customers.Where(c => c.CustomerAccount == "30061");


                DataServiceResponse response = _service.D365.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset); // Batch with Single Changeset ensure the saved changed runs in all-or-nothing mode.

                foreach (ChangeOperationResponse r in response)
                    if (r.Headers.ContainsKey("Location"))
                    {
                        Console.WriteLine("New customer created: {0}", customer.CustomerAccount);
                        Console.WriteLine(r.Headers["Location"]);
                    }

                int result = response.BatchStatusCode;

                Console.WriteLine(string.Format("Kunde {0} - Saved !", customer.Name));
            }
            catch (DataServiceRequestException e)
            {
                Console.WriteLine(string.Format("Kunde {0} - Save Failed !", newCustomer));
                _logger.LogError(e, "Kunde - Save failed!");
            }
        }
    }
}

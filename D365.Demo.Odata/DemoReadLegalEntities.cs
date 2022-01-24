using Microsoft.Extensions.Logging;

namespace D365.Demo.Odata
{
    internal class DemoReadLegalEntities : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoReadLegalEntities> _logger;

        public DemoReadLegalEntities(D365Service service, ILogger<DemoReadLegalEntities> logger) => (_service, _logger) = (service, logger);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("ReadLegalEntities");
            foreach (var legalEntity in _service.D365.LegalEntities.AsEnumerable())
            {

                Console.WriteLine("Name: {0}", legalEntity.Name);
            }
        }
    }
}

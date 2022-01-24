using Microsoft.Dynamics.DataEntities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OData.Client;
using Azure.Storage.Blobs;
using System.IO.Compression;

namespace D365.Demo.Odata
{
    internal class DemoPackageExporter : IDemoService
    {
        private readonly D365Service _service;
        private readonly ILogger<DemoPackageExporter> _logger;
        private readonly BlobConfig _config;

        public DemoPackageExporter(D365Service service, ILogger<DemoPackageExporter> logger, IOptions<BlobConfig> config) => (_service, _logger, _config) = (service, logger, config.Value);

        async Task IDemoService.ExecuteAsync()
        {
            _logger.LogInformation("DemoPackageExporter");

            await ExportPackage(_service.D365, "emkDoNotDeleteCustomerGroupExport");
        }

       private async Task ExportPackage(Resources d365Client, string projectName)
        {
            // Setup Step 
            // - Create an export project within Dynamics called Integration_Outbound_Flow_01 in company USMF before you run the following code
            // - It can of any data format (csv, xml etc.) and can include any number of data entities


            // 1. Initiate export of a data project to create a data package within Dynamics 365 for Operations
            Console.WriteLine("Initiating export of a data project...");
            var executionId = d365Client.DataManagementDefinitionGroups.ExportToPackage(projectName, Guid.NewGuid().ToString(), string.Empty, false, "USMF").GetValue();
            Console.WriteLine("Initiating export of a data project...Complete");

            // 2. Check if execution is completed
            DMFExecutionSummaryStatus? output = null;
            int maxLoop = 100;

            do
            {
                Console.WriteLine("Waiting for package to execution to complete");

                Thread.Sleep(5000);
                maxLoop--;

                if (maxLoop <= 0)
                {
                    break;
                }

                Console.WriteLine("Checking status...");

                output = d365Client.DataManagementDefinitionGroups.GetExecutionSummaryStatus(executionId).GetValue();

                Console.WriteLine("Status of export is " + output.Value);

            }
            while (output == DMFExecutionSummaryStatus.NotRun || output == DMFExecutionSummaryStatus.Executing);

            if (output.HasValue
                && output.Value != DMFExecutionSummaryStatus.Succeeded
                && output.Value != DMFExecutionSummaryStatus.PartiallySucceeded)
            {
                throw new Exception("Operation Failed");
            }

            // 3. Get downloable Url to download the package           
            var downloadUrl = d365Client.DataManagementDefinitionGroups.GetExportedPackageUrl(executionId).GetValue();


            // 4. Download the file from Url to a local folder
            Console.WriteLine("Downloading the file ...");
            Guid guid = Guid.NewGuid();
            string blobName = Path.Combine(_config.BlobPath, guid.ToString() + ".zip");

            BlobClient blClient = new BlobClient(_config.ConnectionString, "packagedownload", blobName);

            await blClient.SyncCopyFromUriAsync(new Uri(downloadUrl));

            Console.WriteLine(downloadUrl);

            Console.WriteLine("Downloading the file ...Complete");


            // 5. Extracting file with xml data and saving it locally
            using (Stream inputStream = await blClient.OpenReadAsync())
            {
                ZipArchive archive = new ZipArchive(inputStream, ZipArchiveMode.Read, false);
                ZipArchiveEntry entry = archive.GetEntry("Customer groups.xml");

                using (Stream zipEntry = entry.Open())
                {
                    string fileName = Path.Combine(_config.LocalDirectory, guid.ToString() + ".xml");

                    Console.WriteLine($"Writing to local file {fileName}");
                    using (var fileStream = new FileStream(fileName, FileMode.Create))
                    {
                        await zipEntry.CopyToAsync(fileStream);
                    }
                }
            }

        }
    }
}
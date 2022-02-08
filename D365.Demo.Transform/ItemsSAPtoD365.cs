using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using D365.Demo.Transform.D365;
using System.Collections.Generic;

namespace D365.Demo.Transform
{
    public class ItemsSAPtoD365
    {
        private readonly ILogger<ItemsSAPtoD365> _logger;
        private readonly Configuration _configuration;

        public ItemsSAPtoD365(ILogger<ItemsSAPtoD365> log, IOptions<Configuration> configuration)
        {
            _logger = log;
            _configuration = configuration.Value;
        }

        [FunctionName("ItemsSAPtoD365")]
        [OpenApiOperation(operationId: "ItemsSAPtoD365", 
            tags: new[] { "Transformation" }, 
            Description = "Transform item information from SAP format to entity Products",
            Summary = "Transform message from SAP to D365")]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody(contentType: "text/plain", bodyType: typeof(string), Description = "File contents in XML format from SAP", Required = true)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/xml", bodyType: typeof(string), Description = "XML Data for import in Dynamics 365")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("TransformFromHL received a request");
            _logger.LogInformation($"Using culture {_configuration.Culture} for decimal separators");

            string ret = string.Empty;
            string doc;

            try
            {
                
                doc = await ProcessFile(req.Body);

            }
            catch (Exception ex)
            {
                return (ActionResult)new BadRequestObjectResult(string.Format("Error: {0} {1}", ex.Message, ex.InnerException));
            }

            return new ContentResult { Content = doc, ContentType = "application/xml" };
        }

        private async Task<string> ProcessFile(Stream file)
        {
            Document document = new Document();

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                XElement doc = await XElement.LoadAsync(file, LoadOptions.None, cts.Token);
    
                var itemList = 
                    from item in doc.Elements("Item")
                    select item;

                List<EcoResProductV2Entity> d365ProductList = new List<EcoResProductV2Entity>();
                foreach (var item in itemList)
                {
                    EcoResProductV2Entity ecoResProduct = new EcoResProductV2Entity();

                    var texts = from text in item.Elements("Texts")
                                      where (string)text.Element("language") == "nor"
                                      select new { name = (string)text.Element("materialDescription"), description = (string)text.Element("webText1") };

                    ecoResProduct.PRODUCTNUMBER = (string)item.Element("sapSKU");
                    ecoResProduct.PRODUCTNAME = (string)texts.FirstOrDefault().name;
                    ecoResProduct.PRODUCTDESCRIPTION = (string)texts.FirstOrDefault().description;
                    ecoResProduct.PRODUCTSEARCHNAME = ecoResProduct.PRODUCTNAME.Replace(" ", "").Substring(0, 20);
                    ecoResProduct.PRODUCTCOLORGROUPID = "";
                    ecoResProduct.PRODUCTDIMENSIONGROUPNAME = "";
                    ecoResProduct.PRODUCTSIZEGROUPID = "";
                    ecoResProduct.PRODUCTSTYLEGROUPID = "";

                    ecoResProduct.PRODUCTTYPE = "Item";
                    ecoResProduct.PRODUCTSUBTYPE = "Product";

                    d365ProductList.Add(ecoResProduct);
                }

                document.Items = d365ProductList.ToArray();
            }
            
            return document.Serialize();
        }
    }
}


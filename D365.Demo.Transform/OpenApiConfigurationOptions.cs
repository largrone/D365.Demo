using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Demo.Transform
{
    public class OpenApiConfigurationOptions : IOpenApiConfigurationOptions
    {
        public OpenApiInfo Info { get; set; } = new OpenApiInfo()
        {
            Version = "1.0.0",
            Title = "Columbus Demo Transform",
            Description = "This is a demo to how to transform messages from one format to another",
            Contact = new OpenApiContact()
            {
                Name = "Lars Grøneng",
                Email = "lars.groneng@columbusglobal.com"
                // Url = new Uri("https://github.com/Azure/azure-functions-openapi-extension/issues"),
            },
        };
        List<OpenApiServer> IOpenApiConfigurationOptions.Servers { get; set; } = new List<OpenApiServer>();
        OpenApiVersionType IOpenApiConfigurationOptions.OpenApiVersion { get; set; }
        bool IOpenApiConfigurationOptions.IncludeRequestingHostName { get; set; }
        bool IOpenApiConfigurationOptions.ForceHttp { get; set; }
        bool IOpenApiConfigurationOptions.ForceHttps { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.OData;

namespace D365.Demo.Odata
{
    internal class AuthService
    {
        private readonly ADConfig _adConfig;
        private AuthenticationResult? _authenticationResult = null;
        private const string AuthHeader = "Authorization";
        private readonly ILogger<AuthService> _logger;

        public AuthService(IOptions<ADConfig> adConfig, ILogger<AuthService> logger) => (_adConfig, _logger) = (adConfig.Value, logger);

        private async Task SetToken()
        {
            _logger.LogInformation("Builds OAuth Token");

            IConfidentialClientApplication app;
            app = ConfidentialClientApplicationBuilder
                    .Create(_adConfig.ClientAppId)
                    .WithClientSecret(_adConfig.ClientAppSecret)
                    .WithAuthority(new Uri(_adConfig.Tenant))
                    .Build();

            string[] scopes = new string[] { _adConfig.Scope + "/.default" };

            _authenticationResult = await app.AcquireTokenForClient(scopes).ExecuteAsync();
            _logger.LogInformation($"Oauth token: {_authenticationResult.AccessToken}");

        }

        public async Task<bool> Login()
        {
            _logger.LogInformation("OAuth Login initiated");

            if (_adConfig == null 
                || String.IsNullOrEmpty(_adConfig.Tenant)
                || String.IsNullOrEmpty(_adConfig.ClientAppId)
                || String.IsNullOrEmpty(_adConfig.ClientAppSecret)
                || String.IsNullOrEmpty(_adConfig.Scope)
                )
                throw new ArgumentNullException("Missing configuration parameters for OAuth");

            //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            
            await SetToken();

            return (_authenticationResult != null && _authenticationResult.AccessToken != null);
        }

        internal void AddAuthHeaderOdata(IODataRequestMessage requestMessage)
        {
            if (String.IsNullOrEmpty(requestMessage.GetHeader(AuthHeader)) && _authenticationResult != null)
            {
                _logger.LogInformation("Adds OAuth Header to OData request");
                requestMessage.SetHeader(AuthHeader, _authenticationResult.CreateAuthorizationHeader());
            }
        }

        public void AddAuthHeader(HttpRequestMessage request)
        {
            if (!request.Headers.Contains(AuthHeader) && _authenticationResult != null)
            {
                _logger.LogInformation("Adds OAuth Header to Http Request");
                request.Headers.Add(AuthHeader, _authenticationResult.CreateAuthorizationHeader());
            }
        }
    }
}

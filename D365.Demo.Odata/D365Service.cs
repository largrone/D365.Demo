using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Dynamics.DataEntities;
using Microsoft.OData.Client;
using Microsoft.Extensions.Logging;

namespace D365.Demo.Odata
{
    internal class D365Service
    {
        private readonly AppSettings _settings;
        private readonly AuthService _authService;
        private readonly ILogger<D365Service> _logger;

        private Resources? _dynamics = null;

        public Resources D365 { get {
                if (_dynamics == null)
                {
                    var task = Connect();
                    task.Wait();
                    _dynamics = task.Result;
                }

                return _dynamics; 
            } }

        public D365Service(IOptions<AppSettings> settings, AuthService authService, ILogger<D365Service> logger) =>
            (_settings, _authService, _logger) 
                = (settings.Value, authService, logger);
        
        public async Task Reconnect()
        {
            _logger.LogInformation("Reconnect called");
            Console.WriteLine($"URI to connect to: {_settings.ServerUri}");

            _dynamics = await Connect();

           }

        private async Task<Resources> Connect()
        {
            _logger.LogInformation("Connecting");
            if (_authService == null)
                throw new ArgumentNullException("authService");

            if (!(await _authService.Login()))
            {
                throw new UnauthorizedAccessException("Login failed to Dynamics");
            }

            Uri ODataUri = new Uri(_settings.ServerUri + "/data", UriKind.Absolute);
            var dynamicsContext = new Resources(ODataUri);

            dynamicsContext.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>((sender, e) =>
            {
                _authService.AddAuthHeaderOdata(e.RequestMessage);
            });
            _logger.LogInformation("Authenticated to Dynamics");

            return dynamicsContext;
        }

    }
}

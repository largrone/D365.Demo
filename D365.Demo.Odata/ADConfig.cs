using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Demo.Odata
{
    public class ADConfig
    {
        public string Scope { get; set; } = "";
        public string Tenant { get; set; } = "";
        public string ClientAppId { get; set; } = "";
        public string ClientAppSecret { get; set; } = "";
    }
}

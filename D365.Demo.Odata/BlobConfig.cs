using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Demo.Odata
{
    public class BlobConfig
    {
        public string ConnectionString { get; set; } = "";
        public string BlobPath { get; set; } = "";
        public string LocalDirectory { get; set; } = "";
    }

}

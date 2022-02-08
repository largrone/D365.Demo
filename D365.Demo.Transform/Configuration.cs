using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Demo.Transform
{
    public class Configuration
    {
        public string Culture { get; set; }
        public char FieldSep { get; set; }
        public int YearDigits { get; set; }
        public int NumberOfFields { get; set; }
        public string CurrencyCode { get; set; }
    }
}

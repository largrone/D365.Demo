using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace D365.Demo.Transform
{
    static class Serializer
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                StringWriterUtf8 stringWriter = new StringWriterUtf8();
                XmlRootAttribute root = new XmlRootAttribute("Document");
                var xmlserializer = new XmlSerializer(typeof(T), root);
                //var stringWriter = new StringWriter();

                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

    }

}

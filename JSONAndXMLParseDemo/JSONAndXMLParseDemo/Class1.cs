using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JSONAndXMLParseDemo
{
    class Class1
    {
        static void Main()
        {
            // Create an XmlUrlResolver with the credentials necessary to access the Web server.
            var resolver = new XmlUrlResolver();
            var myCred = new NetworkCredential("UserName", "SecurelyStoredPassword", "Domain");
            resolver.Credentials = myCred;

            var settings = new XmlReaderSettings();//new class which replaced XmlValidatingReader class
            settings.XmlResolver = resolver;

            // Create the reader.
            XmlReader reader = XmlReader.Create("http://serverName/data/books.xml", settings);
        }
    }
}

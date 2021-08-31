using System;
using System.Xml;
using Newtonsoft.Json;

namespace JSONAndXMLParseDemo
{
    class XMLToJsonDemo
    {
        static void Main()
        {
            var xmlValue = "<root><Profile><íd>1</íd><name>scott</name><address>Pune</address></Profile><Profile><íd>2</íd><name>tiger</name><address>mumbai</address></Profile></root>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlValue);
            var jsonValue = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(jsonValue);
            Console.ReadLine();
        }
    }
}

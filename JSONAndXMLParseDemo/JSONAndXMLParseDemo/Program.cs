using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
namespace JSONAndXMLParseDemo
{
    //  This program demo. to convert (parse) json to xml
    class Program
    {
        static void Main(string[] args)
        {
            var jsonValue = @"{
            'root':{
                    'Profile':[
                                    {'íd':'1','name':'scott','address':'Pune'},
                                    {'íd':'2','name':'tiger','address':'mumbai'}
                              ]
                    }
            }";
            //  Represents an XML document. You can use this class to load, validate, edit, add, and position XML in a document.
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonValue);
            Console.WriteLine(doc.InnerXml);
            Console.ReadLine();
        }
    }
}

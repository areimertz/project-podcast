using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Datalayer
{
        internal class InternalClass
        {
            internal string xml = "";
        }

        public class RSS : XmlAbstract
        {
            public override XmlDocument PodDocument(string urlString)
            {
                //Ladda hem XML.
                var xml = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString(urlString);
                }

                //Skapa en objektrepresentation.
                var dom = new System.Xml.XmlDocument();
                dom.LoadXml(xml);
                return dom;



            }
        }
    }

    

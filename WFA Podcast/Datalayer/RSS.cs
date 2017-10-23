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
            public override XmlDocument PodDocument(string urlPod)
            {
            //Ladda hem XML.
            InternalClass test = new InternalClass();
            var xml = test.xml;
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString(urlPod);
                }

                //Skapa en objektrepresentation.
                XmlDocument dom = new XmlDocument();
                dom.LoadXml(xml);
                return dom;



            }
        }
    }

    

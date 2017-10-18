using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Datalayer
{
    public class RSS
    {

        public class Rss : XmlAbstract
        {
            public override XmlDocument PodDocument(string urlPod)
            {

                var xml = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString("http://www.aftonbladet.se/rss.xml");
                }


                XmlDocument dom = new XmlDocument();
                dom.LoadXml(xml);
                return dom;


            }

        }
    }
}
    

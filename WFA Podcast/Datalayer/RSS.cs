using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Datalayer
{


    public class RSS : XmlAbstract
    {




        public override void writeToXml(string Url, string name, string category)
        {
            using (var client = new WebClient())
            {
                string path = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name + ".xml";
                client.DownloadFile(Url, path);
                client.Dispose();
            }

        }





    }
}


    

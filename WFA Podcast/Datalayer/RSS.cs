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
            try
            {
                using (var client = new WebClient())
                {
                    string path = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name;
                    client.DownloadFile(Url, path);
                    client.Dispose();
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }
        public void saveIntervall(string name, string category, double intervall) {

            try
            {
                using (var writer = new StreamWriter(Directory.GetCurrentDirectory() +  @"\Categories\" + category + @"\" + name +"intervall" + ".txt"))
                {
                    writer.Write(intervall);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }
        public void saveUrl(string name, string category, string Url)
        {

            try
            {
                using (var writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name + ".txt"))
                {
                    writer.Write(Url);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }
    }
}


    

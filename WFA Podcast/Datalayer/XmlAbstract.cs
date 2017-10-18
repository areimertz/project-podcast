using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Datalayer
{
    public abstract class XmlAbstract
    {
        public abstract XmlDocument PodDocument(string urlPod);

        public virtual void writeToXml(string url, string category, string name)
        {
            Console.WriteLine(url + category + name);
        }

    }
}

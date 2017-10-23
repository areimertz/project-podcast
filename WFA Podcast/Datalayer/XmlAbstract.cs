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

        public virtual void writeToXml(string Url, string category, string name)
        {
            Console.WriteLine(Url + "" + category + "" + name);
        }

    }
}

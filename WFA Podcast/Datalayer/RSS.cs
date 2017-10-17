using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    class RSS
    {
        var xml = "Namn på XML fil";
      using (var client = new System.Net.WebClient())
      {
         client.Encoding = Encoding.UTF8;
         xml = client.DownloadString("RSS URL");
      }

//Skapa en objektrepresentation.
var dom = new System.Xml.XmlDocument();
dom.LoadXml(xml);

      //Iterera igenom elementet item.
      foreach (System.Xml.XmlNode item
         in dom.DocumentElement.SelectNodes("Items i en List"))
      {
         //Skriv ut dess titel.
         var title = item.SelectSingleNode("Vad detta ska heta");
Console.WriteLine(title.InnerText);
      }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Datalayer
{
    public class DataSaver
    {
        CategoryProperties catProp = new CategoryProperties();
        public List<CategoryProperties> getCategories()
        {
            String namn = catProp.getName();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\categories"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories");
            }

            List<CategoryProperties> categories = new List<CategoryProperties>();
            var folder = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\categories");
            foreach (var category in folder)
            {
                var name = new DirectoryInfo(category);
                categories.Add(new CategoryProperties { name = name.Name });
            }
            return categories;
        }

        public bool SaveFolderCategory(string category)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\categories"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories");
            }
            System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories\" + category);
            return true;
        }




        public void saveXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlTextWriter writer = new XmlTextWriter("podcasts.xml", null);
            writer.Formatting = Formatting.Indented;
            xmlDoc.Save(writer);
            writer.Close();

        }


        List<string> listOfCategory = new List<string>();
        public void SparaCategory(string categoryName)
        {

            listOfCategory.Add(categoryName);

        }

        public void addNewPod(string Url, string category, string name)
        { 
        RSS rssVar = new RSS();
        XmlDocument doc = rssVar.PodDocument(Url);
            string path = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name + @".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
            settings.IndentChars = ("    ");

            int i = 0;

        XmlWriter xmlOut = XmlWriter.Create(path, settings);

        xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("channel");
           // xmlOut.WriteElementString("interval", interval);
            xmlOut.WriteElementString("url", Url);
            xmlOut.WriteElementString("lastSync", DateTime.Now.ToString());
            foreach (XmlNode item
               in doc.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
        var description = item.SelectSingleNode("description");
        var enclosure = item.SelectSingleNode("enclosure/@url");

        xmlOut.WriteStartElement("item");

                xmlOut.WriteAttributeString("ID", "pod" + i);

                if (description.InnerText.Equals(""))
                {
                    xmlOut.WriteElementString("description", "Unfortunately, no description is available.");
                }
                else
                {
                    xmlOut.WriteElementString("description", description.InnerText);
                }

                xmlOut.WriteElementString("title", title.InnerText);
                xmlOut.WriteElementString("enclosure", enclosure.InnerText);
                xmlOut.WriteElementString("status", "Unlistened");

                xmlOut.WriteEndElement();
                i++;
            }

            xmlOut.WriteEndDocument();
            xmlOut.Close();
        }
    }
    
}



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
        public void AddCategory(string category)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category;

        }

        public bool SaveFolderCategory(string category)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\categories"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categoris");
            }
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories" + category);
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
        public void SaveCategory(string categoryName)
        {

            listOfCategory.Add(categoryName);

        }
    }
}



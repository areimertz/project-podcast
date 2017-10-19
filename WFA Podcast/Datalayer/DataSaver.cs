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
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Categories"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Categories");
            }
            System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Categories\" + category);
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
    }
}



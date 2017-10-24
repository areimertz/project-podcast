using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.IO;


namespace Logic
{
    public class Category
    {
        private DataSaver dataSaver = new DataSaver();
        public List<CategoryProperties> ListOfCategories = new List<CategoryProperties>();
        CategoryProperties catProp = new CategoryProperties();

        public Category(){
            fillListCategory();
                        }
        public void SaveCategory(string newCategory)
        {

            dataSaver.SaveFolderCategory(newCategory);

        }

       public List<String> fillListCategory()
        {
            List<String> allaNamn = new List<String>();
            foreach (var name in ListOfCategories)
            {                    allaNamn.Add(name.ToString());
            }
            return allaNamn;
        }

       public void RemoveCategory(string category)
        {
            var path = Directory.GetCurrentDirectory() + @"\categories\" + category;

            Directory.Delete(path, true);


        }

        public void removeFile(string category, string name)
        {
            string path = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name;

            File.Delete(path);
        }

        public void changeCategory(string category, string name, string newCategory)
        {
            string path1 = Directory.GetCurrentDirectory() + @"\categories\" + newCategory + @"\" + name;
            string path2 = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name;

            File.Move(path1, path2);
        }


    }
}
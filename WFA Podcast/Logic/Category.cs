using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.IO;
using System.Windows.Forms;
using System.Threading;



namespace Logic
{
    public class Category
    {
        private DataSaver dataSaver = new DataSaver();
        public List<CategoryProperties> ListOfCategories = new List<CategoryProperties>();
        CategoryProperties catProp = new CategoryProperties();

        public async void CategoryfillListBox(ListBox LB, Label lblloading){
            Task<List<string>> result;
            result = fillListCategory();
            lblloading.Text = "Loading..";
            await result;
            List<string> AllCategories = result.Result;
            foreach (var item in AllCategories)
            {
                LB.Items.Add(item);
            }
            lblloading.Text = "Done!";

                        }
        public void SaveCategory(string newCategory)
        {

            dataSaver.SaveFolderCategory(newCategory);

        }

       public async Task<List<String>> fillListCategory()
        {
            List<String> allaNamn = new List<String>();
            foreach (var name in ListOfCategories)
            {
                allaNamn.Add(name.ToString());
                Thread.Sleep(5000);
                
            }
            return allaNamn;
        }

       public void remove(string category)
        {
            var path = Directory.GetCurrentDirectory() + @"\categories\" + category;

            Directory.Delete(path, true);


        }

        public void remove(string category, string name)
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

        public void changeCategoryName(string category, string name)
        {
            string path1 = Directory.GetCurrentDirectory() + @"\categories\" + category;
            string path2 = Directory.GetCurrentDirectory() + @"\categories\"  + name;

            Directory.Move(path1, path2);
        }
    }
}
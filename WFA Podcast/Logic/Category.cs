﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.IO;
using System.Threading;



namespace Logic
{
    public class Category
    {
        private DataSaver dataSaver = new DataSaver();
        public List<CategoryProperties> ListOfCategories = new List<CategoryProperties>();
        CategoryProperties catProp = new CategoryProperties();

  
        public void SaveCategory(string newCategory)
        {
            try
            {
                dataSaver.SaveFolderCategory(newCategory);
            }
            catch (Exception)
            {
                throw;
            }

        }

       public async Task<List<String>> fillListCategory()
        {
            try
            {
                List<String> allaNamn = new List<String>();
                foreach (var name in ListOfCategories)
                {
                    allaNamn.Add(name.ToString());
                    Thread.Sleep(5000);
                }
                return allaNamn;
            }
            catch (Exception)
            {
                throw;
            }
        }

       public void remove(string category)
        {
            try
            {
                var path = Directory.GetCurrentDirectory() + @"\categories\" + category;

                Directory.Delete(path, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void remove(string category, string name)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name;
                string path1 = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name + ".txt";
                string path2 = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name + "intervall" + ".txt";
                string path3 = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name + ".xml";


                File.Delete(path);
                File.Delete(path1);
                File.Delete(path2);
                File.Delete(path3);


            }
            catch (Exception)
            {
                throw;
            }
        }

        public void changeCategory(string category, string name, string newCategory)
        {
            try
            {
                string path1 = Directory.GetCurrentDirectory() + @"\categories\" + newCategory + @"\" + name;
                string path2 = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name;

                File.Move(path1, path2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void changeCategoryName(string category, string name)
        {
            try
            {
                string path1 = Directory.GetCurrentDirectory() + @"\categories\" + category;
                string path2 = Directory.GetCurrentDirectory() + @"\categories\" + name;

                Directory.Move(path1, path2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
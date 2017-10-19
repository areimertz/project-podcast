﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;


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
    }
}
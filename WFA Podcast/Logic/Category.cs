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
        //List<Category> listOfCategory = new List<Category>();

        public void fillCategory(string newCategory) {

            dataSaver.SaveCategory(newCategory);
            
        }
        
    }
}

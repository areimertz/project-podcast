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
        

        public void SaveCategory(string newCategory) {

            dataSaver.SaveFolderCategory(newCategory);
            
        }
        
    }
}

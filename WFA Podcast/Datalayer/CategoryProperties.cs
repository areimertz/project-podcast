﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
  
   public class CategoryProperties
    {
        public string name { get; set; }
        public string path { get; set; }

        public override string ToString()
        {
            try
            {
                return name;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getName()
        {
            try
            {
                return name;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}

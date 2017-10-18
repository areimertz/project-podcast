using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class DataSaver
    {

        List<string> listOfCategory = new List<string>();
         public void SaveCategory(string categoryName) {

            listOfCategory.Add(categoryName);
            
        }
    }
}


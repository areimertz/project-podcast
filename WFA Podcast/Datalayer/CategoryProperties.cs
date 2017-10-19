using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    /// <summary>
    /// Hanterar ett objekt av en kategori.
    /// </summary>
   public class CategoryProperties
    {
        public string name { get; set; }
        public string path { get; set; }

        public override string ToString()
        {
            return name;
        }

        public string getName()
        {
            return name;
        }


    }
}

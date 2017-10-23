using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class PodcastProperties
    {
        public string name { get; set; }
        public string intervall { get; set; }
        public string category { get; set; }

        public string Url { get; set; }

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
    


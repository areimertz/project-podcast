using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Logic
{
    public class Podcast
    {
        
            public string name { get; set; }
            public string intervall { get; set; }
            public string category { get; set; }

            public string url { get; set; }

            public override string ToString()
            {
                return name;
            }

            public string getName()
            {
                return name;
            }
        public void podcastinfo(string Url, string category, string name) {
            RSS rssreader = new RSS();
            this.name = name;
            this.url = url;
            this.category = category;
            rssreader.readrss(Url, name, category);
            
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

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
            rssreader.writeToXml(Url, name, category);
            
        }

        public void getPodDescription(string category, string name, ListBox lbox)
        {
            var paths = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name;

            var xml = XmlReader.Create(paths);
            var feed = SyndicationFeed.Load(xml);
            xml.Close();

            var description = feed.Description.Text;
            lbox.Items.Add(description);

          

        }
    }
}

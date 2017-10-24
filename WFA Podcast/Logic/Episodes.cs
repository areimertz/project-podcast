using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datalayer;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Logic
{
   public class Episodes
    {
            List<Episode> episodes = new List<Episode>();

        public void getEpisodes(string category, string name, CheckedListBox cbox)
        {
            var paths = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name;

            var xml = XmlReader.Create(paths);
            var feed = SyndicationFeed.Load(xml);
            xml.Close();



            foreach (var episode in feed.Items)
            {
                var pod = new Episode()
                {
                    Description = episode.Summary.Text,
                    Title = episode.Title.Text,
                };
                foreach (var link in episode.Links)
                {
                    if (link.Uri.OriginalString.EndsWith(".mp3"))
                    {
                        pod.Url = link.Uri.OriginalString;
                        continue;
                    }

                }
                episodes.Add(pod);
            }
            foreach (var item in episodes)
            {
                cbox.Items.Add(item, false);
            }
         
        }

        public void getDescription(string name, ListBox lbDescription)
        {
            var descrip = from x in episodes
                          where x.Title == name
                          select x.Description;

            lbDescription.Items.Add(descrip.Single().ToString());




         
           
        }
        }
}

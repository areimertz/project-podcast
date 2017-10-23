using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datalayer;
using System.ServiceModel.Syndication;

namespace Logic
{
   public class Episodes
    {


        public void getEpisodes(string category, string name)
        {
            var paths = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name + ".xml";

            var xml = XmlReader.Create(paths);
            var feed = SyndicationFeed.Load(xml);
            xml.Close();

            List<Episode> episodes = new List<Episode>();

            foreach (var episode in feed.Items)
            {
                var pod = new Episode()
                {
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
         
        }

    }
}

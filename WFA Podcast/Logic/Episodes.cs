using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datalayer;
using System.ServiceModel.Syndication;
using System.Xml.Linq;


namespace Logic
{
   public class Episodes
    {
            List<Episode> episodes = new List<Episode>();

        public void getEpisodes(string category, string name)
        {
            try
            {
                var paths = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name;
                var xml = XmlReader.Create(paths);
                var feed = SyndicationFeed.Load(xml);
                xml.Close();

                if (episodes != null)
                {
                    episodes.Clear();


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
                 
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Episode> getListEpisodes() {
            try
            {
                return episodes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getDescription(string name)
        {
            try
            {
                var descrip = from x in episodes
                              where x.Title == name
                              select x.Description;

                return descrip.Single().ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string GetPlayablePod(string name)
        {
            try
            {
                var Url = from x in episodes
                          where x.Title == name
                          select x.Url;


                return Url.Single().ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    



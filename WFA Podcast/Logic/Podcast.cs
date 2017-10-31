using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Timers;
using System.IO;
using System.Xml.Linq;

namespace Logic
{
    public class Podcast
    {


        public string name { get; set; }
        public double intervall { get; set; }
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
        RSS rssreader = new RSS();
        public void podcastinfo(string url, string category, string name, double intervall)
        {
            try
            {
               
                this.name = name;
                this.url = url;
                this.category = category;
                this.intervall = intervall;
                rssreader.writeToXml(url, name, category);
                rssreader.saveIntervall(name, category, intervall);
                rssreader.saveUrl(name,category,url);
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

        public string getPodDescription(string category, string name)
        {
            
            
                var paths = Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name;

                var xml = XmlReader.Create(paths);
                var feed = SyndicationFeed.Load(xml);
                xml.Close();

                var description = feed.Description.Text;
                return description;

        }

        public Timer aTimer;

        public void Timer( string name, string category)
        {
            using (var reader = new StreamReader(Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name +"intervall"+ ".txt"))

            {
                var intervallText = reader.ReadToEnd();
                using (var readurl = new StreamReader(Directory.GetCurrentDirectory() + @"\Categories\" + category + @"\" + name + ".txt"))
                {

                    var urlText = readurl.ReadToEnd();
                    double intervallen = double.Parse(intervallText);


                    aTimer = new Timer();
                    aTimer.Interval = intervallen;


                    aTimer.Elapsed += (s, e) =>
                    {
                        rssreader.writeToXml(urlText, name, category);
                    };


                    aTimer.AutoReset = true;


                    aTimer.Enabled = true;
                }

            }
           
        }
        public void stopTimer()
        {
            aTimer.Stop();
        }
    }
}

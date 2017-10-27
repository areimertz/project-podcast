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
        static System.Windows.Forms.Timer theTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        public void getEpisodes(string category, string name, ListBox cbox)
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
                cbox.Items.Add(item);
            }
         
        }

        public void getDescription(string name, RichTextBox lbDescription)
        {
            var descrip = from x in episodes
                          where x.Title == name
                          select x.Description;

            lbDescription.AppendText(descrip.Single().ToString());
 
        }
        public string GetPlayablePod(string name)
        {
            var Url = from x in episodes
                              where x.Title == name
                              select x.Url;

                              
            return Url.Single().ToString();
        }

        
        // Timer raised method
        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            theTimer.Stop();

            // Displays a message box asking whether to continue running the timer
            if (MessageBox.Show("Do you want to search for updates?", "Count is " + alarmCounter, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter

                alarmCounter += 0;
                theTimer.Enabled = true;
            }
            else
            {
                // Stops the timer
                exitFlag = true;
            }
        }

        public int Timer()
        {
            //Adds the event and the event handler for the method that will 
            //process the timer event to the timer
            theTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds
            theTimer.Interval = 2000;
            theTimer.Start();
           

            // Runs the timer, and raises the event
            while (exitFlag == false)
            {
                // Processes all the events in the queue
                Application.DoEvents();
            }
            return 0;
        }
    }
}
    



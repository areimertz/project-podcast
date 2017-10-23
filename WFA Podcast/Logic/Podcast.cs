using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datalayer;
using System.IO;


namespace Logic
{
    public class Podcast
    {
        RSS datalayer = new RSS();
        DataSaver newPod = new DataSaver();




        public void getNewPod(string Url, string category, string name)
        {
            DataSaver newPod = new DataSaver();
            newPod.addNewPod(Url, category, name);
        }
    }
}


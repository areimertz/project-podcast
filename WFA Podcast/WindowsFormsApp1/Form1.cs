using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        Podcast podcast = new Logic.Podcast();
        Episodes episode = new Episodes();
        Category category = new Category();
        public Form1()
        {
            InitializeComponent();
            fillCategories();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCategory_Click(object sender, EventArgs e) 
        {
            
            string text = TBoxAddNewCategory.Text;
            category.SaveCategory(text);
            LBoxCategory.Items.Clear();
            CombBoxSelectAnExistingCategory.Items.Clear();
            TBoxAddNewCategory.Clear();
            fillCategories();
        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


            LBoxPodcast.Items.Clear();
            fillpodcasts(LBoxCategory.SelectedItem.ToString());


        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblEpisode.Items.Clear();
            var category = LBoxCategory.SelectedItem.ToString();
            var path = LBoxPodcast.SelectedItem.ToString();
            episode.getEpisodes(category, path, cblEpisode);


        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
           
            var podName = TBoxName.Text;
            var url = TBoxChosenURL.Text;
            var cat = CombBoxSelectAnExistingCategory.SelectedItem.ToString();
            podcast.podcastinfo(url, cat, podName);
            TBoxName.Clear();
            TBoxChosenURL.Clear();
            LBoxCategory.Items.Clear();
            CombBoxSelectAnExistingCategory.Items.Clear();
            fillCategories();
            MessageBox.Show("Podcast added");
        }

      
        public void fillCategories()
        {
            try
            {
                string[] catArray = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\Categories");
                foreach (String cat in catArray)
                {
                    string[] trimmadCat = cat.Split('\\');
                    int langd = trimmadCat.Length - 1;
                    string fixadCat = trimmadCat[langd];
                    LBoxCategory.Items.Add(fixadCat);
                    CombBoxSelectAnExistingCategory.Items.Add(fixadCat);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void fillpodcasts(String category)
        {
             category = LBoxCategory.SelectedItem.ToString();
            try
            {
                string[] podArray = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Categories\"  +  category );
                foreach (String pod in podArray)
                {
                    string[] trimmadpod = pod.Split('\\');
                    int langd = trimmadpod.Length - 1;
                    string fixadpod = trimmadpod[langd];
                    
                    LBoxPodcast.Items.Add(fixadpod);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            var chosenCategory = LBoxCategory.SelectedItem.ToString();

            category.RemoveCategory(chosenCategory);

            LBoxCategory.Items.Clear();
            LBoxPodcast.Items.Clear();
            cblEpisode.Items.Clear();
            fillCategories();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = LBoxCategory.SelectedItem.ToString();
            var path = LBoxPodcast.SelectedItem.ToString();
            episode.getEpisodes(category, path, cblEpisode);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemovePodcast_Click(object sender, EventArgs e)
        {
            category.removeFile(LBoxCategory.Text, LBoxPodcast.Text);
            cblEpisode.Items.Clear();
            LBoxPodcast.Items.Clear();
            LBoxCategory.Items.Clear();
            fillCategories();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

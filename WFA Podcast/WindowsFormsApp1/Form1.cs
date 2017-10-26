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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        Podcast podcast = new Logic.Podcast();
        Episodes episode = new Episodes();
        Category category = new Category();
        Validator validation = new Validator();
        public Form1()
        {
            InitializeComponent();
            fillCategories();
            category.CategoryfillListBox(LBoxCategory, lblloading);
            TimerForMassage();


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
            if (Validator.textFieldNotEmpty(tbNewCategory, " new category name"))
            {
                if (cbChooseCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a category to rename.");
                    return;
                }
                else
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to rename this category?",
                                        "Confirm Delete.",
                                        MessageBoxButtons.YesNo);

                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            category.changeCategoryName(cbChooseCategory.Text, tbNewCategory.Text);
                            MessageBox.Show("Category has been changed to " + tbNewCategory.Text + ".");
                            cblEpisode.Items.Clear();
                            LBoxPodcast.Items.Clear();
                            LBoxCategory.Items.Clear();
                            cbChooseCategory.ResetText();
                            tbNewCategory.ResetText();
                            cbChooseCategory.Items.Clear();
                            tbNewCategory.Clear();

                            fillCategories();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (Validator.textFieldNotEmpty(TBoxAddNewCategory, " Add Category"))
            {

                string text = TBoxAddNewCategory.Text;
                category.SaveCategory(text);
                LBoxCategory.Items.Clear();
                CombBoxSelectAnExistingCategory.Items.Clear();
                TBoxAddNewCategory.Clear();
                fillCategories();
            }


        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


            LBoxPodcast.Items.Clear();
            fillpodcasts(LBoxCategory.SelectedItem.ToString());


        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblEpisode.Items.Clear();
            richTbDesc.Clear();
            var category = LBoxCategory.SelectedItem.ToString();
            var path = LBoxPodcast.SelectedItem.ToString();
            episode.getEpisodes(category, path, cblEpisode);
            podcast.getPodDescription(category, path, richTbDesc);


        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
            if (Validator.textFieldNotEmpty(TBoxName, " Name") && Validator.textFieldNotEmpty(TBoxChosenURL, " Chosen Url") && Validator.checkUrl(TBoxChosenURL.Text, CombBoxSelectAnExistingCategory.SelectedItem.ToString(), TBoxName.Text))
            {
                if (CombBoxSelectAnExistingCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a value to the combobox");
                    return;
                }
                else
                {
                    var podName = TBoxName.Text;
                    var url = TBoxChosenURL.Text;
                    var cat = CombBoxSelectAnExistingCategory.SelectedItem.ToString();
                    podcast.podcastinfo(url, cat, podName);
                    TBoxName.Clear();
                    TBoxChosenURL.Clear();
                    LBoxCategory.Items.Clear();
                    CombBoxSelectAnExistingCategory.ResetText();
                    CombBoxSelectAnExistingCategory.Items.Clear();
                    fillCategories();
                    MessageBox.Show("Podcast added");
                }
            }
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
                    cbnewCategory.Items.Add(fixadCat);
                    cbChooseCategory.Items.Add(fixadCat);
                    CombBoxSelectAnExistingCategory.Items.Add(fixadCat);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void fillpodcasts(String category)
        {
            category = LBoxCategory.SelectedItem.ToString();
            try
            {
                string[] podArray = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Categories\" + category);
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
            if (Validator.checkCategory(LBoxCategory, " category"))
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this Category?",
                                    "Confirm Delete.",
                                    MessageBoxButtons.YesNo);
                {
                    if (confirmResult == DialogResult.Yes) {

                        var chosenCategory = LBoxCategory.SelectedItem.ToString();

                        category.remove(chosenCategory);

                        LBoxCategory.Items.Clear();
                        LBoxPodcast.Items.Clear();
                        cblEpisode.Items.Clear();
                        fillCategories();
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTbEpisode.Clear();
            var epi = cblEpisode.SelectedItem.ToString();
            episode.getDescription(epi, rTbEpisode);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemovePodcast_Click(object sender, EventArgs e)
        {
            if (Validator.checkCategory(LBoxPodcast, " Podcast"))
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this podcast?",
                                    "Confirm Delete.",
                                    MessageBoxButtons.YesNo);
                {
                    if (confirmResult == DialogResult.Yes)
                    {
                        category.remove(LBoxCategory.Text, LBoxPodcast.Text);
                        cblEpisode.Items.Clear();
                        LBoxPodcast.Items.Clear();
                        LBoxCategory.Items.Clear();
                        fillCategories();

                    }
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBoxEpisodeDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBoxPodcastDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnChangeCategory_Click(object sender, EventArgs e)
        {

            if (Validator.comboBoxMovePodcast(cbnewCategory, LBoxCategory))
            {
                if (cbnewCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a Category to move.");
                    return;
                }
                else {
                    var confirmResult = MessageBox.Show("Are you sure you want to change this Feed?",
                                        "Confirm Delete.",
                                        MessageBoxButtons.YesNo);

                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            category.remove(LBoxCategory.Text, LBoxPodcast.Text);
                            var podName = tbPodcastChange.Text;
                            var url = tbNewUrl.Text;
                            var cat = cbnewCategory.SelectedItem.ToString();
                            podcast.podcastinfo(url, cat, podName);
                            MessageBox.Show("Podcast has been moved to " + cbnewCategory.SelectedItem.ToString() + ".");
                            cblEpisode.Items.Clear();
                            LBoxPodcast.Items.Clear();
                            LBoxCategory.Items.Clear();
                            cbnewCategory.ResetText();
                            
                            cbnewCategory.Items.Clear();
                           

                            fillCategories();
                        }
                    }
                }
            }
        }


        private void BtnPlayPodcast_Click(object sender, EventArgs e)
        {
            var selected = cblEpisode.SelectedItem.ToString();
            var url = episode.GetPlayablePod(selected);
            Process.Start(url);
        }

        private void TBoxChosenURL_TextChanged(object sender, EventArgs e)
        {

        }
         internal void MessageUpdate()
        {
            MessageBox.Show("To update your episodes, relaunch the program!");
        }
        public void TimerForMassage()
        {
            var StartTimeSpan = TimeSpan.Zero;
            var periodTimespan = TimeSpan.FromSeconds(1500);
            var timer = new System.Threading.Timer((e) =>
            {
                MessageUpdate();
            },null, StartTimeSpan, periodTimespan);
        }

    }
}

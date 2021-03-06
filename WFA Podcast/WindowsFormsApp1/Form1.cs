﻿using System;
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
            CategoryfillListBox(LBoxCategory,lblloading);
            fillInterval();
        }

        public async void CategoryfillListBox(ListBox LB, Label lblloading)
        {
            try
            {
                Task<List<string>> result;
                result = category.fillListCategory();
                lblloading.Text = "Loading..";
                await result;
                List<string> AllCategories = result.Result;
                foreach (var item in AllCategories)
                {
                    LB.Items.Add(item);
                }
                lblloading.Text = "Done!";
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void fillInterval()
        {
            try
            {
                CombBoxSelectYourUpdateInterval.Items.Add("2000");
                CombBoxSelectYourUpdateInterval.Items.Add("5000");
                CombBoxSelectYourUpdateInterval.Items.Add("10000");
                CombBoxSelectYourUpdateInterval.Items.Add("300000");
                cbChooseIV.Items.Add("2000");
                cbChooseIV.Items.Add("5000");
                cbChooseIV.Items.Add("10000");
                cbChooseIV.Items.Add("300000");
            }
            catch (Exception)
            {
                throw;
            }
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
            try { 
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
                                LBoxEpisode.Items.Clear();
                                LBoxPodcast.Items.Clear();
                                LBoxCategory.Items.Clear();
                                cbChooseCategory.ResetText();
                                tbNewCategory.ResetText();
                                cbChooseCategory.Items.Clear();
                                CombBoxSelectAnExistingCategory.ResetText();
                                CombBoxSelectAnExistingCategory.Items.Clear();
                                cbnewCategory.ResetText();
                                cbnewCategory.Items.Clear();
                                tbNewCategory.Clear();
                                fillCategories();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.textFieldNotEmpty(TBoxAddNewCategory, " Add Category"))
                {

                    string text = TBoxAddNewCategory.Text;
                    category.SaveCategory(text);
                    LBoxCategory.Items.Clear();
                    CombBoxSelectAnExistingCategory.Items.Clear();
                    TBoxAddNewCategory.Clear();
                    cbChooseCategory.Items.Clear();
                    cbnewCategory.ResetText();
                    cbnewCategory.Items.Clear();
                    fillCategories();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rTbEpisode.Clear();
                richTbDesc.Clear();
                LBoxEpisode.Items.Clear();
                LBoxPodcast.Items.Clear();
                fillpodcasts(LBoxCategory.SelectedItem.ToString());
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTbDesc.Clear();
                LBoxEpisode.Items.Clear();
                var categories = LBoxCategory.SelectedItem.ToString();
                var path = LBoxPodcast.SelectedItem.ToString();
                
               
                
                episode.getEpisodes(categories, path);
                var list = episode.getListEpisodes();
                foreach (var item in list)
                {
                    LBoxEpisode.Items.Add(item.Title.ToString());
                }
               var podDesc = podcast.getPodDescription(categories, path);
                richTbDesc.AppendText(podDesc);
                podcast.Timer(path, categories);
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.textFieldNotEmpty(TBoxName, " Name") && Validator.textFieldNotEmpty(TBoxChosenURL, " Chosen Url") && Validator.checkUrl(TBoxChosenURL.Text, CombBoxSelectAnExistingCategory.SelectedItem.ToString(), TBoxName.Text))
                {
                    if (CombBoxSelectAnExistingCategory.SelectedItem == null && CombBoxSelectYourUpdateInterval.SelectedItem == null)
                    {
                        MessageBox.Show("Please choose a value to the combobox");
                        return;
                    }
                    else
                    {
                        var podName = TBoxName.Text;
                        var url = TBoxChosenURL.Text;
                        var cat = CombBoxSelectAnExistingCategory.SelectedItem.ToString();
                        var intervall = CombBoxSelectYourUpdateInterval.SelectedItem.ToString();
                        var intervallen = double.Parse(intervall);
                        podcast.podcastinfo(url, cat, podName, intervallen);
                        TBoxName.Clear();
                        TBoxChosenURL.Clear();
                        LBoxCategory.Items.Clear();
                        CombBoxSelectAnExistingCategory.ResetText();
                        CombBoxSelectAnExistingCategory.Items.Clear();
                        CombBoxSelectYourUpdateInterval.ResetText();
                        CombBoxSelectYourUpdateInterval.Items.Clear();
                        cbnewCategory.ResetText();
                        cbnewCategory.Items.Clear();
                        cbChooseCategory.Items.Clear();
                        cbChooseIV.ResetText();
                        cbChooseIV.Items.Clear();
                        fillInterval();
                        fillCategories();
                        MessageBox.Show("Podcast added");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        internal void fillCategories()
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
            catch (Exception)
            {
                throw;
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
                    if (!pod.EndsWith(".txt"))
                    {
                        if (!pod.EndsWith(".xml"))
                        { 
                        string[] trimmadpod = pod.Split('\\');

                        int langd = trimmadpod.Length - 1;
                        string fixadpod = trimmadpod[langd];

                        LBoxPodcast.Items.Add(fixadpod);
                    }
                }
                    }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            try { 
            if (Validator.checkCategory(LBoxCategory, " category"))
            {
                    
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this Category?",
                                    "Confirm Delete.",
                                    MessageBoxButtons.YesNo);
                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            
                            var chosenCategory = LBoxCategory.SelectedItem.ToString();

                            category.remove(chosenCategory);
                            richTbDesc.Clear();
                            LBoxCategory.Items.Clear();
                            LBoxPodcast.Items.Clear();
                            LBoxEpisode.Items.Clear();
                            CombBoxSelectAnExistingCategory.ResetText();
                            CombBoxSelectAnExistingCategory.Items.Clear();
                            cbnewCategory.ResetText();
                            cbnewCategory.Items.Clear();
                            rTbEpisode.Clear();
                            fillCategories();
                        }
                    }
                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rTbEpisode.Clear();
                var epi = LBoxEpisode.SelectedItem.ToString();
                var selected = episode.getDescription(epi);
                rTbEpisode.AppendText(epi);

                
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemovePodcast_Click(object sender, EventArgs e)
        {
            try { 
            if (Validator.checkCategory(LBoxPodcast, " Podcast"))
            {
                    podcast.stopTimer();
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this podcast?",
                                    "Confirm Delete.",
                                    MessageBoxButtons.YesNo);
                    {
                        if (confirmResult == DialogResult.Yes)
                        {
                            
                           
                            category.remove(LBoxCategory.Text, LBoxPodcast.Text);
                            LBoxEpisode.Items.Clear();
                            LBoxPodcast.Items.Clear();
                            LBoxCategory.Items.Clear();
                            CombBoxSelectAnExistingCategory.ResetText();
                            CombBoxSelectAnExistingCategory.Items.Clear();
                            cbnewCategory.ResetText();
                            cbnewCategory.Items.Clear();
                            cbChooseCategory.ResetText();
                            cbChooseCategory.Items.Clear();
                            richTbDesc.Clear();
                            fillCategories();

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
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
            try { 
            if (Validator.comboBoxMovePodcast(cbnewCategory, LBoxCategory) && Validator.checkUrl(tbNewUrl.Text, cbnewCategory.SelectedItem.ToString(), tbPodcastChange.Text) && Validator.textFieldNotEmpty(tbPodcastChange, " podcast name") && Validator.checkCategory(LBoxPodcast, " Podcast"))
            {
                if (cbnewCategory.SelectedItem == null && cbChooseIV.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a Category to move.");
                    return;
                }
                else {
                        podcast.stopTimer();
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
                                var intervall = cbChooseIV.SelectedItem.ToString();
                                var intervallen = double.Parse(intervall);
                                podcast.podcastinfo(url, cat, podName, intervallen);
                                MessageBox.Show("Podcast has been moved to " + cbnewCategory.SelectedItem.ToString() + ".");
                                
                                LBoxEpisode.Items.Clear();
                                LBoxPodcast.Items.Clear();
                                LBoxCategory.Items.Clear();
                                cbnewCategory.ResetText();
                                cbChooseIV.ResetText();
                                cbnewCategory.Items.Clear();
                                cbChooseIV.Items.Clear();
                                tbPodcastChange.Clear();
                                tbNewUrl.Clear();
                                CombBoxSelectYourUpdateInterval.ResetText();
                                CombBoxSelectYourUpdateInterval.Items.Clear();
                                CombBoxSelectAnExistingCategory.ResetText();
                                CombBoxSelectAnExistingCategory.Items.Clear();
                                cbChooseCategory.ResetText();
                                cbChooseCategory.Items.Clear();
                                richTbDesc.Clear();
                                fillCategories();
                                fillInterval();


                            }
                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void BtnPlayPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = LBoxEpisode.SelectedItem.ToString();
                var url = episode.GetPlayablePod(selected);

                Process.Start(url);
                var picked = PlayedPod.Items.Add(selected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TBoxChosenURL_TextChanged(object sender, EventArgs e)
        {

        }
       
        
        private void LBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rTbEpisode.Clear();

                var epi = LBoxEpisode.SelectedItem.ToString();
                var selected = episode.getDescription(epi);
                rTbEpisode.AppendText(epi);
                var list = episode.getListEpisodes();
                foreach (var item in list)
                {
                    if (item.Title == epi)
                    {
                        var desc = item.Description;
                        if (desc != null)
                        {
                            rTbEpisode.Text = desc;
                        }
                        else {
                            rTbEpisode.Text = "Podcast ";
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbnewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}

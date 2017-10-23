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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        Podcast podcast = new Logic.Podcast();
        Category category = new Category();
        public Form1()
        {
            InitializeComponent();
            fillCategories();
            fillpodcasts();
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
            fillCategories();
        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           



        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillpodcasts();

        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
            /*string URL = TBoxChosenURL.Text;
            string Name = TBoxName.Text;
            string Category = CombBoxSelectAnExistingCategory.Text;
            string Interval = CombBoxSelectYourUpdateInterval.Text;

            podcast.addNewPod(URL, Name, Category, Interval);*/
            if (CombBoxSelectAnExistingCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select the category this podcast should be in in the combobox above.");
                return;
            }
            else
            {
                Podcast xmlfeed = new Podcast();
                xmlfeed.getNewPod( TBoxChosenURL.Text, CombBoxSelectAnExistingCategory.SelectedItem.ToString(), TBoxName.Text);
               LBoxPodcast.Items.Clear();
                LBoxCategory.Items.Clear();
                
                MessageBox.Show(TBoxName.Text + " has now been added to the category " + CombBoxSelectAnExistingCategory.SelectedItem.ToString() + ".");
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
                    CombBoxSelectAnExistingCategory.Items.Add(fixadCat);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void fillpodcasts()
        {
            try
            {
                string[] podArray = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Categories\"  +   @"\");
                foreach (var pod in podArray)
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
            fillCategories();
        }
    }
}

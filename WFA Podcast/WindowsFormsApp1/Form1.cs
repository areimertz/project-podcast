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
        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           



        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
            string URL = TBoxChosenURL.Text;
            podcast.addNewPod(URL);
            

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
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

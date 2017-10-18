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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        Podcast podcast = new Logic.Podcast();
        public Form1()
        {
            InitializeComponent();
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
            Category test = new Category();
            string text = TBoxAddNewCategory.Text;
            test.fillCategory(text);
        }

        private void LBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Category> listOfCategory = new List<Category>();
            
        }

        private void LBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddPodcast_Click(object sender, EventArgs e)
        {
            string URL = TBoxChosenURL.Text;
            podcast.addNewPod(URL);
            

        }
    }
}

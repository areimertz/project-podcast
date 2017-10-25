﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Validator
    {

        public static bool textFieldNotEmpty(TextBox empty, string label)
        {
            if (empty.Text == "")
            {
                MessageBox.Show("Please insert value to" + label);
                empty.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkCategory(ListBox empty, string label)
        {
            if (empty.Text == "")
            {
                MessageBox.Show("Please pick a value in" + label);
                empty.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool comboBoxMovePodcast(ComboBox combobox, ListBox lista)
        {
            if (combobox.Text == "")
            {
                MessageBox.Show("Please choose insert value to the combobox");
                combobox.Focus();
                return false;
            }
            else if (combobox.SelectedItem == lista.SelectedItem)
            {
                MessageBox.Show("The podcast is already located in the selected category.");
                combobox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

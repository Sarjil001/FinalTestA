using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 * STUDENT NAME: SARJIL RAVAL
 * STUDENT ID: 301043757
 * DESCRIPTION: This is the Data Container Class
 */

namespace FinalTestA.Views
{
    public partial class HeroGenerator : FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event handler for the BackButtonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the Event handler for the NextButtonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            {
                //Inputing First Name
                string[] lines;
                lines = File.ReadAllLines("firstNames.txt");
                Random rand = new Random();
                int index = rand.Next(lines.Length);
                FirstNameDataLabel.Text = lines[index];

                //Inputing Last Name
                string[] Line;
                Line = File.ReadAllLines("lastNames.txt");
                Random rands = new Random();
                int indexs = rand.Next(Line.Length);
                LastNameDataLabel.Text = Line[indexs];
            }
        }
    }
}

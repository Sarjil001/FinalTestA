using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

/*
 * STUDENT NAME: SARJIL RAVAL
 * STUDENT ID: 301043757
 * DESCRIPTION: This is the Data Container Class
 */

namespace FinalTestA.Views
{
    public partial class HeroGenerator : FinalTestA.Views.MasterForm
    {
        List<string> firstNameList;
        List<string> lastNameList;
        Random random = new Random();

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
            GenerateNames();
        }

        public void loadnames()
        {
            //Inputing First Name
           firstNameList = File.ReadAllLines("firstNames.txt").ToList();
            //Inputing Last Name
           lastNameList = File.ReadAllLines("lastNames.txt").ToList();
        }

        public void GenerateNames()
        {
            //Generating Random Name

            int index = random.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            loadnames();
            GenerateNames();
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            FightingDataLabel.Text= random.Next(1,15).ToString();
            AgilityDataLabel.Text = random.Next(1, 15).ToString();
            StrengthDataLabel.Text = random.Next(1, 15).ToString();
            EnduranceDataLabel.Text = random.Next(1, 15).ToString();
            ReasonDataLabel.Text = random.Next(1, 15).ToString();
            IntuitionDataLabel.Text = random.Next(1, 15).ToString();
            PsycheDataLabel.Text = random.Next(1, 15).ToString();
            PopularityDataLabel.Text = random.Next(1, 15).ToString();

        }

    }
}

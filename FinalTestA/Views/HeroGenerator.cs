using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Diagnostics;

/*
 * STUDENT NAME: SARJIL RAVAL
 * STUDENT ID: 301043757
 * DESCRIPTION: This is the Data Container Class 
 */

namespace FinalTestA.Views
{
    public partial class HeroGenerator : FinalTestA.Views.MasterForm
    {
        //List Created
        List<string> PowersList = new List<string>();
        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();

        //Random Variable
        Random random = new Random();

        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            loadnames();
            GenerateNames();
            LoadPowers();
        }

        /// <summary>
        /// This is the Event handler for the NextButtonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //If the Hero Name is not Entered
            if (String.IsNullOrEmpty(HeroNameTextBox.Text))
            {
                //message alerting user the file has been saved
                MessageBox.Show("Enter the Hero Name...", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Program.character.FirstName = FirstNameDataLabel.Text;
                Program.character.LastName = LastNameDataLabel.Text;
                Program.character.HeroName = HeroNameTextBox.Text;

                if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
                {
                    MainTabControl.SelectedIndex++;
                }
            }

            //Opening the saved File in Tabpage 3
            if(MainTabControl.SelectedIndex == 3)
            {
                CharacterHeroNameLabelText.Text = Program.character.HeroName;
                CharacterFirstNameLabelText.Text = Program.character.FirstName;
                CharacterLastNameLabelText.Text = Program.character.LastName;
                CharacterFightingLabelText.Text = Program.character.Fighting;
                CharacterAgilityLabelText.Text = Program.character.Agility;
                CharacterStrengthLabelText.Text = Program.character.Strength;
                CharacterEnduranceLabelText.Text = Program.character.Endurance;
                CharacterReasonLabelText.Text = Program.character.Reason;
                CharacterIntuitoinLabelText.Text = Program.character.Intuition;
                CharacterPyscheLabelText.Text = Program.character.Psyche;
                CharacterPower1LabelText.Text = Program.power.Power1;
                CharacterPower2LabelText.Text = Program.power.Power2;
                CharacterPower3LabelText.Text = Program.power.Power3;
                CharacterPower4LabelText.Text = Program.power.Power4;
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

        /// <summary>
        /// This is the Event Handler for the Generate Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        //Load Names Method Created
        public void loadnames()
        {
            //Loading First Name File
            string fileFNamePath = @"../../Data/firstNames.txt";
            FirstNameList = File.ReadAllLines(fileFNamePath).ToList();
            //Loading Second Name File
            string fileLNamePath = @"../../Data/lastNames.txt";           
            LastNameList = File.ReadAllLines(fileLNamePath).ToList();
        }
    
        public void GenerateNames()
        {
            //Calling Method
            loadnames();

            //Inputing First Name
            int index = random.Next(FirstNameList.Count);
            FirstNameDataLabel.Text = FirstNameList[index];

            //Inputing Last Name
            int indexs = random.Next(LastNameList.Count);
            LastNameDataLabel.Text = LastNameList[indexs];
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        { 
            //Showing random numbers in the ability
            FightingDataLabel.Text = random.Next(10, 50).ToString();
            AgilityDataLabel.Text = random.Next(10, 50).ToString();
            StrengthDataLabel.Text = random.Next(10, 50).ToString();
            EnduranceDataLabel.Text = random.Next(10, 50).ToString();
            ReasonDataLabel.Text = random.Next(10, 50).ToString();
            IntuitionDataLabel.Text = random.Next(10, 50).ToString();
            PsycheDataLabel.Text = random.Next(10, 50).ToString();
            PopularityDataLabel.Text = random.Next(10, 50).ToString();

            //Saving the output to the Program.character
            Program.character.Fighting = FightingDataLabel.Text;
            Program.character.Agility = AgilityDataLabel.Text;
            Program.character.Strength = StrengthDataLabel.Text;
            Program.character.Endurance = EnduranceDataLabel.Text;
            Program.character.Reason = ReasonDataLabel.Text;
            Program.character.Intuition = IntuitionDataLabel.Text;
            Program.character.Psyche = PsycheDataLabel.Text;
            Program.character.Popularity = PopularityDataLabel.Text;
        }

        private void LoadPowers()
        {
            //Loading Powers List
            string filePowerPath = @"../../Data/powers.txt";
            PowersList = File.ReadAllLines(filePowerPath).ToList();
        }

        private void GeneratePowersButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();

            //Saving Generated Powers
            Program.power.Power1 = Power1LabelText.Text;
            Program.power.Power2 = Power2LabelText.Text;
            Program.power.Power3 = Power3LabelText.Text;
            Program.power.Power4 = Power4LabelText.Text;
        }

        /// <summary>
        /// For Creating Random Powers
        /// </summary>
        private void GenerateRandomPowers()
        {
            LoadPowers();

            //Creating Random Powers from the File
            int index1 = random.Next(PowersList.Count);
            Power1LabelText.Text = PowersList[index1];
            int index2 = random.Next(PowersList.Count);
            Power2LabelText.Text = PowersList[index2];
            int index3 = random.Next(PowersList.Count);
            Power3LabelText.Text = PowersList[index3];
            int index4 = random.Next(PowersList.Count);
            Power4LabelText.Text = PowersList[index4];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the Event Handler for Saving the Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = "SuperHero.txt";
            SaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file diolog
            var result = SaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputString = new StreamWriter(File.Open(SaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputString.WriteLine(Program.character.HeroName);
                    outputString.WriteLine(Program.character.FirstName);
                    outputString.WriteLine(Program.character.LastName);
                    outputString.WriteLine(Program.character.Fighting);
                    outputString.WriteLine(Program.character.Agility);
                    outputString.WriteLine(Program.character.Strength);
                    outputString.WriteLine(Program.character.Endurance);
                    outputString.WriteLine(Program.character.Reason);
                    outputString.WriteLine(Program.character.Intuition);
                    outputString.WriteLine(Program.character.Psyche);
                    outputString.WriteLine(Program.power.Power1 );
                    outputString.WriteLine(Program.power.Power2);
                    outputString.WriteLine(Program.power.Power3);
                    outputString.WriteLine(Program.power.Power4);                  

                    // close file
                    outputString.Close();
                    outputString.Dispose();

                    //message alerting user the file has been saved
                    MessageBox.Show("File Saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// This is the Event Handler for opening the Saved Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //confgure the dile dialog
            OpenFileDialog.FileName = "SuperHero.txt";
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file diolog
            var result = OpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open file stream to read
                    using (StreamReader inputStream = new StreamReader(File.Open(OpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file
                        Program.character.HeroName = inputStream.ReadLine();
                        Program.character.FirstName = inputStream.ReadLine();
                        Program.character.LastName = inputStream.ReadLine();
                        Program.character.Fighting = inputStream.ReadLine();
                        Program.character.Agility = inputStream.ReadLine();
                        Program.character.Strength = inputStream.ReadLine();
                        Program.character.Endurance = inputStream.ReadLine();
                        Program.character.Reason = inputStream.ReadLine();
                        Program.character.Intuition = inputStream.ReadLine();
                        Program.character.Psyche = inputStream.ReadLine();
                        Program.power.Power1 = inputStream.ReadLine();
                        Program.power.Power2 = inputStream.ReadLine();
                        Program.power.Power3 = inputStream.ReadLine();
                        Program.power.Power4 = inputStream.ReadLine();
                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR " + exception.Message);
                    MessageBox.Show("ERROR " + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Adding the Opend Data
                CharacterHeroNameLabelText.Text = Program.character.HeroName;
                CharacterFirstNameLabelText.Text = Program.character.FirstName;
                CharacterLastNameLabelText.Text = Program.character.LastName;
                CharacterFightingLabelText.Text = Program.character.Fighting;
                CharacterAgilityLabelText.Text = Program.character.Agility;
                CharacterStrengthLabelText.Text = Program.character.Strength;
                CharacterEnduranceLabelText.Text = Program.character.Endurance;
                CharacterReasonLabelText.Text = Program.character.Reason;
                CharacterIntuitoinLabelText.Text = Program.character.Intuition;
                CharacterPyscheLabelText.Text = Program.character.Psyche;
                CharacterPower1LabelText.Text = Program.power.Power1;
                CharacterPower2LabelText.Text = Program.power.Power2;
                CharacterPower3LabelText.Text = Program.power.Power3;
                CharacterPower4LabelText.Text = Program.power.Power4;
            }
        }
    }
}
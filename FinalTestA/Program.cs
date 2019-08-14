using FinalTestA.Objects;
using FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * STUDENT NAME: SARJIL RAVAL
 * STUDENT ID: 301043757
 * DESCRIPTION: This Program Creates a Random Firstname and Lastname. It also Creates the Powers of the SuperHero and IT shows the Rating of thier skills
 * Character Sheet Saves the Data And Opens the Saved data
 */

namespace FinalTestA
{
    public static class Program
    {

        public static HeroGenerator heroGenerator;
        public static Hero character;
        public static Power power;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            character = new Hero();
            power = new Power();

            Application.Run(heroGenerator);
        }
    }
}

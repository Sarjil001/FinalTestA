using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: SARJIL RAVAL
 * STUDENT ID: 301043757
 * DESCRIPTION: This is the Data Container Class
 */

namespace FinalTestA.Objects
{
    class Hero
    {
        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physical Abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        //Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }

        //Power List
        List<Power> Powers;
        
        //Construtor
        Hero()
        {
            // Instantiates an empty Power List
            Powers = new List<Power>();
        }
    }
}

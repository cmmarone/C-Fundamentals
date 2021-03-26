using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamChallenge
{
    public class Developer
    {


        public string DeveloperName { get; set; }
        public string DeveloperID { get; set; }
        public bool HasPluralsightAcces { get; set; }


        public Developer()
        {

        }

        public Developer(string team, char teamID, List<Developer> developer, string developerName, bool hasPluralsightAccess)
               
        {
            DeveloperID = RandomGenerator.GenerateID().ToString();
            DeveloperName = developerName;
            HasPluralsightAcces = hasPluralsightAccess;
        }
    }
}

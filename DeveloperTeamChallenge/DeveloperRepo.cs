using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamChallenge
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        public bool AddDeveloperToDirectory(Developer developer)
        {
            _developerDirectory.Add(developer);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamChallenge
{
    public class Team
    {
        public string TeamName { get; set; }
        public char TeamID { get; set; }
        public List<Developer> _developersOnTeam { get; set; }

        public Team()
        {

        }

        public Team(string team, char teamID, List<Developer> developer)
        {
            TeamName = team;
            TeamID = teamID;
            _developersOnTeam = developer;
        }

    }
}

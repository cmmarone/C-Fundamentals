using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamChallenge
{
    public class TeamRepo
    {
        protected readonly List<Team> _teamDirectory = new List<Team>();




        public bool AddTeam(Team team)
        {
            int startingCount = _teamDirectory.Count;

            _teamDirectory.Add(team);

            bool wasAdded = (_teamDirectory.Count > startingCount) ? true : false;
            return wasAdded;        
        }




        public List<Team> GetTeams()
        {
            return _teamDirectory;
        }



        public Team GetTeamByID(char teamID)
        {
            foreach (Team team in _teamDirectory)
            {
                if (team.TeamID == teamID)
                {
                    return team;
                }
            }
            return null;
        }

        public Team DeleteTeamByID(char teamID)
        {
            foreach (Team team in _teamDirectory)
            {
                if (team.TeamID == teamID)
                {
                    DeleteTeam(team);
                }
            }
            return null;
        }



        //helper method in this context
        public bool DeleteTeam(Team existingTeam)
        {
            bool isDeleted = _teamDirectory.Remove(existingTeam);
            return isDeleted;
        }
    }
}

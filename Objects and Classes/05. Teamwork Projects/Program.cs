using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program // Does not work!!!
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] creatorAndTeamName = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string creator = creatorAndTeamName[0];
                string teamname = creatorAndTeamName[1];

                Team team = new Team(teamname, creator);

                teams.Add(team);
            }

            foreach (Team team in teams)
            {
                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
            }

            string nextCommand = Console.ReadLine();

            while (nextCommand != "end of assignment")
            {
                string[] nextCommandInput = nextCommand.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string newMember = nextCommandInput[0];
                string teamName = nextCommandInput[1];

                Team existingTeam = teams.Find(x => x.TeamName == teamName);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                Team existingCreator = teams.Find(x => x.Creator == newMember);

                if (existingCreator != null && existingTeam != null)
                {
                    Console.WriteLine($"{newMember} cannot create another team!");
                }

                Team existingMember = teams.Find(x => x.Memebers.Contains(newMember));

                if ((existingMember != null || existingCreator != null) && existingTeam != null)
                {
                    Console.WriteLine($"Member {newMember} cannot join team {teamName}!");
                }

                if (existingMember == null && existingTeam != null)
                {
                    existingTeam.AddMember(newMember);
                }

                if (existingMember != null && existingTeam == null)
                {
                    Console.WriteLine($"Teams to disband:");
                    Console.WriteLine(existingTeam.Creator);
                }

                //------------------
                nextCommand = Console.ReadLine();
            }

            //"{teamName}:
            //- { creator}
            //-- { member}…"

            foreach (Team team in teams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine(team.Creator);

                foreach (var member in team.Memebers)
                {
                    Console.WriteLine(member);
                }
                
            }
        }
    }
}

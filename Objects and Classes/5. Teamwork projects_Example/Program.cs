using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_projects_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string creator = tokens[0];
                string name = tokens[1];

                Team existingTeam = allTeams.Find(t => t.Name == name); //returs Team || null

                Team existingTeamCreator = allTeams.Find(t => t.Creator == creator);//Predicate - t => t.Creator == creator
                                                                                    // The Predicate in an "if"-check. returs True or Fals!

                //for (int j = 0; j < allTeams.Count; j++) // Equivalent of == allTeams.Find(t => t.Creator == creator) 
                //{
                //    Team current = allTeams[i];
                //
                //    if (current.Creator == creator)
                //    {
                //        return current; //"Find" is a method that returs "current"
                //    }
                //
                //    else
                //    {
                //        return null;
                //    }
                //}

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue; 
                }

                if (existingTeamCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team myTeam = new Team(creator, name);
                allTeams.Add(myTeam);

                Console.WriteLine($"Team {myTeam.Name} has been created by {myTeam.Creator}!");
            }

            string line;

            while ((line = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = line.Split("->");
                string member = tokens[0];
                string name = tokens[1];

                Team searchedExistingTeam = allTeams.Find(t => t.Name == name);
                Team searchedExistingTeamMember = allTeams.Find(t => t.Members.Contains(member) || t.Creator == member);

                if (searchedExistingTeam == null)
                {
                    Console.WriteLine($"Team {name} does not exist!");
                    continue;
                }

                if (searchedExistingTeamMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {name}!");
                    continue;
                }

                searchedExistingTeam.Members.Add(member);
            }

            List<String> allDisbandedTeams = allTeams
                .Where(t => t.Members.Count == 0) //take only the teams where there are no members
                .OrderBy(t => t.Name) //serts teams by name
                .Select(t => t.Name) //take names of the object teams
                .ToList();

            allTeams.RemoveAll(t => t.Members.Count == 0);

            List<Team> sortedteams = allTeams //Without - List<Team> in case we use .ForEach
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();
                //.ForEach(t => Console.WriteLine(t)); //With this row we can replace the next foreach

            foreach (Team t in sortedteams)
            {
                Console.WriteLine(t.ToString());
            }

            Console.WriteLine("Teams to disband:");

            foreach (String t in allDisbandedTeams)
            {
                Console.WriteLine(t);
            }
        }
    }

    class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;

            this.Members = new List<string>();
        }

        public string Creator { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public override string ToString() //properties to string
        {
            List<string> sortedMembers = this.Members.OrderBy(m => m).ToList();

            string output = $"{this.Name}\n";
            output += $"- {this.Creator}\n";

            for (int i = 0; i < sortedMembers.Count; i++)
            {
                output += $"-- {sortedMembers[i]}\n";
            }

            return output.Trim(); //remove ending empty space
        }
    }
}

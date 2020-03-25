using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;

            this.Memebers = new List<string>();
        }

        public void AddMember(string member)
        {
            Memebers.Add(member);
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Memebers { get; set; }
    }
}

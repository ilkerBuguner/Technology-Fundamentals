using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClasses_Lab___05._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] registerTeam = Console.ReadLine().Split('-');

                string creatorName = registerTeam[0];
                string teamName = registerTeam[1];

                bool isTeamNameExist = teams.Any(x => x.Name == teamName);
                bool isCreatorNameExist = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamNameExist == false && isCreatorNameExist == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNameExist)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] tokens = input.Split("->");

                string user = tokens[0];
                string teamName = tokens[1];

                bool isTeamExist = teams.Any(x => x.Name == teamName);
                bool isUserAlreadyMember = teams.Any(x => x.Members.Contains(user) || x.CreatorName == user);

                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (isUserAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
                if (isTeamExist && isUserAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Members.Add(user);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            List<Team> teamsWithOutMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsWithOutMembers)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    class Team
    {
        public Team(string name, string creatorName)
        {
            Name = name;
            CreatorName = creatorName;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}

namespace _09.Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Team
    {
        public string NameOfTeam { get; set; }
        public string CreatorOfTeam { get; set; }
        public List<string> MemberOfteam = new List<string>();
        public Team(string name, string team)
        {
            this.CreatorOfTeam = name;
            this.NameOfTeam = team;
        }
    } 
    class StartUp
    {
        static void Main()
        {
            var fulllistOfteams = new List<Team>();
            var addednamestolist = new List<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();
                var name = input[0];
                var team = input[1];
                if (fulllistOfteams.Any(x=>x.NameOfTeam == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }
                if (fulllistOfteams.Any(x=>x.CreatorOfTeam == name))
                {
                    Console.WriteLine($"{name} cannot create another team!");
                    continue;
                }
                fulllistOfteams.Add(new Team(name, team));
                addednamestolist.Add(name);
                Console.WriteLine($"Team {team} has been created by {name}!");
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                var splittedInput = input
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = splittedInput[0];
                var team = splittedInput[1];

                if (!fulllistOfteams.Any(x=>x.NameOfTeam == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (addednamestolist.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {team}!");
                    continue;
                }
                var readyforaddtolist = fulllistOfteams
                    .Single(x => x.NameOfTeam == team);
                readyforaddtolist.MemberOfteam.Add(name);
                addednamestolist.Add(name);
            }
            var orderedList = fulllistOfteams
                .OrderByDescending(x => x.MemberOfteam.Count)
                .ThenBy(y => y.NameOfTeam);
            foreach (var item in orderedList)
            {               
                if (item.MemberOfteam.Count > 0)
                {
                    Console.WriteLine(item.NameOfTeam);
                    Console.WriteLine($"- {item.CreatorOfTeam}");
                    foreach (var members in item.MemberOfteam.OrderBy(x=>x))
                    {
                        Console.WriteLine($"-- {members}");
                    }
                }                
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in fulllistOfteams
                .Where(x=>x.MemberOfteam.Count == 0).OrderBy(x=>x.NameOfTeam))
            {                 
                    Console.WriteLine(item.NameOfTeam);               
            }           
        }
    } 
}

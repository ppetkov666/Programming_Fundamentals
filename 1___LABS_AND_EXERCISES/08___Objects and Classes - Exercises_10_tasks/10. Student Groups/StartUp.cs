namespace _10.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Registration { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group
    {
        public string TownName { get; set; }
        public List<Student> Students { get; set; }
    }
    class StartUp
    {
        static void Main()
        {
            List<Town> towns = GetALlTowns();
            List<Group> Groups = GetAllGroups(towns);
            PrintingFinalResults(Groups);
            
        }
        private static void PrintingFinalResults(List<Group> groups)
        {
            var towncount = groups.Select(x => x.TownName).Distinct().Count();
            Console.WriteLine($"Created {groups.Count} groups in {towncount} towns:");
            foreach (var item in groups.OrderBy(x=>x.TownName))
            {        
                Console.Write($"{item.TownName} => ");
                Console.WriteLine(string.Join(", ",item.Students.Select(x=>x.Email)));
            }            
        }
        private static List<Group> GetAllGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns.OrderBy(x=>x.Name))
            {
                IEnumerable<Student> orderedStudents = town
                    .Students.OrderBy(x => x.Registration)
                    .ThenBy(y => y.Name)
                    .ThenBy(z => z.Email);

                while (orderedStudents.Any())
                {
                    var group = new Group();
                    group.TownName = town.Name;
                    group.Students = orderedStudents.Take(town.Seats).ToList();
                    orderedStudents = orderedStudents.Skip(town.Seats);
                    groups.Add(group);
                }
            }
            return groups;
        }
        private static List<Town> GetALlTowns()
        {
            var allTowns = new List<Town>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    var splitedInput = Regex.Split(input, @"\s=>\s").ToList();
                    var townname = splitedInput[0];
                    var seats = int.Parse(Regex.Match(splitedInput[1], @"\d+").Value);
                    Town town = new Town();
                    town.Name = townname;
                    town.Seats = seats;
                    town.Students = new List<Student>();
                    allTowns.Add(town);
                }
                else
                {
                    var splited = input
                        .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim()).ToList();
                    var name = splited[0];
                    var email = splited[1];
                    var registration = DateTime
                        .ParseExact(splited[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student student = new Student();
                    student.Name = name;
                    student.Email = email;
                    student.Registration = registration;
                    allTowns.LastOrDefault().Students.Add(student);
                }
                input = Console.ReadLine();
            }
            return allTowns;
        }
    }
}

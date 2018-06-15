namespace _07.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var populations = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();
            while (input != "report")
            {
                var parameters = input.Split('|').ToArray();
                var city = parameters[0];
                var country = parameters[1];
                var populate = long.Parse(parameters[2]);

                if ( ! populations.ContainsKey(country))
                {
                    populations.Add(country, new Dictionary<string, long>());
                    populations[country].Add(city, populate);
                }
                else 
                {
                    if ( ! populations[country].ContainsKey(city))
                    {
                        populations[country].Add(city, populate);
                    }
                     
                }
                input = Console.ReadLine();
            }
            populations = populations.OrderByDescending(p => p.Value.Values.Sum())
                .ToDictionary(p => p.Key, q => q.Value);
            foreach (var item in populations)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var items in item.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"=>{items.Key}: {items.Value}");
                }
            }

        }
    }
}

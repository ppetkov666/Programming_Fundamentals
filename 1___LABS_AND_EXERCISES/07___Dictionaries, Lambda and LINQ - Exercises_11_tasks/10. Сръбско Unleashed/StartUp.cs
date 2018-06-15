namespace _10.Сръбско_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var finalDict = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var splitedInput = input.Split('@').ToArray();
                var singerName = splitedInput[0];

                if (singerName.Last() != ' ')
                {
                    input = Console.ReadLine();
                    continue;
                }
                singerName = splitedInput[0].TrimEnd();
                var otherparameters = splitedInput[1].Split(' ').ToList();
 
                if (int.TryParse(otherparameters[otherparameters.Count - 1],out int ticketsAmount))
                {
                    if (int.TryParse(otherparameters[otherparameters.Count - 2], out int ticketPrice))
                    {
                        otherparameters.RemoveAt(otherparameters.Count - 1);
                        otherparameters.RemoveAt(otherparameters.Count - 1);

                        int income = ticketPrice * ticketsAmount;
                        var location = string.Join(" ", otherparameters);

                        if (!finalDict.ContainsKey(location))
                        {
                            finalDict.Add(location, new Dictionary<string, int>());
                        }
                        if (!finalDict[location].ContainsKey(singerName))
                        {
                            finalDict[location][singerName] = 0;
                        }
                        finalDict[location][singerName] += income;
                    }                
                }
                input = Console.ReadLine();
            }
            foreach (var item in finalDict)
            {
                Console.WriteLine(item.Key);
                foreach (var location in item.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"#  {location.Key} -> {location.Value}");
                }
            }
        }
    }
}

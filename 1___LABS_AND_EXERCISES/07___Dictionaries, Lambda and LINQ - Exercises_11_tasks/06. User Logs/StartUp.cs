namespace _06.User_Logs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var outputDict = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var splitedinput = input
                    .Split(new char[] { '=', ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string username = splitedinput[splitedinput.Length - 1];
                string ipaddress = splitedinput[1];
                int count = 1;
                if ( ! outputDict.ContainsKey(username))
                {
                    outputDict[username] = new Dictionary<string, int>();
                }
                if ( ! outputDict[username].ContainsKey(ipaddress))
                {
                    outputDict[username].Add(ipaddress, count);
                }
                else
                {
                    outputDict[username][ipaddress]++;
                }
                input = Console.ReadLine();
            }
            foreach (var item in outputDict)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var items in item.Value)
                {
                    if (items.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{items.Key} => {items.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{items.Key} => {items.Value}.");
                    }
                }
            }
        }
    }
}

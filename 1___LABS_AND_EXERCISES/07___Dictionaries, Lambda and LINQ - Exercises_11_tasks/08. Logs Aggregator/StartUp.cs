namespace _08.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var logDict = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var ip = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);
                if ( ! logDict.ContainsKey(user))
                {
                    logDict.Add(user, new Dictionary<string, int>());
                }
                if ( ! logDict[user].ContainsKey(ip))
                {
                    logDict[user].Add(ip, 0);
                }
                logDict[user][ip] += duration;
            }     
            foreach (var item in logDict.OrderBy(p=>p.Key))
            {
                Console.Write($"{item.Key}: {item.Value.Values.Sum()}");              
                Console.Write(" [");
                var ordereddict = item.Value.OrderBy(p => p.Key).ToArray();
                foreach (var ip in ordereddict)
                {
                    if (ip.Equals(ordereddict.Last()))
                    {
                        Console.Write($"{ip.Key}");
                    }
                    else
                    {
                        Console.Write($"{ip.Key}, ");
                    }                
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}

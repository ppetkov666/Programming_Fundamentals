namespace _07.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var first = @"([^&?]+)=([^&?]+)";
            var second = @"(%20|\+)+";

            while (!line.Equals("END"))
            {
                var match = Regex.Matches(line, first);

                var dictionary = new Dictionary<string, List<string>>();

                for (int i = 0; i < match.Count; i++)
                {
                    var field = match[i].Groups[1].Value;
                    field = Regex.Replace(field, second, word => " ").Trim();

                    var value = match[i].Groups[2].Value;
                    value = Regex.Replace(value, second, word => " ").Trim();

                    if (!dictionary.ContainsKey(field))
                    {
                        dictionary[field] = new List<string>();
                    }

                    dictionary[field].Add(value);
                }
                foreach (var item in dictionary)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();
                line = Console.ReadLine();
            }
        }
    }
}

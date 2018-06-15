namespace _02.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var outDict = new SortedDictionary<string, string>();
            var command = input[0];
            while (command != "END")
            {
                if (command == "A")
                {
                    outDict[input[1]] = input[2];
                }
                else if (command == "S")
                {
                    if (outDict.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {outDict[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in outDict)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine().Split().ToArray();
                command = input[0];
            }
        }
    }
}

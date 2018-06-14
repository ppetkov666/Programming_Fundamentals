namespace _01.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            var outputDict = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if ( ! outputDict.ContainsKey(item))
                {
                    outputDict[item] = 0;
                }
                outputDict[item]++;
            }
            foreach (var item in outputDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

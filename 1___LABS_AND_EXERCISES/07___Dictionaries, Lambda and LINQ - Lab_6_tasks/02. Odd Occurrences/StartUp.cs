namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var outputDictionary = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (! outputDictionary.ContainsKey(item))
                {
                    outputDictionary[item] = 0;
                }
                outputDictionary[item]++;
            }
            var output = new List<string>();
            foreach (var item in outputDictionary)
            {
                if (item.Value % 2 != 0)
                {
                    output.Add(item.Key);
                }
            }
            for (int i = 0; i < output.Count; i++)
            {
                if (i==output.Count-1)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}

namespace _03.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var outputDict = new Dictionary<string, long>();
            var resourse = Console.ReadLine();
            while (resourse != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if ( ! outputDict.ContainsKey(resourse))
                {
                    outputDict[resourse] = 0;
                }
                outputDict[resourse]+=quantity;
                resourse = Console.ReadLine();

            }
            foreach (var item in outputDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

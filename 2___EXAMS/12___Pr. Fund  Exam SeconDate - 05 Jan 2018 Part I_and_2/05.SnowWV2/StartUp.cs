using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.SnowWV2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colorsDwarfs = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                string[] dwarfInfo = input
                    .Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                if (!colorsDwarfs.ContainsKey(color))
                {
                    colorsDwarfs.Add(color, new Dictionary<string, int>());
                }
                if (!colorsDwarfs[color].ContainsKey(name))
                {
                    colorsDwarfs[color].Add(name, physics);
                }
                if (colorsDwarfs[color][name] < physics)
                {
                    colorsDwarfs[color][name] = physics;
                }
                //else
                //{
                //    colorsDwarfs[color][name] = Math.Max(colorsDwarfs[color][name], physics);
                //}
            }
            colorsDwarfs = colorsDwarfs.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value)
                .ToDictionary(y => y.Key, y => y.Value));
            List<Tuple<string, string, int>> storageList = new List<Tuple<string,string,int>>();
            foreach (var item in colorsDwarfs)
            {
                foreach (var kvp in item.Value)
                {
                    Tuple<string, string, int> tupple = new Tuple<string, string, int>(item.Key,kvp.Key,kvp.Value);
                    storageList.Add(tupple);
                }
            }
            storageList.OrderByDescending(x => x.Item3)
                       .ToList()
                       .ForEach(x => Console.WriteLine($"({x.Item1}) {x.Item2} <-> {x.Item3}"));
            //foreach (var tupple in storageList.OrderByDescending(x=>x.Item3))                             
            //{
            //    Console.WriteLine($"({tupple.Item1}) {tupple.Item2} <-> {tupple.Item3}");
            //}
        }
    }
}

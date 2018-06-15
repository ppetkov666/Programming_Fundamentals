namespace _11.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var dragonInfo = new Dictionary<string, SortedDictionary<string, double[]>>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var inputInfo = Console.ReadLine().Split().ToList();

                var type = inputInfo[0];
                var name = inputInfo[1];
                var damage = inputInfo[2];
                if (damage == "null") damage = "45";
                var health = (inputInfo[3]);
                if (health == "null") health = "250";
                var armor = (inputInfo[4]);
                if (armor == "null") armor = "10";
                if ( ! dragonInfo.ContainsKey(type))
                {
                    dragonInfo.Add(type, new SortedDictionary<string, double[]>());
                }
                if (! dragonInfo[type].ContainsKey(name))
                {
                    dragonInfo[type].Add(name, new double[] { double.Parse(damage), double.Parse(health), double.Parse(armor) });
                }
                else
                {
                    dragonInfo[type][name] = new double[] { double.Parse(damage), double.Parse(health), double.Parse(armor) };
                }       
                
            }
            foreach (var dragon in dragonInfo)
            {
                var dragonName = dragon.Value;
                var damageresult = dragonName.Values.Average(p => p[0]);
                var healthresult = dragonName.Values.Average(p => p[1]);
                var armorresult = dragonName.Values.Average(p => p[2]);

                Console.WriteLine($"{dragon.Key}::({damageresult:f2}/{healthresult:f2}/{armorresult:f2})");
                
                foreach (var item in dragon.Value)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }  
            }
        }
    }
}

namespace _09.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var regularmaterials = new SortedDictionary<string, int>();
            var specialMaterials = new Dictionary<string, int>();

            specialMaterials.Add("shards", 0);
            specialMaterials.Add("motes", 0);
            specialMaterials.Add("fragments", 0);
            bool keepgoing = true;
            while (keepgoing)
            {
                var input = Console.ReadLine().ToLower().Split().ToArray();
                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var materials = input[i + 1];
                    if (materials == "shards" || materials == "motes" || materials == "fragments")
                    {
                        specialMaterials[materials] += quantity;
                        var sum = specialMaterials[materials];
                        if (sum >= 250)
                        {
                            PrintObtainedMaterials(materials);
                            specialMaterials[materials] = sum - 250;
                            keepgoing = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!regularmaterials.ContainsKey(materials))
                        {
                            regularmaterials.Add(materials, 0);
                        }
                        regularmaterials[materials] += quantity;
                    }
                }
            }
            var orderedSpecialMat = specialMaterials
                .OrderByDescending(p=>p.Value).ThenBy(p=>p.Key);
            foreach (var item in orderedSpecialMat)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in regularmaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        private static void PrintObtainedMaterials(string materials)
        {
            if (materials== "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (materials == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (materials == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
        }
    }
}

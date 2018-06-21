namespace _04._Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

    }
    class StartUp
    {
        static void Main()
        {

            var colorsOfdwarfs = new Dictionary<string, List<Dwarf>>();
            var allDwarf = new List<Dwarf>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                var dwarfInfo = input
                    .Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = dwarfInfo[0];
                var color = dwarfInfo[1];
                var physics = int.Parse(dwarfInfo[2]);

                if (!colorsOfdwarfs.ContainsKey(color))
                {
                    colorsOfdwarfs.Add(color, new List<Dwarf>());
                }
                var dwarfByCurrentColor = colorsOfdwarfs[color];
                var searchedDwarf = dwarfByCurrentColor
                    .FirstOrDefault(d => d.Name == name);

                if (searchedDwarf != null)
                {
                    searchedDwarf.Physics = Math.Max(searchedDwarf.Physics, physics);
                }
                else
                {
                    var dwarf = new Dwarf();
                    dwarf.Name = name;
                    dwarf.Color = color;
                    dwarf.Physics = physics;
                    dwarfByCurrentColor.Add(dwarf);
                    allDwarf.Add(dwarf);
                }

            }
            var orderedResult = allDwarf
                .OrderByDescending(d => d.Physics)
                .ThenByDescending(d => colorsOfdwarfs[d.Color].Count())
                .ToList();
            foreach (var dwarfs in orderedResult)
            {
                Console.WriteLine($"({dwarfs.Color}) {dwarfs.Name} <-> {dwarfs.Physics}");
            }
        }
    }
}

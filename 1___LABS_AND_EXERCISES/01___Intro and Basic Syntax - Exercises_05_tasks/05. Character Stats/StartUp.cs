namespace _05._Character_Stats
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currenthealth = int.Parse(Console.ReadLine());
            int maxhealth = int.Parse(Console.ReadLine());
            int currentenergy = int.Parse(Console.ReadLine());
            int maxenergy = int.Parse(Console.ReadLine());
            char dots = '.';
            char vertline = '|';
            string health = "Health: |{0}{1}|";
            string energy = "Energy: |{0}{1}|";
            Console.WriteLine($"Name: {name}");
            Console.WriteLine(health, new string(vertline, currenthealth), 
                new string(dots, maxhealth - currenthealth));
            Console.WriteLine(energy, new string(vertline, currentenergy), 
                new string(dots, maxenergy - currentenergy));
        }
    }
}

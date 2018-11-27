using System;
using System.Linq;

namespace _01._Raindrops
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int regions = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double result = 0.0;
            for (int i = 0; i < regions; i++)
            {
                double[] rainDpops = Console.ReadLine()
                                       .Split()
                                       .Select(double.Parse)
                                       .ToArray();

                double raindropsCount = rainDpops[0];
                double rainSqureMeters = rainDpops[1];

                result += raindropsCount / rainSqureMeters;

            }
            double temp = result / density;

            if (double.IsInfinity(temp))
            {
                Console.WriteLine($"{result:f3}");
            }
            else
            {
                Console.WriteLine($"{temp:f3}");
            }
        }
    }
}

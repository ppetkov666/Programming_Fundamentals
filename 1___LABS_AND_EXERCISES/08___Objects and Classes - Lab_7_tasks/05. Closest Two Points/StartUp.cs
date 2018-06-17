namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public class Points
        {
            public double x { get; set; }
            public double y { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Points>();
            for (int i = 0; i < n; i++)
            {
                var currentpoint = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                points.Add(new Points
                { x = currentpoint[0],
                  y = currentpoint[1]
                });
            }
            var minDistance = double.MaxValue;
            Points firstpointmin = null;
            Points secondpointmin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int y = i + 1; y < points.Count; y++)
                {
                    var firstP = points[i];
                    var secondP = points[y];
                    var currentDistance = Distance(firstP, secondP);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstpointmin = firstP;
                        secondpointmin = secondP;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstpointmin.x},{firstpointmin.y})");
            Console.WriteLine($"({secondpointmin.x},{secondpointmin.y})");
        }
        public static double Distance(Points first, Points second)
        {
            var sideA = first.x - second.x;
            var sideB = first.y - second.y;
            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return sideC;
        }
    }
}

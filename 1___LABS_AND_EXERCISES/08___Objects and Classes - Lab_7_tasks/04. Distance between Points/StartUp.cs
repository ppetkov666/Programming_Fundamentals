namespace _04.Distance_between_Points
{
    using System;
    using System.Linq;
    class StartUp
    {       
        static void Main(string[] args)
        {
            var firstPoint = Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondPoint = Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .ToArray();
            var first = new Points();
            first.x = firstPoint[0];
            first.y = firstPoint[1];

            var second = new Points();
            second.x = secondPoint[0];
            second.y = secondPoint[1];

            var result = Distance( first,second);
            Console.WriteLine($"{result:f3}");
        }   
        public static double Distance(Points first,Points second)
        {
            var sideA = first.x - second.x;
            var sideB = first.y - second.y;
            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return sideC;
        }
    }
}

namespace _08.Center_Point
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            var firstpoint = FirstPointDistanceToTheCenter(x1, y1, 0, 0);
            var secondpoint = SecondPointDistanceToTheCenter(x2, y2, 0, 0);
            if (firstpoint <= secondpoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double SecondPointDistanceToTheCenter(double x1, double y1,double x2,double y2)
        {
            var distance = CalculateDIstance(x1, y1, x2, y2);
                return distance;
        }
        static double FirstPointDistanceToTheCenter(double x1, double y1,double x2, double y2)
        {
            var distance = CalculateDIstance(x1, y1, x2, y2);
            return distance;
        }
        private static double CalculateDIstance(double x1, double y1, double x2, double y2)
        {
            var formula = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return formula;
        }
    }
}

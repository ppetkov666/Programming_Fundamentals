namespace _09.Longer_Line
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            var firstlinelength = CalculateDIstance(x1, y1, x2, y2);
            var secondlinelength = CalculateDIstance(x3, y3, x4, y4);
            if (firstlinelength > secondlinelength)
            {
                var firstpoint = FirstPointDistanceToTheCenter(x1, y1, 0, 0);
                var secondpoint = SecondPointDistanceToTheCenter(x2, y2, 0, 0);
                if (firstpoint <= secondpoint)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }  
            }
            else
            {
                var firstpoint = FirstPointDistanceToTheCenter(x3, y3, 0, 0);
                var secondpoint = SecondPointDistanceToTheCenter(x4, y4, 0, 0);
                if (firstpoint <= secondpoint)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        private static double SecondPointDistanceToTheCenter(double x1, double y1, double x2, double y2)
        {
            var distance = CalculateDIstance(x1, y1, x2, y2);
            return distance;
        }
        private static double FirstPointDistanceToTheCenter(double x1, double y1, double x2, double y2)
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
        

 

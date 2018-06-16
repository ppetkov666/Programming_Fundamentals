namespace _03.Circles_Intersection
{
    using System;
    using System.Linq;
    class StartUp
    {
        class Point
        {
            public double X { get; set; }
            public double Y  { get; set; }
        }
        class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }
        static void Main()
        {
           
            var firstPoint = GetPoint();
            var secondPoint = GetPoint();
            bool intersect = CalculatedDistance(firstPoint,secondPoint) 
                <= firstPoint.Radius+secondPoint.Radius;
            Console.WriteLine(intersect ? "Yes":"No");
        }

        private static double CalculatedDistance(Circle pointA,Circle pointB)
        {
            var firstD = pointA.Center.X - pointB.Center.X;
            var secondD = pointA.Center.Y - pointB.Center.Y;
            var distance = Math.Sqrt(firstD * firstD + secondD * secondD);
            return distance;
        }
        private static Circle GetPoint()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var circle = new Circle();
            var centerPoint = new Point();
            centerPoint.X = input[0];
            centerPoint.Y = input[1];
            circle.Center = centerPoint;
            circle.Radius = input[2];
            return circle;                
        }
    }
}

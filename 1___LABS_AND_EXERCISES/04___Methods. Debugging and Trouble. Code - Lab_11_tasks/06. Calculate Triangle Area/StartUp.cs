namespace _06._Calculate_Triangle_Area
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var trianglearea = GetTriangleArea(a, b);
            Console.WriteLine(trianglearea);
        }
        static double GetTriangleArea(double width, double height)
        {
            var area = (width * height) / 2;
            return area;
        }
    }
}

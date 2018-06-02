namespace _02._Rectangle_Area
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double longtitude = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double result = longtitude * width;

            Console.WriteLine($"{result:f2}");
        }
    }
}

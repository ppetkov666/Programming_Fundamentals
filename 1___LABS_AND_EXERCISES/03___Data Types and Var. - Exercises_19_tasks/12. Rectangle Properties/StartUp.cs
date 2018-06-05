namespace _12._Rectangle_Properties
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double sidea = double.Parse(Console.ReadLine());
            double sideb = double.Parse(Console.ReadLine());

            double perimeter = 2 * sidea + 2 * sideb;
            double area = sidea * sideb;
            double diagonal = Math.Sqrt(Math.Pow(sidea, 2) + Math.Pow(sideb, 2));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}

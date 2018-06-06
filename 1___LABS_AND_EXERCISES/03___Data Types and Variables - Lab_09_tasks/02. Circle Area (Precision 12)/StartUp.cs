namespace _02._Circle_Area__Precision_12_
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double result = r * r * pi;
            Console.WriteLine(Math.Round(result, 12));
        }
    }
}

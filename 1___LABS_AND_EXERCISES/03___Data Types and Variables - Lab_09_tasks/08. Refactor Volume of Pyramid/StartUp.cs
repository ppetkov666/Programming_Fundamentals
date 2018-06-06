namespace _08._Refactor_Volume_of_Pyramid
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Length: ");
            double longtitude = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double hightitude = double.Parse(Console.ReadLine());
            double V = (longtitude * width * hightitude) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}

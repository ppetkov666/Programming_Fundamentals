namespace _03._Miles_to_Kilometers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double kms = miles * 1.60934;
            Console.WriteLine($"{kms:f2}");
        }
    }
}

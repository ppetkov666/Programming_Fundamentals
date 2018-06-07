namespace _07._Math_Power
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            double result = GetNumberToPower(number, power);
            Console.WriteLine(result);
        }
        static double GetNumberToPower(double number, int power)
        {
            double result = 1.0;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}

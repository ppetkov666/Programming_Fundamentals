namespace _05._Temperature_Conversion
{
    using System;
    class StartUp
    {
        static void Main()
        {

            double celsius = GetTempInCelsius();
            Console.WriteLine($"{celsius:f2}");
        }

        static double GetTempInCelsius()
        {
            double tempInFahrenheit = double.Parse(Console.ReadLine());
            var celsius = (tempInFahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}

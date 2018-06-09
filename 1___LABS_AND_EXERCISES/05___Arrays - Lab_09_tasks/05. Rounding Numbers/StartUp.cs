namespace _05._Rounding_Numbers
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputsplit = input.Split(' ');
            double[] array = new double[inputsplit.Length];
            for (int i = 0; i < inputsplit.Length; i++)
            {
                array[i] = double.Parse(inputsplit[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                var result = System.Math.Round(array[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {result}");
            }
        }
    }
}

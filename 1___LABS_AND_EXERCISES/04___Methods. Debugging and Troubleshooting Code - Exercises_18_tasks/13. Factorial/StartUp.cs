namespace _13.Factorial
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintFactoriel(number);
        }
        private static void PrintFactoriel(int number)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}

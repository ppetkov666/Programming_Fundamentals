namespace _14.Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var factorial = GetFactoriel(number);
            TakingTrailingZeros(factorial);
            Console.WriteLine(TakingTrailingZeros(factorial));
        }
        private static int  TakingTrailingZeros(BigInteger factorial)
        {
            var sum = 0;
            while (factorial % 10 == 0)
            {
                sum++;
                factorial = factorial / 10;
            }
            return sum;
        }

        private static BigInteger GetFactoriel(int number)
        {
            BigInteger factoriel = 1;
            int sum = 0;        
            for (int i = 1; i <= number; i++)
            {
                factoriel *= i; 
            }
            return factoriel;
        }
    }
}

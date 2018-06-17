namespace _03.Big_Factorial
{
    using System;
    using System.Numerics;

    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}

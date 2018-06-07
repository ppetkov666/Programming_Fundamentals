namespace _07.Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int numfirst = int.Parse(Console.ReadLine());
            int numsecond = int.Parse(Console.ReadLine());
            var primes = GetPrimeNumsInRange(numfirst, numsecond);
            Console.WriteLine(string.Join(", ",primes));
        }
        static List<int> GetPrimeNumsInRange(int numfirst, int numsecond)
        {
            List<int> prime = new List<int>();
            
            for (int number = numfirst; number <=numsecond ; number++)
            {
                bool primeNum = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        primeNum = false;
                        break;
                    }
                }
                if (primeNum && number > 1)
                {
                    prime.Add(number);
                }
            }
            return prime;
        }
    }
}

namespace _06.Prime_Checker
{
    using System;
    class StartUp
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            bool prime = GetPrime(number);
            Console.WriteLine(prime);
        }

        static bool GetPrime(long number)
        {
            var isprime = true;
            if (number <= 1)
            {
                isprime = false;
            }
            else if (number == 2)
            {
                isprime =  true;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isprime =  false;
                    break;
                }
            }

            return isprime;
        }
    }
}

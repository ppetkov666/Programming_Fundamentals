namespace _04.Sieve_of_Eratosthenes
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            primes[0] = primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 0; i < primes.Length ; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                    var p = i;
                    var multyplier = 2;
                    while (p <= n)
                    {
                        primes[p] = false;
                        p = i * multyplier;
                        multyplier++;
                    }
                }
                
            }
        }
    }
}

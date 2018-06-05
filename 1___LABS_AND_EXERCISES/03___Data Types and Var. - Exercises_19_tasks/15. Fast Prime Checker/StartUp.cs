namespace _15._Fast_Prime_Checker
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 2; num <= n; num++)
            {
                bool isprime = true;
                for (int range = 2; range <= Math.Sqrt(num); range++)
                {
                    if (num % range == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isprime}");
            }
        }
    }
}

namespace _03._Last_K_Numbers_Sums
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                for (int a = i - k; a <= i - 1; a++)
                {
                    if (a >= 0)
                    {
                        sequence[i] += sequence[a];
                    }
                }
            }
            for (long i = 0; i < sequence.Length; i++)
            {
                Console.Write($"{sequence[i]} ");
            }
            Console.WriteLine();
        }
    }
}

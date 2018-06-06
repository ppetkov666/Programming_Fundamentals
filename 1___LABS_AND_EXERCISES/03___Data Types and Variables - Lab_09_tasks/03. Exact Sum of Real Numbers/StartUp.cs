namespace _03._Exact_Sum_of_Real_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}

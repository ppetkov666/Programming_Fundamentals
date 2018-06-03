namespace _08._Sum_of_Odd_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(counter);
                sum += counter;
                counter += 2;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}

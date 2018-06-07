namespace _05.Fibonacci_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var fibonachi = GetFibonachi(number);
            Console.WriteLine(fibonachi);
        }

        private static int GetFibonachi(int number)
        {
            var sum = 0;
            var x = 1;
            var y = 1;
            for (int i = 1; i < number; i++)
            {
                sum = x + y;
                x = y;
                y = sum;
            }
            return y;
        }
    }
}

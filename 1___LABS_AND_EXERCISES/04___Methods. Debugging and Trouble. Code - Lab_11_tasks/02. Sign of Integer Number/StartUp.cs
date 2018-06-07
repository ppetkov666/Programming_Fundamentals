namespace _02._Sign_of_Integer_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {

            PrintSign(int.Parse(Console.ReadLine()));
        }
        private static void PrintSign(int num)
        {
            var sample = $"The number {num}";
            if (num > 0)
            {
                Console.WriteLine($"{sample} is positive.");
            }
            if (num < 0)
            {
                Console.WriteLine($"{sample} is negative.");
            }
            if (num == 0)
            {
                Console.WriteLine($"{sample} is zero.");
            }
        }
    }
}

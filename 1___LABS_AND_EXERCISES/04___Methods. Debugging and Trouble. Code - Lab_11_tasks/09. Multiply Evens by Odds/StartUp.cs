namespace _09._Multiply_Evens_by_Odds
{
    using System;
    class StartUp
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            PrintProductOfEvenAndOddNumbers(input);
        }
        private static void PrintProductOfEvenAndOddNumbers(int input)
        {
            var odd = GetSumOfOddDigits(input);
            var even = GetSumOfEvenDigits(input);
            var result = even * odd;
            Console.WriteLine(result);
        }
        static int GetSumOfOddDigits(int input)
        {
            var num = Math.Abs(input);
            var sumodd = 0;
            while (num > 0)
            {
                var lastdigit = num % 10;
                if (lastdigit % 2 != 0)
                {
                    sumodd += lastdigit;
                }
                num = num / 10;
            }
            return sumodd;
        }
        static int GetSumOfEvenDigits(int input)
        {
            var num = Math.Abs(input);
            var sumeven = 0;
            while (num > 0)
            {
                var lastdigit = num % 10;
                if (lastdigit % 2 == 0)
                {
                    sumeven += lastdigit;
                }
                num = num / 10;
            }
            return sumeven;
        }
    }
}

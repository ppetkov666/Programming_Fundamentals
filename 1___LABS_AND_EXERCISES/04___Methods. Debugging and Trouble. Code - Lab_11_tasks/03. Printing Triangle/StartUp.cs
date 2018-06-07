namespace _03._Printing_Triangle
{
    using System;
    class StartUp
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            PrintTriangleOfDigits(inputNumber);
        }

        private static void PrintTriangleOfDigits(int number)
        {
            PrintUpperPartOFtriangle(number);
            PrintBottomPartOFtriangle(number);

        }

        private static void PrintUpperPartOFtriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintDigitsLine(i);
            }
        }
        private static void PrintBottomPartOFtriangle(int number)
        {
            for (int i = 1; i <= number - 1; i++)
            {
                PrintDigitsLine(number - i);
            }
        }
        private static void PrintDigitsLine(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

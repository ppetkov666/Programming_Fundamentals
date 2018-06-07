namespace _04._Draw_a_Filled_Square
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            DrawFilledSquare(number);
        }

        private static void DrawFilledSquare(int number)
        {
            DrawTopandBottom(number * 2);
            DrawMiddleRaws(number);
            DrawTopandBottom(number * 2);
        }

        private static void DrawMiddleRaws(int num)
        {
            for (int i = 0; i < num - 2; i++)
            {
                DrawTheLine(num);
            }
        }
        private static void DrawTheLine(int num)
        {
            Console.Write('-');
            for (int y = 0; y < num - 1; y++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
        private static void DrawTopandBottom(int num)
        {
            var format = new string('-', num);
            Console.WriteLine(format);
        }
    }
}

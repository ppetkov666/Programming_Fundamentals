namespace _09.Extract_Middle_Elements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (inputArr.Length == 1) PrintFirstElement(inputArr);
           
            else if (inputArr.Length % 2 == 0) PrintEvenElement(inputArr);
           
            else if (inputArr.Length % 2 != 0) PrintOddElement(inputArr);
                 
        }
        static void PrintOddElement(int[] inputArr)
        {
            var formula = inputArr.Length / 2 - 1;
            Console.Write("{ ");
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    Console.Write($"{inputArr[formula]}");
                }
                else
                {
                    Console.Write($"{inputArr[formula]}, ");
                }
                formula += 1;
            }
            Console.Write(" }");
            Console.WriteLine();
        }

        static void PrintEvenElement(int[] inputArr)
        {
            var formula = inputArr.Length / 2 - 1;
            Console.Write("{ ");
            for (int i = 0; i < 2; i++)
            {
                if (i==1)
                {
                    Console.Write($"{inputArr[formula]}");
                }
                else
                { 
                    Console.Write($"{inputArr[formula]}, ");
                }
                formula += 1;
            }
            Console.Write(" }");
            Console.WriteLine();
        }

        static void PrintFirstElement(int[] inputArr)
        {
            var length = inputArr.Length;
            if (length == 1)
            {
                Console.Write("{ "+ inputArr[0] + " }");          
            }
            Console.WriteLine();
        }
    }
}

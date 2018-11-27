
namespace _02._Rainer
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = input.Last();
            int[] initialInput = input.Take(input.Length - 1).ToArray();
            int count = 0;
            while (true)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j]--;
                }
                if (input[startIndex] == 0)
                {
                    Console.WriteLine(string.Join(" ", input.Take(input.Length - 1)));
                    Console.WriteLine(count);
                    break;
                }
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == 0)
                    {
                        input[i] = initialInput[i];
                    }
                }
                int curentIndex = int.Parse(Console.ReadLine());
                startIndex = curentIndex;
                count++;
            }
        }
    }
}

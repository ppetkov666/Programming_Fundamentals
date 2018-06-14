namespace _06.Fold_and_Sum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = input.Length / 4;
            var firstRowLeft = input.Take(k).Reverse();
            var firstRowRight = input.Reverse().Take(k);
            var firstFullRow = firstRowLeft.Concat(firstRowRight).ToArray();          
            var secondRow = input.Skip(k).Take(k * 2).ToArray();          
            var output = new int[secondRow.Length];

            for (int i = 0; i < secondRow.Length; i++)
            {
                output[i] = firstFullRow[i] + secondRow[i];
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

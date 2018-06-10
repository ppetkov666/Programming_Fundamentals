namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = inputArr.Length / 4;

            var firstrow = new int[k * 2];
            var secondRow = new int[k * 2];
            var sum = new int[firstrow.Length];
            for (int i = 0; i < k; i++)
            {
                firstrow[i] = inputArr[k - i - 1];
                firstrow[k + i] = inputArr[inputArr.Length - 1 - i];
                secondRow[i] = inputArr[k + i];
                secondRow[k+i] = inputArr[inputArr.Length - (k*2) + i];
            }
            for (int i = 0; i < firstrow.Length; i++)
            {
                sum[i] = firstrow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}

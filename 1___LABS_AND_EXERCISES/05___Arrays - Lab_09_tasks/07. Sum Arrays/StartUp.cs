namespace _07._Sum_Arrays
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var maxArr = Math.Max(firstArr.Length, secondArr.Length);
            var sumArr = new int[maxArr];
            for (int i = 0; i < maxArr; i++)
            {
                sumArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}

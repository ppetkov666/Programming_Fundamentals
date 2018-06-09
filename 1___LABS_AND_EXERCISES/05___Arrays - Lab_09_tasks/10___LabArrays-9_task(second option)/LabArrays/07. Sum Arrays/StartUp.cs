namespace _07.Sum_Arrays
{
    using System;
    using System.Linq;
  
    class StartUp
    {
        static void Main()
        {
            var firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = Math.Max(firstArr.Length, secondArr.Length);
            var resultArray = new int[max];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]} ");
            }
            Console.WriteLine();

        }
    }
}

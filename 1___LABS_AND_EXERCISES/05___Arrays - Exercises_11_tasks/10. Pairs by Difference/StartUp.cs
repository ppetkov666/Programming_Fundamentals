namespace _10.Pairs_by_Difference
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numdiff = int.Parse(Console.ReadLine());
            var count = 0;
            var difference = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int a = 0; a < nums.Length; a++)
                {
                     difference = nums[i] - nums[a];
                    if (difference==numdiff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

namespace _11.Equal_Sums
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var leftsum = 0;
            var rightsum = 0;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    leftsum += nums[a];
                }
                for (int b = i + 1; b < nums.Length; b++)
                {
                    rightsum += nums[b]; 
                }
                if (leftsum==rightsum)
                {
                    count++;
                    Console.WriteLine(i);
                }
                leftsum = 0;
                rightsum = 0;
            }
            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}

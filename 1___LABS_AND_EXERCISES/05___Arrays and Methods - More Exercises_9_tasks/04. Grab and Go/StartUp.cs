namespace _04.Grab_and_Go
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());
            long match = 0;
            long sum = 0;
            var matched = false;
            for (long i = 0; i < num.Length; i++)
            {
                if (n == num[i])
                {
                    match = i;
                    matched = true;
                }
            }
            for (long i = 0; i < match; i++)
            {
                sum += num[i];
            }
            if(matched)
            {
                Console.WriteLine(sum);
            }
            else 
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}

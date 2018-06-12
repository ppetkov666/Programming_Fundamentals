namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            var list = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                var sum = input[i] + input[i - 1];
                if (input[i] == input[i - 1])
                {
                    input[i] = sum;
                    input.RemoveAt(i - 1);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}

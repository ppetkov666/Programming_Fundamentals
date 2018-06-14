namespace _04.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split().Select(double.Parse)
                .ToArray();
            var output = input
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

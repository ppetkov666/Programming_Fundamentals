namespace _04.Palindromes
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
                .Split(new char[] { ',', '?', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var outputlist = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i].ToCharArray();
                Array.Reverse(current);
                string reversed = new string(current);
                if (input[i] == reversed)
                {
                    outputlist.Add(reversed);
                }
            }
            Console.WriteLine(string.Join(", ", outputlist.OrderBy(p => p).Distinct()));
        }
    }
}

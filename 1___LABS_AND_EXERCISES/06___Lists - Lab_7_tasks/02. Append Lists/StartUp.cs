namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var reversed = new string[input.Length];
            for (int i = 0; i < input.Length ; i++)
            {
                reversed[i] = input[input.Length - 1 - i];
            }
            var list = new List<string>();
            for (int i = 0; i < reversed.Length; i++)
            {
                var token = reversed[i];
                var output = token
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0; a < output.Length; a++)
                {
                    list.Add(output[a]);
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}

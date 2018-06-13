namespace _06.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();     
            var output = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var token = input[i];
                var length = token.Length - 1;
                var reversed = "";
                while (length >=0)
                {
                    reversed += token[length];
                    length--;
                }
                output.Add(int.Parse(reversed));
            }
            var result = 0;
            for (int i = 0; i < output.Count; i++)
            {
                result += output[i];
            }
            Console.WriteLine(result);
        }
    }
}

namespace _04.Character_Multiplier
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var first = input[0];
            var second = input[1];

            Console.WriteLine(GetSumCharacters(first,second));   
        }

        private static int GetSumCharacters(string first,string second)
        {
            var min = Math.Min(first.Length, second.Length);
            var sum = 0;
            for (int i = 0; i < min; i++)
            {
                sum += first[i] * second[i];

            }
            var restofthestring = string.Empty;
            if (first.Length > second.Length)
            {
                restofthestring = first.Substring(min);
            }
            else
            {
                restofthestring = second.Substring(min);
            }
            for (int i = 0; i < restofthestring.Length; i++)
            {
                sum += restofthestring[i];
            }
            return sum;
        }
    }
}

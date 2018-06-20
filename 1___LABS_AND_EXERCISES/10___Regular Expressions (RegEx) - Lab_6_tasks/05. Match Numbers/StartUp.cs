namespace _05.Match_Numbers
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var input = Console.ReadLine();
            var matchedNumbers = Regex.Matches(input, pattern);
            foreach (var item in matchedNumbers)
            {
                Console.Write(item + " " );
            }
            Console.WriteLine();
        }
    }
}

namespace _03.Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b(0x){0,1}[0-9A-F]+\b";
            var matched = Regex.Matches(input, pattern);
            var matchedNumbers = matched
                .Cast<Match>()
                .Select(p => p.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ",matchedNumbers));
        }
    }
}

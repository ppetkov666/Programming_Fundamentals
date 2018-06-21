namespace _03.Camera_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            var indices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var mskip = indices[0];
            var ntake = indices[1];
            var pattern = $"\\|<(.{{0,{mskip}}})(.{{0,{ntake}}})";
            var input = Console.ReadLine();
            var outputResult = new List<string>();
            var matched = Regex.Match(input, pattern);                      
            while ( matched.Success)
            {
                var finalmatch = matched
                    .Groups[2].Value;
                if (finalmatch.Contains("|"))
                {
                    finalmatch = finalmatch.Substring(0, finalmatch.IndexOf("|"));
                }               
                outputResult.Add(finalmatch);
                input = input.Substring(matched.Index+2);
                matched = Regex.Match(input, pattern);               
            }
            Console.WriteLine(string.Join(", ",outputResult));
        }
    }
}

namespace _06.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine()
                .Split(" /\\()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();
            var pattern = @"^[A-Za-z][A-Za-z0-9_]{2,24}$";
            var outputlsit = new List<string>();
            for (int i = 0; i < username.Length; i++)
            {
                var matched = Regex.Match(username[i], pattern);
                if (matched.Success)
                {
                    outputlsit.Add(matched.ToString());
                }
            }
            var maximumLength = 0;
            var index = 0;
            var result = 0;
            for (int i = 0; i < outputlsit.Count-1; i++)
            {
                result = outputlsit[i].Length + outputlsit[i + 1].Length;
                if (result > maximumLength)
                {
                    maximumLength = result;
                    index = i;
                }
            }
            Console.WriteLine(outputlsit[index]);
            Console.WriteLine(outputlsit[index + 1]);
        }
    }
}

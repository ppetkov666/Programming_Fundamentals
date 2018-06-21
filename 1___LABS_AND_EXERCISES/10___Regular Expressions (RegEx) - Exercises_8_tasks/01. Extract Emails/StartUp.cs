namespace _01.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string emailPattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";

            var matches = Regex.Matches(input, emailPattern);
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}

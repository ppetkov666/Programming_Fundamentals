namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var matched = pattern.Matches(input);
            foreach (Match item in matched)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

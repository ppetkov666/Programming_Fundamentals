namespace _06.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
                string replacingString = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replacingString);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}

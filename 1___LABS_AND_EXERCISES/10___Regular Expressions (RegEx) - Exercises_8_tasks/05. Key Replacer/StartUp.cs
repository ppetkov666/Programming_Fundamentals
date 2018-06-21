namespace _05.Key_Replacer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            var keystring = Console.ReadLine();
            var startkey = @"^[A-Za-z]+[|<\\]";
            var endkey = @"[|<\\][A-Za-z]+$";
            var startmatched = Regex.Match(keystring, startkey);
            var endmatched = Regex.Match(keystring, endkey);
            var modifiedStartMatched = startmatched.Value.TrimEnd('<', '|', '\\');
            var modifiedEndMatched = endmatched.Value.TrimStart('<', '|', '\\');

            var inputtext = Console.ReadLine();
            var pattern = $"{modifiedStartMatched}(.*?){modifiedEndMatched}";
            var sb = new StringBuilder();
            var matched = Regex.Matches(inputtext, pattern);
            foreach (Match item in matched)
            {
                sb.Append(item.Groups[1].Value);
            }
            Console.WriteLine(sb.ToString().Length == 0 ? "Empty result": sb.ToString());
            
        }
    }
}

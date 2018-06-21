namespace _08.Use_Your_Chains__Buddy
{
    using System;
    using System.Text.RegularExpressions;
    using System.IO;

    class StartUp
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string html = Console.ReadLine();
            string pattern = @"<p>(.[^\/]+)<\/p>";
            string regex = @"[^a-z0-9]+";
            Regex words = new Regex(pattern);
            MatchCollection matches = words.Matches(html);
            string encrypt = "";

            for (int i = 0; i < matches.Count; i++)
            {
                string temp = matches[i].Groups[1].Value;
                encrypt += Regex.Replace(temp, regex, word => " ");
            }

            string m = "";
            for (int i = 0; i < encrypt.Length; i++)
            {
                if (encrypt[i] >= 'a' && encrypt[i] <= 'm')
                {
                    m += (char)(encrypt[i] + 13);

                }
                else if (encrypt[i] >= 'n' && encrypt[i] <= 'z')
                {
                    m += (char)(encrypt[i] - 13);
                }
                else if (Char.IsDigit(encrypt[i]) || Char.IsWhiteSpace(encrypt[i]))
                {
                    m += encrypt[i];
                }
            }

            Console.WriteLine(m);
        }
    }
}

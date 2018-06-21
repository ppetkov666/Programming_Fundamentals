namespace _02.Extract_Sentences_by_Keyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(".!?".ToCharArray()).ToArray();
            var pattern = new Regex((@"\b") + word + (@"\b"));

            for (int i = 0; i < sentences.Length; i++)
            {
                if (pattern.IsMatch(sentences[i]))
                {
                    Console.WriteLine(sentences[i].Trim());
                }
            }  
        }
    }
}

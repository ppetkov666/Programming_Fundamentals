namespace _03.Text_Filter
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var forbiddenWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var text = Console.ReadLine();
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                var currentword = forbiddenWords[i];
                if (text.Contains(currentword))
                {
                    text = text.Replace(currentword, new string('*', currentword.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}

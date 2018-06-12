namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var arrayInput = Console.ReadLine()
                .Split(new char[] {',',';',':','.','!','(',')','"','\'','\\','/','[',']',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var lowercase = new List<string>();
            var mixedcase = new List<string>();
            var uppercase = new List<string>();
            for (int i = 0; i < arrayInput.Length; i++)
            {
                var input = arrayInput[i];
                var tokens = GetWordType(input);
                if (tokens == WordType.Uppercase)
                {
                    uppercase.Add(input);
                }
                else if (tokens == WordType.Lowercase)
                {
                    lowercase.Add(input);
                }
                else
                {
                    mixedcase.Add(input);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowercase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercase)}");
        }
        enum WordType { Uppercase, Lowercase, Mixedcase }
        static WordType GetWordType(string token)
        {
            var countUpper = 0;
            var countLower = 0;
            for (int a = 0; a < token.Length; a++)
            {
                if (char.IsUpper(token[a]))
                {
                    countUpper++;
                }
                else if (char.IsLower(token[a]))
                {
                    countLower++;
                }
            }
            if (countLower == token.Length)
            {
               return WordType.Lowercase;
            }
            else if (countUpper == token.Length)
            {
                return WordType.Uppercase;
            }
            else
            {
                return WordType.Mixedcase;
            }
            
        }
    }
}

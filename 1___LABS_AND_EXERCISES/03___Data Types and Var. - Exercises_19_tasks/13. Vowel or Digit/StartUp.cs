namespace _13._Vowel_or_Digit
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            string vowels = "aeiou";
            if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else if (vowels.Contains(symbol))
            {
                Console.WriteLine("vowel");
            }
            else Console.WriteLine("other");
        }
    }
}

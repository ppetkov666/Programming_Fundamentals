﻿namespace _05._Word_in_Plural
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string word = Console.ReadLine();
            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                word.EndsWith("s") ||
                word.EndsWith("ch") ||
                word.EndsWith("sh") ||
                word.EndsWith("x") ||
                word.EndsWith("z"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}

﻿namespace _14._Magic_Letter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char a = first; a <= second; a++)
            {
                for (char b = first; b <= second; b++)
                {
                    for (char c = first; c <= second; c++)
                    {
                        if (a != third && b != third && c != third)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
        }
    }
}

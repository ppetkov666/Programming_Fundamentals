namespace _06._Triples_of_Letters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i <= 'a' + n - 1; i++)
            {
                for (char a = 'a'; a <= 'a' + n - 1; a++)
                {
                    for (char b = 'a'; b <= 'a' + n - 1; b++)
                    {
                        Console.WriteLine($"{i}{a}{b}");
                    }
                }
            }
        }
    }
}

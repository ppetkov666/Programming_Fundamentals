namespace _01.Hello__Name_
{
    using System;
    class StartUp
    {
        static void Main()
        {
            var name = Console.ReadLine();
            PrintName(name);
        }
        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

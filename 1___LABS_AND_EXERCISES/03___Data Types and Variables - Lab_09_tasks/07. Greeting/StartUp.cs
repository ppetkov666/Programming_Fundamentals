namespace _07._Greeting
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, " + first + " " + second + "." + " You are " + n + " years old.");
        }
    }
}

namespace _09._Reversed_chars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char firstletter = char.Parse(Console.ReadLine());
            char secondletter = char.Parse(Console.ReadLine());
            char thirdletter = char.Parse(Console.ReadLine());
            Console.WriteLine($"{thirdletter}{secondletter}{firstletter}");

        }
    }
}

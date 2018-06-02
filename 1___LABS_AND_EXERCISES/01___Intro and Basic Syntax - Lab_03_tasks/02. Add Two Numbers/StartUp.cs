using System;

namespace _02._Add_Two_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numFirst = int.Parse(Console.ReadLine());
            var numSecond = int.Parse(Console.ReadLine());
            var result = numFirst + numSecond;
            Console.WriteLine($"{numFirst} + {numSecond} = {result}");
        }
    }
}

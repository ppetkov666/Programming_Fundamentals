namespace _03.Unicode_Characters
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputstring = Console.ReadLine();
            var result = inputstring
                .Select(t => $"\\u{Convert.ToUInt16(t):x4}")
                .ToList();
            Console.WriteLine(string.Join("",result));
        }
    }
}

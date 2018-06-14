namespace _05.Short_Words_Sorted
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var separator = new char[] { '.',',',':',';','(',')','[',']','"','\'','/','\\','!','?',' '};
            var input = Console.ReadLine()
                .Split(separator,StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var output = input
                .Where(n => n.Length < 5)
                .Select(n=> n.ToLower())
                .OrderBy(n => n)
                .Distinct()
                .ToArray();
            Console.WriteLine(string.Join(", ",output));     
        }
    }
}

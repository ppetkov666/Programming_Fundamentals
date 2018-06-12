namespace _07.Count_Numbers
{
    using System;
    using System.Linq;  
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arrayinput = new int[input.Max() + 1];
            for (int i = 0; i < input.Length; i++)
            {
                arrayinput[input[i]] += 1; 
            }
            for (int i = 0; i < arrayinput.Length; i++)
            {
                if (arrayinput[i] != 0)
                {
                    Console.WriteLine($"{i} -> {arrayinput[i]}");
                }
            }
        }
    }
}

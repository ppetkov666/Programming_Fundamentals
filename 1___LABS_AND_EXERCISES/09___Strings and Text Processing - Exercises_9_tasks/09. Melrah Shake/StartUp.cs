namespace _09.Melrah_Shake
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                var firstmatch = input.IndexOf(pattern);
                var secondmatch = input.LastIndexOf(pattern);
                if (firstmatch > -1 && secondmatch > -1 & pattern.Length > 0)
                {
                    input = input.Remove(firstmatch, pattern.Length);
                    secondmatch = input.LastIndexOf(pattern);
                    input = input.Remove(secondmatch, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0 )
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                        
                    }
                    else
                    {
                        Console.WriteLine(input);
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}

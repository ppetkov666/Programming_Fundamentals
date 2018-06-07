namespace _15.Substring
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int step = int.Parse(Console.ReadLine());

            const char searchedLetter = 'p';
            var match = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == searchedLetter)
                {
                    match = true;
                    var legth = step + 1;
                    if (i+legth > text.Length - 1)
                    {
                        legth = text.Length - i;
                    }
                    var finalstring = text.Substring(i, legth);
                    Console.WriteLine(finalstring);
                    i += step;
                }
                
            }
            if (!match)
            {
                Console.WriteLine("no");
            }
        }
    }
}

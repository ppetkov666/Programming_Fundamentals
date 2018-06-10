namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] firstArrChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArrChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorter = Math.Max(firstArrChars.Length, secondArrChars.Length);
            char[] firstForPrinting = firstArrChars;
            char[] secondForPrinting = secondArrChars;
            for (int i = 0; i < shorter; i++)
            {
                if (firstArrChars[i] < secondArrChars[i])
                {
                    break;
                }
                else if (firstArrChars[i] > secondArrChars[i])
                {
                    firstForPrinting = secondArrChars;
                    secondForPrinting = firstArrChars;
                    break;
                }
                else
                {
                    if (firstArrChars.Length <=secondArrChars.Length)
                    {
                        break;
                    }
                    else
                    {
                        firstForPrinting = secondArrChars;
                        secondForPrinting = firstArrChars;
                        break;
                    }
                }



            }
            Console.WriteLine(new string(firstForPrinting));
            Console.WriteLine(new string(secondForPrinting));


        }
    }
}

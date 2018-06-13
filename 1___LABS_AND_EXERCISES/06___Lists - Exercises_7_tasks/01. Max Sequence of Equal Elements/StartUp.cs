namespace _01.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var startposition = 0;
            var longestsequence = 1;           
            var count = 1;
            var start = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    count++;
                    if (count > longestsequence )
                    {
                        longestsequence = count;
                        start = startposition;
                    }                 
                }
                else
                {
                    count = 1;
                    startposition = i + 1;
                }
            }
            for (int i = start; i < start + longestsequence; i++)
            {
                if (i == start + startposition - 1)
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var longestSeq = LongestSequence(sequence);
            Console.WriteLine("{0}", string.Join(" ", longestSeq));
        }
        public static List<int> LongestSequence(int[] sequence)
        {
            var length = new int[sequence.Length];
            var previous = new int[sequence.Length];
            var maxlength = 0;
            var lastindex = -1;
            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                previous[i] = -1;
                 
                for (int a = 0; a < i; a++)
                {
                    if (sequence[a] < sequence[i] && length[a] >= length[i] )
                    {
                        length[i] = length[a] + 1;
                        previous[i] = a;
                    }
                }
                if (length[i] > maxlength)
                {
                    maxlength = length[i];
                    lastindex = i;
                }
            }
            var listoutput = new List<int>();
            for (int i = 0; i < maxlength; i++)
            {
                listoutput.Add(sequence[lastindex]);
                lastindex = previous[lastindex];
            }
            listoutput.Reverse();
            return listoutput;
        }
    }
}

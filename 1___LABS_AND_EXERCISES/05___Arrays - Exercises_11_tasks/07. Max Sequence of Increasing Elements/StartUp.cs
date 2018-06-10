namespace _07.Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var numSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 1;
            var beggIncreasingSeq = 0;
            var matchcounter = 0;           
            for (int i = 1; i < numSeq.Length; i++)
            {
                if (numSeq[i] > numSeq[i - 1])
                {
                    counter += 1;
                    if (counter > matchcounter)
                    {
                        matchcounter = counter;
                        beggIncreasingSeq = i - matchcounter + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = beggIncreasingSeq; i < beggIncreasingSeq + matchcounter; i++)
            {
                Console.Write(numSeq[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

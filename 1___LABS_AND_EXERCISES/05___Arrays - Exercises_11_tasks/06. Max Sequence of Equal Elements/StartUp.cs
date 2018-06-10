namespace _06.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var numSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var beggEqualSeq = 0;
            var matchcounter = 0;
            var index = 0;
            for (int i = 1; i < numSeq.Length; i++)
            {
                if (numSeq[i] == numSeq[index])
                {
                    counter += 1;
                    if (counter > matchcounter)
                    {
                        matchcounter = counter;
                        beggEqualSeq = index;
                    }
                }
                else
                {
                    counter = 1;
                    index = i;
                }
            }
            for (int i = beggEqualSeq; i < beggEqualSeq + matchcounter; i++)
            {
                Console.Write(numSeq[beggEqualSeq] + " ");
            }
            Console.WriteLine();
        }
    }
}

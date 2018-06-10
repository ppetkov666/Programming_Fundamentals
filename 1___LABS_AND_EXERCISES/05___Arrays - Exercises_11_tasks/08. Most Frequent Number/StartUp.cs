namespace _08.Most_Frequent_Number
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var storednums = new ushort[65536];
            for (int i = 0; i < sequence.Length; i++)
            {
                storednums[sequence[i]] += 1;
            }
            var maxvalue = 0;
            for (int i = 0; i < storednums.Length; i++)
            {
                if (storednums[i]>maxvalue)
                {             
                    maxvalue = storednums[i];
                }
            }
            for (int i = 0; i <sequence.Length ; i++)
            {
                if (storednums[sequence[i]] == maxvalue)
                {
                    Console.Write(sequence[i]);
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}

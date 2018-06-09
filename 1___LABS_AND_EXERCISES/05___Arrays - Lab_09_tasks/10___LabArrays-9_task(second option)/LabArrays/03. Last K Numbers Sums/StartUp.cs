namespace _03.Last_K_Numbers_Sums
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int lengthofSequence = int.Parse(Console.ReadLine());
            int maxlengthofSeq = int.Parse(Console.ReadLine());

            var sequence = new long[lengthofSequence];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                for (int a = i-maxlengthofSeq; a <= i-1 ; a++)
                {
                    if (a>=0)
                    {
                        sequence[i] += sequence[a];
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ",sequence));
           
        }
    }
}

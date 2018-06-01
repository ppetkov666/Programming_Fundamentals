namespace _1.MostFrequentNumber
{
    using System;
    using System.Linq; 
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputinitial = File.ReadAllLines("../../input.txt");                            
            File.Delete("../../output.txt");

            for (int i = 0; i < inputinitial.Length; i++)
            {
                var input = inputinitial[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                var counter = new int[65536];
                for (int a = 0; a < input.Length; a++)
                {
                    counter[input[a]] += 1;
                }
                var maxSeq = counter.Max();
                for (int b = 0; b < input.Length; b++)
                {
                    if (counter[input[b]] == maxSeq)
                    {
                        File.AppendAllText("../../output.txt", input[b].ToString());
                        File.AppendAllText("../../output.txt", Environment.NewLine);
                        break;
                    }
                }
            }

           
        }
    }
}


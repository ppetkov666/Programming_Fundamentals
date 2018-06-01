namespace _4.MaxSequenceofEqualElements
{
    using System;
    using System.Linq;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] initialinput = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (int a = 0; a < initialinput.Length; a++)
            {
                var input = initialinput[a]
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int counter = 1;
                int maxsequence = 1;
                int startindex = 0;
                for (int i = 1; i < input.Length; i++)
                {
                    int currentnumber = input[i];
                    if (currentnumber == input[i - 1])
                    {
                        counter += 1;
                        if (counter > maxsequence)
                        {
                            maxsequence = counter;
                            startindex = input[i];
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                for (int i = 0; i < maxsequence; i++)
                {
                    File.AppendAllText("../../output.txt", startindex + " ");
                }
                File.AppendAllText("../../output.txt",Environment.NewLine);
            }

        }
    }
}

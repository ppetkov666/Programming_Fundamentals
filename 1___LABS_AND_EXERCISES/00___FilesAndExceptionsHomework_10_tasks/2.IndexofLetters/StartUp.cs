namespace _2.IndexofLetters
{
    using System;
    using System.Linq;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("../../input.txt").ToArray();           
            File.Delete("../../output.txt");         
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\r' || input[i] == '\n')
                {
                    continue;
                }
                File.AppendAllText("../../output.txt", string.Join(" -> ", input[i],input[i] - 'a'));
                File.AppendAllText("../../output.txt", Environment.NewLine);
            }        
        }
    }
}

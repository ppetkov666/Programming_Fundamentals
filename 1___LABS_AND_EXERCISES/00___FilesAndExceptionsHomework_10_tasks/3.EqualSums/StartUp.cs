namespace _3.EqualSums
{
    using System;
    using System.Linq;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] inputfromfile = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (int i = 0; i < inputfromfile.Length; i++)
            {
                var input = inputfromfile[i]
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

                var outputpath = "../../output.txt";
                bool notequal = true;
                int j = 0;
                for ( j = 0; j < input.Length; j++)
                {
                    int leftsum = 0;
                    int rightsum = 0;
                    for (int a = 0; a < j; a++)
                    {
                        leftsum += input[a];
                    }
                    for (int b = input.Length-1; b > j; b--)
                    {
                        rightsum += input[b];
                    }
                    if (leftsum == rightsum)
                    {
                        notequal = false;
                        File.AppendAllText(outputpath, j.ToString());
                        File.AppendAllText(outputpath, Environment.NewLine);
                        break;
                    }
                    
                }
                if (notequal && j != 0)
                {
                    File.AppendAllText(outputpath, "no");
                    File.AppendAllText(outputpath, Environment.NewLine);
                }

                else if (notequal && j == 0)
                {
                    File.AppendAllText(outputpath, "0");
                    File.AppendAllText(outputpath, Environment.NewLine);
                }

            }
           

        }
    }
}

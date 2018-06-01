namespace _6.FixEmails
{
    using System;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            var row = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (int i = 0; i < row.Length; i+=2)
            {
                if (row[i] == "stop" || row[1 + 1] == "stop")
                {
                    break;
                }
                var name = row[i];
                var email = row[i + 1];
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    continue;
                }
                var output = $"{name} -> {email}" + Environment.NewLine;
                File.AppendAllText("../../output.txt", output);
            }
        }
    }
}

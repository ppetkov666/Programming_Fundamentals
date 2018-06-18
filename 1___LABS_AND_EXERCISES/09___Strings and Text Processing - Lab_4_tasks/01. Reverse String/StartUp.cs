namespace _01.Reverse_String
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charinput = input.ToCharArray();
            var reversedstring = new char[charinput.Length];
            for (int i = 0; i < charinput.Length; i++)
            {
                reversedstring[i] = charinput[charinput.Length - 1 - i];
            }
            var outputstring = new string(reversedstring);
            Console.WriteLine(outputstring);
        }
    }
}

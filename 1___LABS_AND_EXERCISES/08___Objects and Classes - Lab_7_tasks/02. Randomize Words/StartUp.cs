namespace _02.Randomize_Words
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var randomWords = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                var firstWord = randomWords.Next(0, input.Length);
                var secondWord = randomWords.Next(0, input.Length);


                var next = input[firstWord];
                input[firstWord] = input[secondWord];
                input[secondWord] = next;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}

namespace _05.Magic_exchangeable_words
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split();
            var wordOne = inputArr[0].Distinct().ToArray();
            var wordTwo = inputArr[1].Distinct().ToArray();
            if (wordOne.Length == wordTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


        }
    }
}

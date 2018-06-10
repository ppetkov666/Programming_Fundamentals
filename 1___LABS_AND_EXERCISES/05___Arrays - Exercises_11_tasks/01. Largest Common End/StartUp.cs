namespace _01.Largest_Common_End
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var secondArr = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var countfromLefttoRight = 0;
            var countfromRightToLeft = 0;
            var shorterArr = Math.Min(firstArr.Length, secondArr.Length);
            var longerArr = Math.Max(firstArr.Length, secondArr.Length);
            for (int i = 0; i < shorterArr; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    countfromLefttoRight += 1;
                }
                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    countfromRightToLeft += 1;
                }
            }
            if (countfromLefttoRight > countfromRightToLeft)
            {
                Console.WriteLine(countfromLefttoRight);
            }
            else
            {
                Console.WriteLine(countfromRightToLeft);
            }
        }
    }
}

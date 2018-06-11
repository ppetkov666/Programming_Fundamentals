namespace _09.Jump_Around
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var initialArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var currentIndex = 0;
            var nextStep = initialArr[0];
            var sum = initialArr[0];
            while (true)
            {
                if (currentIndex + nextStep < initialArr.Length)
                {
                    currentIndex += nextStep;
                }
                else if (currentIndex -nextStep >= 0)
                {
                    currentIndex -= nextStep;
                }
                else
                {
                    break;
                }
                sum += initialArr[currentIndex];
                nextStep = initialArr[currentIndex];
            }
            Console.WriteLine(sum);
        }
    }
}

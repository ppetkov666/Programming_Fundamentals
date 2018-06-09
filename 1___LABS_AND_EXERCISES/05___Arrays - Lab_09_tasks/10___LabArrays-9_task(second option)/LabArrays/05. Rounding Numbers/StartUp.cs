namespace _05.Rounding_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var numbersArr = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < numbersArr.Length; i++)
            {
                var formatedresult = System.Math.Round(numbersArr[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbersArr[i]} => {formatedresult}");
            }
        }
    }
}

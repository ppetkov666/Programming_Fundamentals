namespace _08.Letters_Change_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine()
                .Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                char firstLetter = char.Parse(inputArr[i].Substring(0, 1));
                decimal middleNumber = decimal.Parse(inputArr[i].Substring(1, inputArr[i].Length - 2));
                var lastLetter = char.Parse(inputArr[i].Substring(inputArr[i].Length - 1));
                
                //calsulation with the first Letter
                if (char.IsUpper(firstLetter))
                {
                    int tolowerCalculatedPosition = firstLetter - 64;
                    middleNumber /= tolowerCalculatedPosition; 
                }
                else if (char.IsLower(firstLetter))
                {
                    int tolowerCalculatedPosition = firstLetter - 96;
                    middleNumber *= tolowerCalculatedPosition;
                }
                // calculation with the last Letter 
                if (char.IsUpper(lastLetter))
                {
                    int tolowerCalculatedPosition = lastLetter - 64;
                    middleNumber -= tolowerCalculatedPosition;
                }
                else if (char.IsLower(lastLetter))
                {
                    int tolowerCalculatedPosition = lastLetter - 96;
                    middleNumber += tolowerCalculatedPosition;
                }
                sum += middleNumber;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}

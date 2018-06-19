namespace _06.Sum_big_numbers
{
    using System;
    using System.Text;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var firstnum = Console.ReadLine();
            var secondnum = Console.ReadLine();
            if (firstnum.Length > secondnum.Length)
            {
                secondnum = secondnum.PadLeft(firstnum.Length,'0');
            }
            else
            {
                firstnum = firstnum.PadLeft(secondnum.Length,'0');
            }
            StringBuilder sum = new StringBuilder();
            var number = 0;
            var restOfTheNum = 0;
            var sumlast = 0;

            for (int i = 0; i < firstnum.Length; i++)
            {
                number = (firstnum[firstnum.Length - 1 - i] - 48)
                        + (secondnum[secondnum.Length - 1 - i] - 48)
                        + restOfTheNum;
                sumlast = number % 10;
                sum.Append(sumlast);
                restOfTheNum = number / 10;
                if (i == firstnum.Length - 1 && restOfTheNum > 0)
                {
                    sum.Append(restOfTheNum);
                }
            }
            var finaloutput = new string(sum
                .ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray());
            Console.WriteLine(finaloutput);
        }
    }
}

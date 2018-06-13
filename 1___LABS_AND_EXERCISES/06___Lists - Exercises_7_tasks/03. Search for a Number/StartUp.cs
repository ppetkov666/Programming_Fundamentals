namespace _03.Search_for_a_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var output = new List<int>();

            var count = 0;
            var positivecounter = 0;

            var numberOfElements = arrNum[0];
            var numberOfElementsToDelete = arrNum[1];
            var searchedNumber = arrNum[2];


            for (int i = 0; i < numberOfElements; i++)
            {
                output.Add(input[i]);
            }

            for (int i = 0; i < numberOfElementsToDelete; i++)
            {
                if (count == numberOfElementsToDelete)
                {
                    break;
                }
                else
                {
                    count += 1;
                    output.RemoveAt(i);
                    i -= 1;
                }
            }
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i] == searchedNumber)
                {
                    positivecounter += 1;
                    break;
                }
            }
            if (positivecounter > 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

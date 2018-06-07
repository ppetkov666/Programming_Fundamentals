namespace _17.Be_Positive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                bool found = false;

                for (int j = 0; j < input.Length; j++)
                {
                    int currentNum = input[j];

                    if (currentNum >= 0)
                    {
                        if (j ==input.Length-1)
                        {
                            Console.Write($"{currentNum}");
                        }
                        else
                        {
                            Console.Write($"{currentNum} ");
                        }
                        found = true;
                    }
                    else if (j + 1 <= input.Length-1)
                    {
                        currentNum += input[j + 1];
                        if (currentNum >= 0)
                        {
                            if (j == input.Length - 1)
                            {
                                Console.Write($"{currentNum}");
                            }
                            else
                            {
                                Console.Write($"{currentNum} ");
                            }
                            found = true;
                        }
                        j+=1;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

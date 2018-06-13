namespace _02.Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "Even" && command != "Odd")
            {
                DeleteOrInsertNumbers(inputList, command);
                command = Console.ReadLine();
            }
            if (command=="Even")
            {
                PrintEvenNumbers(inputList);
            }
            else if (command=="Odd")
            {
                PrintOddNumbers(inputList);
            }
        }
        private static void PrintOddNumbers(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0 )
                {
                    if (i == inputList[inputList.Count - 1])
                    {
                        Console.Write(inputList[i]);
                    }
                    else
                    {
                        Console.Write(inputList[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
        private static void PrintEvenNumbers(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    if (i == inputList[inputList.Count-1])
                    {
                        Console.Write(inputList[i]);
                    }
                    else
                    {
                        Console.Write(inputList[i] + " ");
                    }  
                }
            }
            Console.WriteLine();
        }

        private static void DeleteOrInsertNumbers(List<int> inputList,string command)
        {
            var tokens = command.Split().ToArray();
            var action = tokens[0];
           
            if (action == "Delete")
            {
                var element = int.Parse(tokens[1]);
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i]==element)
                    {
                        inputList.RemoveAt(i);
                        i -= 1;
                    }
                }
            }
            else if (action == "Insert")
            {
                var element = int.Parse(tokens[1]);
                var position = int.Parse(tokens[2]);
                inputList.Insert(position, element);
            }

        }
    }
}

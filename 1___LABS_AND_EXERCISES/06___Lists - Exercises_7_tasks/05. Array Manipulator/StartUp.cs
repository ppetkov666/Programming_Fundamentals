namespace _05.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputNUM = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "print")
            {
                DoingArrayManipulations(inputNUM, command);
                command = Console.ReadLine();
            }
            if (command == "print")
            {
                PrintTheOutput(inputNUM);
            }

        }
        private static void PrintTheOutput(List<int> inputNUM)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", inputNUM));
            Console.Write("]");
            Console.WriteLine();
        }

        private static void DoingArrayManipulations(List<int> inputNUM, string command)
        {
            var tokens = command.Split().ToArray();
            var action = tokens[0];
            if (action == "add")
            {
                var index = int.Parse(tokens[1]);
                var element = int.Parse(tokens[2]);
                inputNUM.Insert(index, element);

            }
            else if (action == "addMany")
            {
                var index = int.Parse(tokens[1]);
                var listofelements = new List<int>();
                for (int i = 2; i < tokens.Length; i++)
                {
                    listofelements.Add(int.Parse(tokens[i]));
                }
                inputNUM.InsertRange(index, listofelements);
            }
            else if (action == "contains")
            {
                var element = int.Parse(tokens[1]);
                if (inputNUM.Contains(element))
                {
                    Console.WriteLine(inputNUM.IndexOf(element));
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            else if (action == "remove")
            {
                var index = int.Parse(tokens[1]);
                inputNUM.RemoveAt(index);
            }
            else if (action == "shift")
            {
                var position = int.Parse(tokens[1]);
                var count = position % inputNUM.Count;
                for (int i = 0; i < count; i++)
                {
                    inputNUM.Add(inputNUM[0]);
                    inputNUM.RemoveAt(0);
                }
            }
            else if (action == "sumPairs")
            {
                for (int i = 0; i < inputNUM.Count - 1; i++)
                {
                    inputNUM[i] = inputNUM[i] + inputNUM[i + 1];
                    inputNUM.RemoveAt(i + 1);
                }

            }
        }
    }
}

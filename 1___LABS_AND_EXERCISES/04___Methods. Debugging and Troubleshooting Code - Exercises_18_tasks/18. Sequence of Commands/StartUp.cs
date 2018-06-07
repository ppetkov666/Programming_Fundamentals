namespace _18.Sequence_of_Commands
{
    using System;
    using System.Linq;
    public class StartUp
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            var command = Console.ReadLine()
                .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (!command[0].Equals("stop"))
            {
                if (command[0].Equals("add") || command[0].Equals("multiply") || command[0].Equals("subtract"))
                {
                    var firsParameter = int.Parse(command[1]);
                    var secondParameter = int.Parse(command[2]);
                    PerformAction(array, command, firsParameter, secondParameter);
                }
                else if(command[0].Equals("rshift") || command[0].Equals("lshift"))
                {
                    PerformAnotherAction(array, command);
                }
                PrintArray(array);
                command = Console.ReadLine()
                    .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        private static void PerformAnotherAction(long[] array, string[] command)
        {
            switch (command[0])
            {
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        static void PerformAction(long[] array, string[] command, int first, int second)
        {
            
            int position = first-1;
            int value = second;

            switch (command[0])
            {
                case "multiply":
                    array[position] *= value;
                    break;
                case "add":
                    array[position] += value;
                    break;
                case "subtract":
                    array[position] -= value;
                    break;
               
            }
        }
        private static void ArrayShiftRight(long[] array)
        {
            var lastelement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastelement;
        }
        private static void ArrayShiftLeft(long[] array)
        {
            var firstelement = array[0];
            for (int i = 0; i < array.Length - 1 ; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstelement;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

}

namespace _06.Reverse_Array_of_Strings
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var chararray = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                chararray[i] = input[input.Length - 1 - i];
            }
            for (int i = 0; i < chararray.Length; i++)
            {
                Console.Write($"{chararray[i]} ");
            }
            Console.WriteLine();
        }
    }
}

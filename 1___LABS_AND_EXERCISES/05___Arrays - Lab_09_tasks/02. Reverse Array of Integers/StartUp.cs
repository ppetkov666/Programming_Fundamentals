namespace _02._Reverse_Array_of_Integers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[arrayOfNumbers.Length - 1 - i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

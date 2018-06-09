namespace _02.Reverse_Array_of_Integers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayNumbers[arrayNumbers.Length - 1 - i] = number;
            }
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write($"{arrayNumbers[i]} ");
            }
            Console.WriteLine();
            
        }
    }
}

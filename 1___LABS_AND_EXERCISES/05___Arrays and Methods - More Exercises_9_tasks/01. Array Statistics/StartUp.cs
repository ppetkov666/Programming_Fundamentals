namespace _01_Array_Statistics
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var min = 0;
            var max = 0;
            double sum = 0;
            min = array.Min();
            max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}


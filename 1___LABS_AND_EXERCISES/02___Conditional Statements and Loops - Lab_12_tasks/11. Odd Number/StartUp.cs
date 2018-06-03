namespace _11._Odd_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            while (true)
            {
                int number = Math.Abs(int.Parse(Console.ReadLine()));
                if (number % 2 != 0)
                {
                    Console.WriteLine("The number is: " + number);
                    break;
                }
                Console.WriteLine("Please write an odd number.");
            }
        }
    }
}

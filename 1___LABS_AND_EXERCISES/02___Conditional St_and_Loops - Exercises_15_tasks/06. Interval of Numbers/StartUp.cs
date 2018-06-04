namespace _06._Interval_of_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                for (int i = number2; i <= number1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (number2 > number1)
            {
                for (int i = number1; i <= number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

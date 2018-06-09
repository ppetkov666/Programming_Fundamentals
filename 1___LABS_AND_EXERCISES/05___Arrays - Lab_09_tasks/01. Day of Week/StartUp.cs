namespace _01._Day_of_Week
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string[] daysofweek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (inputNumber <= 0 || inputNumber > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysofweek[inputNumber - 1]);
            }
        }
    }
}

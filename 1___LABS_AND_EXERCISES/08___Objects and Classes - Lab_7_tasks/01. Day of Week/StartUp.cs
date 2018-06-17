namespace _01.Day_of_Week
{
    using System;
    using System.Globalization;

    class StartUp
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            DateTime outputDate = DateTime
                .ParseExact(date,"d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(outputDate.DayOfWeek);
        }
    }
}

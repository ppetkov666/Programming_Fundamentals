namespace _10._Centuries_to_Nanoseconds
{
    using System;
    class StartUp
    {
        static void Main()
        {
            decimal centuries = decimal.Parse(Console.ReadLine());

            decimal years = centuries * 100;
            decimal days = Math.Floor(years * 365.2422M);
            decimal hours = (decimal)(days) * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = " +
                              $"{years} years = " +
                              $"{days} days = " +
                              $"{hours} hours = " +
                              $"{minutes} minutes = " +
                              $"{seconds} seconds = " +
                              $"{miliseconds} milliseconds = " +
                              $"{microseconds} microseconds = " +
                              $"{nanoseconds} nanoseconds");
        }
    }
}

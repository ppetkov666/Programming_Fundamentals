namespace _01.Count_Working_Days
{
    using System;
    using System.Globalization;
    class StartUp
    {
        static void Main()
        {
            var firstinput = Console.ReadLine();
            var secondinput = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(firstinput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime enddate = DateTime.ParseExact(secondinput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var counterofWorkingDays = 0;

            DateTime[] holidays = new DateTime[11];
            holidays[0] = DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[1] = DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[2] = DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[3] = DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[4] = DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[5] = DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[6] = DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[7] = DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[8] = DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[9] = DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[10] = DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            for (DateTime currentDate = startDate; currentDate <= enddate; currentDate = currentDate.AddDays(1))
            {

                if (currentDate.DayOfWeek != DayOfWeek.Saturday
                    && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isholiday = false;
                    foreach (var item in holidays)
                    {
                        if (item.Day == currentDate.Day &&
                            item.Month == currentDate.Month)
                        {
                            isholiday = true;
                            break;
                        }                
                    }
                    if (!isholiday)
                    {
                        counterofWorkingDays++;
                    }
                }
            }
            Console.WriteLine(counterofWorkingDays);    
        }
    }
}

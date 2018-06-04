namespace _04._Hotel
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCounter = int.Parse(Console.ReadLine());
            double studioPrice = 0.00;
            double doublePrice = 0.00;
            double suitPrice = 0.00;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitPrice = 75;
                if (nightsCounter > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {

                studioPrice = 60;
                doublePrice = 72;
                suitPrice = 82;
                if (nightsCounter > 14)
                {
                    doublePrice -= doublePrice * 0.10;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitPrice = 89;
                if (nightsCounter > 14)
                {
                    suitPrice -= suitPrice * 0.15;
                }
            }
            double result = studioPrice * nightsCounter;
            double result1 = doublePrice * nightsCounter;
            double result2 = suitPrice * nightsCounter;
            if (month == "September" || month == "October")
            {
                if (nightsCounter > 7)
                {
                    result = studioPrice * (nightsCounter - 1);
                }

            }
            Console.WriteLine($"Studio: {result:F2} lv.");
            Console.WriteLine($"Double: {result1:F2} lv.");
            Console.WriteLine($"Suite: {result2:F2} lv.");
        }
    }
}

namespace _06._Theatre_Promotion
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");

            }
            else if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122) ticketPrice = 12;
                if (age > 18 && age <= 64) ticketPrice = 18;
            }
            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122) ticketPrice = 15;
                if (age > 18 && age <= 64) ticketPrice = 20;
            }
            else if (typeOfDay == "Holiday")
            {
                if (age >= 0 && age <= 18) ticketPrice = 5;
                if (age > 18 && age <= 64) ticketPrice = 12;
                if (age > 64 && age <= 122) ticketPrice = 10;
            }
            if (ticketPrice != 0)
            {
                Console.WriteLine(ticketPrice + "$");
            }
        }
    }
}

namespace _03._Back_in_30_Minutes
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = hours - 24;
            }
            if (minutes <= 9)
            {
                Console.WriteLine(hours + ":" + "0" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
        }
    }
}

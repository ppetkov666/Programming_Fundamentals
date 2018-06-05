namespace _11._Convert_Speed_Units
{
    using System;
    class StartUp
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());

            float hoursToSeconds = hours * 3600;
            float minutesToSeconds = minutes * 60;
            float sumSeconds = hoursToSeconds + minutesToSeconds + second;
            
            float sumHours = sumSeconds / 3600;
            float metersToKms = distance / 1000;
            float metersToMiles = distance / 1609;

            float metersPerSecond = distance / sumSeconds;
            float kmPerHour = metersToKms / sumHours;
            float milesPerHour = metersToMiles / sumHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}

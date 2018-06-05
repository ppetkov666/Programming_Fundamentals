namespace _08._Employee_Data
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personalId = long.Parse(Console.ReadLine());
            int uen = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstname}" +
                              $"\nLast name: {lastname}" +
                              $"\n Age: {age}\nGender: {gender}" +
                              $"\nPersonal ID: {personalId}" +
                              $"\nUnique Employee number: {uen}");
        }
    }
}

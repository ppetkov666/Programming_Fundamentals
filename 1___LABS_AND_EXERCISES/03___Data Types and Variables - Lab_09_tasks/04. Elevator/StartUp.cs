namespace _04._Elevator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = numOfPeople / capacity;
            if (numOfPeople % capacity != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}

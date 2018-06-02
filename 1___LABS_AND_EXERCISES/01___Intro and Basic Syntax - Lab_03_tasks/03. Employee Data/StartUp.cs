using System;

namespace _03._Employee_Data
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = long.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            var formatedID = id.ToString().PadLeft(8, '0');
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {formatedID}");
            Console.WriteLine($"Salary: {salary:f2}");


        }
    }
}

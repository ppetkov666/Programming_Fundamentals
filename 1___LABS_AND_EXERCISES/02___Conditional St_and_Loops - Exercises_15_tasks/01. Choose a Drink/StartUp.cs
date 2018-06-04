namespace _01._Choose_a_Drink
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string occupation = Console.ReadLine();
            if (occupation == "Athlete") Console.WriteLine("Water");
            else if (occupation == "Businessman" || occupation == "Businesswoman") Console.WriteLine("Coffee");
            else if (occupation == "SoftUni Student") Console.WriteLine("Beer");
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}

namespace _02._Choose_a_Drink_2._0
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string occupation = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            if (occupation == "Athlete")
            {
                price = 0.70;
            }
            else if (occupation == "Businessman" || occupation == "Businesswoman")
            {
                price = 1.00;
            }
            else if (occupation == "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }
            double sum = price * quantity;
            Console.WriteLine($"The {occupation} has to pay {sum:f2}.");
        }
    }
}

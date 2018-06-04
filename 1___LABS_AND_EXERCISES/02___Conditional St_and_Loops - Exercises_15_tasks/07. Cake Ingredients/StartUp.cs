namespace _07._Cake_Ingredients
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string ingridients = Console.ReadLine();
            int counter = 0;
            while (ingridients != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingridients}.");
                ingridients = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}

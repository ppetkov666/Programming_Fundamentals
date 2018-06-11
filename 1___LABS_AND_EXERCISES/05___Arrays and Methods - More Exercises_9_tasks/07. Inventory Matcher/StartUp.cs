namespace _07.Inventory_Matcher
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var command = Console.ReadLine();
            while (command != "done")
            {
                var element = Array.IndexOf(products, command);
                Console.WriteLine($"{products[element]} costs: {prices[element]}; Available quantity: {quantity[element]}");
                command = Console.ReadLine();
            }
        }
    }
}

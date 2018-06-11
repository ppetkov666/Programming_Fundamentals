namespace _08.Upgraded_Matcher
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var command = Console.ReadLine();
            while (command != "done")
            {
                var orderARR = command.Split().ToArray();
                var product = orderARR[0];
                long orderquantity = long.Parse(orderARR[1]);

                var element = Array.IndexOf(products, product);

                if (element >= quantity.Length)
                {
                    Array.Resize(ref quantity, quantity.Length + element);
                }
                if (orderquantity <= quantity[element])
                {
                    quantity[element] -= orderquantity;
                    var total = prices[element] * orderquantity;
                    Console.WriteLine($"{products[element]} x {orderquantity} costs {total:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[element]}");
                }
                command = Console.ReadLine();
            }
        }
    }
}

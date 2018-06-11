namespace _05.Pizza_Ingredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var pizzaINGR = Console.ReadLine().Split(' ').ToArray();
            var limitN = int.Parse(Console.ReadLine());
            var count = 0;
            var ingridients = new List<string>();
            for (int i = 0; i < pizzaINGR.Length; i++)
            {
                var pizzalenhth = pizzaINGR[i].Length;
                if (pizzalenhth == limitN)
                {
                    
                    if (count < 10)
                    {
                        
                        Console.WriteLine($"Adding {pizzaINGR[i]}.");
                        ingridients.Add(pizzaINGR[i]);
                        count++;

                    }
                    else
                    {

                        break;
                    }
                    
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",ingridients)}.");
        }
    }
}

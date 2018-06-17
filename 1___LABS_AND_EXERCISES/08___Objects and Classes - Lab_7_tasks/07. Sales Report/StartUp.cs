namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());
                var salesList = new List<Sale>();
                for (int i = 0; i < n; i++)
                {
                    var currentinput = Console.ReadLine()
                        .Split(' ')
                        .ToArray();
                    var currentsale = new Sale();
                    currentsale.Town = currentinput[0];
                    currentsale.Product = currentinput[1];
                    currentsale.Price = decimal.Parse(currentinput[2]);
                    currentsale.Quantity = decimal.Parse(currentinput[3]);
                    salesList.Add(currentsale);
                }
                var resultDict = new SortedDictionary<string, decimal>();
                foreach (var item in salesList)
                {
                    if (!resultDict.ContainsKey(item.Town))
                    {
                        resultDict[item.Town] = 0;
                    }
                    resultDict[item.Town] += item.Price * item.Quantity; 
                }
                foreach (var item in resultDict)
                {        
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }
            }
        }
    }
}

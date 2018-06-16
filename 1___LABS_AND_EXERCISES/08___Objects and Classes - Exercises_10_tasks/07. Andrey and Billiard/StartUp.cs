namespace _07.Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopingList { get; set; }
        public double Bill { get; set; }
    }
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var menu = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray(); 
                if (!menu.ContainsKey(input[0]))
                {
                    menu.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    menu[input[0]] = double.Parse(input[1]);
                }
            }
            var fullListOfCustomers = new List<Customer>();
            while (true)
            {
                var inputcustomer = Console.ReadLine();
                if (inputcustomer == "end of clients")
                {
                    break;
                }
                var customerInfo = inputcustomer
                    .Split('-',',' )
                    .ToArray();
                var name = customerInfo[0];
                var product = customerInfo[1];
                var quantity = double.Parse(customerInfo[2]);
                if (!menu.ContainsKey(product))
                {
                    continue;
                }
                Customer customer = new Customer();
                customer.Name = name;
                customer.ShopingList = new Dictionary<string, double>();
                customer.ShopingList.Add(product, quantity);
                if (fullListOfCustomers.Any(p => p.Name == name))
                {
                    Customer existingCustomer = fullListOfCustomers
                         .First(p => p.Name == name);
                    if (existingCustomer.ShopingList.ContainsKey(product))
                    {
                        existingCustomer.ShopingList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopingList[product] = quantity;
                    }
                }
                else
                {
                    fullListOfCustomers.Add(customer);
                }
            }
            // Loop for calcualating fullListOfCustomers.Bill
            
            foreach (var item in fullListOfCustomers)
            {   
                foreach (var itemsShopList in item.ShopingList)
                {                 
                    foreach (var menuItems in menu)
                    {
                        if (itemsShopList.Key == menuItems.Key)
                        {
                            item.Bill += itemsShopList.Value * menuItems.Value;                           
                        }
                    } 
                }              
            }
            var orderedList = fullListOfCustomers
                    .OrderBy(x => x.Name)
                    .ThenBy(x => x.ShopingList)
                    .ToList();
            // Printing The Final Output
            foreach (var item in orderedList)
            {
                Console.WriteLine(item.Name);
                foreach (KeyValuePair<string,double> items in item.ShopingList)
                {
                    Console.WriteLine($"-- {items.Key} - {items.Value}");          
                }
                Console.WriteLine("Bill: {0:f2}", item.Bill);
            }
            Console.WriteLine("Total bill: {0:f2}",orderedList.Sum(x=>x.Bill));
        }
    }
}

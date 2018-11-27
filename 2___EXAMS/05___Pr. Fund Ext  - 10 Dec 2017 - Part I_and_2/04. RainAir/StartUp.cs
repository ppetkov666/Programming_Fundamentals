using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._RainAir
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<long>> flightInfo = new Dictionary<string, List<long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "I believe I can fly!")
                {
                    break;
                }
                if (input.Contains("="))
                {
                    string[] names = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = names[0];
                    string secondName = names[1];
                    flightInfo[firstName] = new List<long>();
                    foreach (var flights in flightInfo[secondName])
                    {
                        flightInfo[firstName].Add(flights);
                    }
                }
                else
                {
                    string[] customerInfo = input.Split();
                    string customerName = customerInfo[0];
                    // this is the first option but i will demonstrate second option to add it into a list
                    //List<string> customerFligths = customerInfo.Skip(1).ToList();
                    // second option is with simple for loop
                    List<string> customerFligths = new List<string>();
                    for (int i = 1; i < customerInfo.Length; i++)
                    {
                        customerFligths.Add(customerInfo[i]);
                    }

                    if (!flightInfo.ContainsKey(customerName))
                    {
                        flightInfo.Add(customerName, new List<long>());
                    }
                    //flightInfo[customerName].AddRange(customerFligths);
                    for (int i = 0; i < customerFligths.Count; i++)
                    {
                        flightInfo[customerName].Add(int.Parse(customerFligths[i]));
                    }
                }
            }
            flightInfo = flightInfo
                .OrderByDescending(d => d.Value.Count())
                .ThenBy(d => d.Key)
                .ToDictionary(d => d.Key, d => d.Value);
           
            foreach (var planes in flightInfo)
            {
                //the ordering could happend here or directly when we print the result
                //var orderList = planes.Value.OrderBy(d => d);
                Console.WriteLine($"#{planes.Key} ::: {string.Join(", ", planes.Value.OrderBy(d=>d))}");
            }
        }
    }
}

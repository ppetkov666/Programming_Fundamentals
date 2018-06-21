namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            var cityAndTemp = new Dictionary<string, double>();
            var cityAndWheater = new Dictionary<string, string>();
            var cityandTempSorted = new Dictionary<string, double>();
            var inputstring = Console.ReadLine();
            while (inputstring != "end")
            {
                string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";
                var matched = Regex.Match(inputstring, pattern);
                if (matched.Success)
                {
                    cityAndTemp[matched.Groups[1].Value] = double.Parse(matched.Groups[2].Value);
                    cityAndWheater[matched.Groups[1].Value] = matched.Groups[3].Value;
                }
                inputstring = Console.ReadLine();
            }
            cityandTempSorted = cityAndTemp
                .OrderBy(p => p.Value)
                .ToDictionary(p => p.Key, q => q.Value);
            foreach (var item in cityandTempSorted)
            {
                Console.WriteLine($"{item.Key} => {item.Value:f2} => {cityAndWheater[item.Key]}");
            }
        }
    }
}

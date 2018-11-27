
namespace _03._Raincast
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main(string[] args)
        {
            string typePattern = "^Type: (Normal|Warning|Danger)$";
            string sourcePattern = "^Source: ([A-Za-z0-9]+)$";
            string forecastPattern = "^Forecast: ([^!.,?]+)$";
            List<string> raincastList = new List<string>();
            string storageRainCast = string.Empty;
            string currentValue = "type";
            string input = Console.ReadLine();
            while (input != "Davai Emo")
            {
                if (currentValue == "type")
                {
                    var typematch = Regex.Match(input, typePattern);
                    if (typematch.Success)
                    {
                        storageRainCast += $"({typematch.Groups[1]})";
                        currentValue = "source";
                    }
                }
                else if (currentValue == "source")
                {
                    var sourcematch = Regex.Match(input, sourcePattern);
                    if (sourcematch.Success)
                    {
                        storageRainCast += " " + "empthy" + " ~ " + sourcematch.Groups[1];
                        currentValue = "forecast";

                    }
                }
                else if (currentValue == "forecast")
                {
                    var forecastMatch = Regex.Match(input, forecastPattern);
                    if (forecastMatch.Success)
                    {
                        storageRainCast = storageRainCast.Replace("empthy", forecastMatch.Groups[1].Value);
                        raincastList.Add(storageRainCast);
                        currentValue = "type";
                        storageRainCast = string.Empty;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in raincastList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

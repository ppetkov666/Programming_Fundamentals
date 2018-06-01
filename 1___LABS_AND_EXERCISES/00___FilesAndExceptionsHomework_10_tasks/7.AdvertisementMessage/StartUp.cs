namespace _7.AdvertisementMessage
{
    using System;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phrases = File.ReadAllLines("../../phrases.txt");
                
            string[] events = File.ReadAllLines("../../events.txt");
               
            string[] authors = File.ReadAllLines("../../authors.txt");

            string[] cities = File.ReadAllLines("../../cities.txt");
            File.Delete("../../output.txt");
            Random randomly = new Random(666);
            var inputnumber = File.ReadAllText("../../input.txt");
            int n = int.Parse(inputnumber);
            for (int i = 0; i < n; i++)
            {
                var randomphrases = phrases[randomly.Next(phrases.Length)];
                var randomevents = events[randomly.Next(events.Length)];
                var randomauthors = authors[randomly.Next(authors.Length)];
                var randomcities = cities[randomly.Next(cities.Length)];
                var output = $"{randomphrases} {randomevents} {randomauthors} – {randomcities}.";
                File.AppendAllText("../../output.txt", output);
                File.AppendAllText("../../output.txt", Environment.NewLine);
            }
        }
    }
}

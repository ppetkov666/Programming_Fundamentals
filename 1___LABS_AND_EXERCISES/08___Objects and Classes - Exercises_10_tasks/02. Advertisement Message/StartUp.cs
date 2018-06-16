namespace _02.Advertisement_Message
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";
            string[] events = new string[]
            {"Now I feel good.",
             "I have succeeded with this product.",
             "Makes miracles. I am happy of the results!",
             "I cannot believe but now I feel awesome.",
             "Try it yourself, I am very satisfied.",
             "I feel great!"
            };
            string[] authors = new string[]
            {"Diana",
             "Petya",
             "Stella",
             "Elena",
             "Katya",
             "Iva",
             "Annie",
             "Eva"
            };
            string[] cities = new string[]
            {"Burgas",
             "Sofia",
             "Plovdiv",
             "Varna",
             "Ruse"
            };
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {             
                var phraseIndex = random.Next(0, phrases.Length);
                var eventIndex = random.Next(0, events.Length);
                var authorsIndex = random.Next(0, authors.Length);
                var citiesIndex = random.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorsIndex]} {cities[citiesIndex]}");
            }            
        }
    }
}

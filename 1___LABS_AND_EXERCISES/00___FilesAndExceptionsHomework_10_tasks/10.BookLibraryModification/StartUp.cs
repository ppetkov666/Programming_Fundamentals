namespace _10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.IO;
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    public class StartUp
    {
        public static void Main()
        {
            List<Book> books = GetBooks();

            var inputDate = File.ReadAllText("../../inputDate.txt");

            DateTime targetReleaseDate = DateTime
                .ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            
            string[] titlesRelAfterDate = books
                                            .Where(x => x.ReleaseDate > targetReleaseDate)
                                            .OrderBy(x => x.ReleaseDate)
                                            .ThenBy(x => x.Title)
                                            .Select(x => x.Title).Distinct()
                                            .ToArray();
            
            foreach (string title in titlesRelAfterDate)
            {
                DateTime[] bookRelDate = books
                                            .Where(x => x.Title == title && x.ReleaseDate > targetReleaseDate)
                                            .OrderBy(x => x.ReleaseDate)
                                            .Select(x => x.ReleaseDate)
                                            .Distinct()
                                            .ToArray();
                foreach (DateTime bookReleaseDate in bookRelDate)
                {
                    File.AppendAllText("../../output.txt", $"{title} -> {bookReleaseDate:dd.MM.yyyy}");
                    File.AppendAllText("../../output.txt", Environment.NewLine);
                } 
            }
        }
        private static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            string inputbookcount = File.ReadAllText("../../inputBookCount.txt");
            int n = int.Parse(inputbookcount);
            string[] initialinput = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
           
            for (int i = 0; i < n; i++)
            {
                
                string[] data = initialinput[i]
                                .Split(new char[] { ' ' }, StringSplitOptions
                                .RemoveEmptyEntries);
                books.Add(new Book()
                {
                    Title = data[0],
                    Author = data[1],
                    Publisher = data[2],
                    ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = data[4],
                    Price = decimal.Parse(data[5])
                });
            }
            return books;
        }
    }
}

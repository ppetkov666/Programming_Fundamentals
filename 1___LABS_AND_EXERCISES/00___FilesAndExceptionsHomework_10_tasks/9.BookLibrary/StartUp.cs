using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace _9.BookLibrary
{
    class StartUp
    {
        static void Main()
        {
            string boocountinput = File.ReadAllText("../../input-BookCount.txt");
            int booksCount =int.Parse(boocountinput);
            List<Book> books = new List<Book>();
            string[] inputfile = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (int i = 0; i < booksCount; i++)
            {
                books.Add(ReadBook(inputfile[i]));
            }

            Library library = new Library { Name = "Library", Books = books };

            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (Book book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }
            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText("../../output.txt",$"{pair.Key} -> {pair.Value:f2}");
                File.AppendAllText("../../output.txt",Environment.NewLine);


            }
        }
        static Book ReadBook(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseD = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            return new Book { Title = title
                , Author = author
                , Publisher = publisher
                , releaseD = releaseD
                , ISBN = isbn
                , Price = price };
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime releaseD { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}

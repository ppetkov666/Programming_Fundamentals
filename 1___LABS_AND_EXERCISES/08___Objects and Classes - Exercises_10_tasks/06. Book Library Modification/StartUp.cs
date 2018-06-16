namespace _06.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBNnumber { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            var books = GetBooks();
            var inputreleaseDate = DateTime.ParseExact(Console
                .ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var booksaftercertainDate = books
                .Where(x => x.ReleaseDate > inputreleaseDate)
                .OrderBy(y => y.ReleaseDate)
                .ThenBy(z => z.Title)
                .Distinct()
                .ToArray();
            foreach (var item in booksaftercertainDate)
            {
                Console.WriteLine(item.Title +" -> " + item.ReleaseDate.ToString("dd.MM.yyyy"));
            }
        }
        private static List<Book> GetBooks()
        {
            var n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {

                Library library = new Library();
                Book book = new Book();
                var input = Console.ReadLine().Split(' ').ToArray();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNnumber = long.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                books.Add(book);
            }
            return books;
        }
    }
}

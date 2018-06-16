namespace _05.Book_Library
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
        public long ISBNnumber {get;set;}
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
            var n = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Name = "Library";
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();               
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNnumber = long.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                books.Add(book);           
            }
            Dictionary<string, double> outputDict = new Dictionary<string, double>();
            foreach (var item in books)
            {
                if(outputDict.ContainsKey(item.Author))
                {
                    outputDict[item.Author] += item.Price; 
                }
                else
                {
                    outputDict[item.Author] = item.Price;
                }
            }
            var result = outputDict.OrderByDescending(x => x.Value).ThenBy(y=>y.Key);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}

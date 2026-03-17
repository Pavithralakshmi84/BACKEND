using BookSalesDemo_Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create list of books
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "C# Basics", Author = "John Doe", Price = 500 },
            new Book { BookId = 2, Title = "ASP.NET MVC", Author = "Jane Smith", Price = 700 },
            new Book { BookId = 3, Title = "LINQ in Action", Author = "Mark Lee", Price = 600 }
        };

        // Create list of sales
        List<SaleDetail> sales = new List<SaleDetail>
        {
            new SaleDetail { SaleId = 1, BookId = 1, Quantity = 2, SaleDate = DateTime.Now },
            new SaleDetail { SaleId = 2, BookId = 2, Quantity = 1, SaleDate = DateTime.Now },
            new SaleDetail { SaleId = 3, BookId = 3, Quantity = 3, SaleDate = DateTime.Now },
            new SaleDetail { SaleId = 4, BookId = 1, Quantity = 1, SaleDate = DateTime.Now }
        };

        //2. Join books with sales

        var allBooks = from b in books
                       select b;

        Console.WriteLine("All Books:");
        foreach (var book in allBooks)
        {
            Console.WriteLine($"{book.Title} by {book.Author} - Rs.{book.Price}");
        }

        Console.ReadLine(); // Keeps console open

        var bookSales = from b in books
                        join s in sales on b.BookId equals s.BookId
                        select new
                        {
                            b.Title,
                            s.Quantity,
                            TotalAmount = b.Price * s.Quantity
                        };

        Console.WriteLine("\nBook Sales:");
        foreach (var bs in bookSales)
        {
            Console.WriteLine($"{bs.Title} - Quantity: {bs.Quantity}, Total: Rs.{bs.TotalAmount}");
        }

        //3. Group sales by book

        var groupedSales = from s in sales
                           group s by s.BookId into g
                           select new
                           {
                               BookId = g.Key,
                               TotalQuantity = g.Sum(x => x.Quantity)
                           };

        Console.WriteLine("\nGrouped Sales:");
        foreach (var gs in groupedSales)
        {
            var bookTitle = books.First(b => b.BookId == gs.BookId).Title;
            Console.WriteLine($"{bookTitle} - Total Quantity Sold: {gs.TotalQuantity}");
        }
        //4. Filter expensive books

        var expensiveBooks = books.Where(b => b.Price > 600);

        Console.WriteLine("\nExpensive Books:");
        foreach (var book in expensiveBooks)
        {
            Console.WriteLine($"{book.Title} - Rs.{book.Price}");
        }



    }
}

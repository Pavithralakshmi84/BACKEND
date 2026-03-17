using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesDemo_Linq
{
    public class Book
    {

        public int BookId { get; set; }     // Unique ID for each book
        public string Title { get; set; }   // Book title
        public string Author { get; set; }  // Author name
        public decimal Price { get; set; }  // Price of the book
    }
}

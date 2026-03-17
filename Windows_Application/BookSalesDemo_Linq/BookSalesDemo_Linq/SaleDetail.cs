using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesDemo_Linq
{
    public class SaleDetail
    {

        public int SaleId { get; set; }     // Unique ID for each sale
        public int BookId { get; set; }     // Which book was sold (linked to BookId)
        public int Quantity { get; set; }   // How many copies sold
        public DateTime SaleDate { get; set; } // When the sale happened
    }
}

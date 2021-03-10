using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    /**
     * This is the Cart class
     * There is a CartLine class within the Cart class that contains a CartlineID, a Book object, and a quantity
     * The Cart class contains a list of Cartline objects (all the book objects and their quantities)
     * There is a AddItem method to add a Cartline (book) to the list of Cartlines
     * There is a RemoveItem method that removes a book object from the list of Cartlines
     * There is a Clear method that clears out the entire Cartline list
     * There is a ComputeTotalSum method that that calculates the total price of everything in the list of Cartlines
     */
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book bo, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == bo.BookId)
                .FirstOrDefault();

            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bo,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;  
            }
        }

        public virtual void RemoveItem(Book bo)
        {
            Lines.RemoveAll(x => x.Book.BookId == bo.BookId);
        }

        public virtual void Clear()
        {
            Lines.Clear();
        }

        public double ComputeTotalSum()
        {
            return Lines.Sum(e => e.Book.Price * e.Quantity);
        }

        public class CartLine
        {
            public int CartlineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}

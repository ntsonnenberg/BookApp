using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    /**
     * This is the EFAmazonRepository class, which inherits from the IAmazonRepository interface
     * It has an database instance, BooksDBContext that is a private property
     * It has a constructor to initialize the private property
     * It also sets an IQueryable array of Books into the context
     */
    public class EFAmazonRepository: IAmazonRepository
    {
        private BooksDBContext _context;
        public EFAmazonRepository(BooksDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}

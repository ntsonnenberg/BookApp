using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    /**
     * This is the BookDBContext class, which inherits from the DbContext class
     * This class is to create an instance of a database for the user
     * It has an DbSet array of Books as a property
     */
    public class BooksDBContext : DbContext
    {
        public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}

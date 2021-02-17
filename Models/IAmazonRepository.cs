using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    //This is the IAmazonRepository interface, it has an IQueryable array of Books 
    public interface IAmazonRepository
    {
        IQueryable<Book> Books { get; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    //This is the Book class, it includes a title, author first name, author last name, publisher, ISBN, classification, category, and price, all of these fields are requried for input
    //The Book class also has a BookId that is a primary key, so it is automagenerated when a new Book is created
    //The ISBN has to specifically be inputted in this format: "###-##########"
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression("[0-9]{3}-[0-9]{10}")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

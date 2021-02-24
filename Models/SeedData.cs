using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    /**
     * This is the SeedData class, it only has a method call EnsurePopulated in it
     * The EnsurePopulated passes in a IApplicationBuilder as a parameter and uses that to create an instance of the database (BooksDBContext)
     * If any changes have been made in the database, then the data will be migratedIf there are no pending changes
     * Then 10 of Professor Hilton's favorite books and 3 of my favorite books are created and added to the context and saved
    */
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BooksDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        Pages = 642
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        AuthorFirstName = "J.K.",
                        AuthorLastName = "Rowling",
                        Publisher = "Bloomsbury Publishing",
                        ISBN = "978-0545029377",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 31.49,
                        Pages = 607
                    },

                    new Book
                    {
                        Title = "Percy Jackson: The Last Olympian",
                        AuthorFirstName = "Rick",
                        AuthorLastName = "Riordan",
                        Publisher = "Disney Hyperion",
                        ISBN = "978-1423101475",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 14.23,
                        Pages = 381
                    },

                    new Book
                    {
                        Title = "The 4-Hour Workweek",
                        AuthorFirstName = "Timothy",
                        AuthorLastName = "Ferriss",
                        Publisher = "Crown Publishing Group",
                        ISBN = "978-0307353139",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.29,
                        Pages = 308
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

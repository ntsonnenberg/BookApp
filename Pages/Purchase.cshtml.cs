using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Infrastructure;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApp.Pages
{
    /**
     * This is the PurchaseModel class, which inherits from PageModel
     * It contains a private IAmazonRepository object, a cart object, and a returnUrl string
     * It has a constructor that initializes the repository object and cart object
     * method OnGet sets the returnUrl string, if the input is null, set the returnUrl to "/"
     * method OnPost adds a book to the cart and redirects to the page that displays the cart
     * method OnPostRemove removes the book selected from the cart and redirects to the page that displays the cart
     */
    public class PurchaseModel : PageModel
    {
        private IAmazonRepository repository;

        public PurchaseModel(IAmazonRepository repo, Cart cartServices)
        {
            repository = repo;
            Cart = cartServices;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(book, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.RemoveItem(book);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

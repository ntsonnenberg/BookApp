using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Components
{
    /**
     * This is the Cart Summary View Component class, which inherits from the View Component class
     * It contains a private cart object
     * It has a constructor to initialize the cart object
     * It also has an invoke method to send the cart object to the view to display the cart summary in the navbar
     */
    public class CartSummaryViewComponent: ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}

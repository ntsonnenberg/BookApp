using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Components
{
    /**
     * This is the Navigation Menu View Component class, which inherits from the View Component class
     * It has contains a private IAmazonRepository
     * It has a constructor that initializes the repository
     * It also has a method called Invoke that selects all the books for the category that the user clicks on
     */
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IAmazonRepository repository;

        public NavigationMenuViewComponent(IAmazonRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    /**
     * This class is to store data about the pages being rendered dynamically
     * It includes a total number of items in the book list, the number of items that will be display per page, and the current page the user is on
     * It also has a method calld TotalPages that calculates the total number of pages needed based on the total items and the items per page
     */
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class shoppingCart
    {
        public int cartID { get; set; }

        public int bookID { get; set; }
        public int quantity { get; set; }
        public string dateAdded { get; set; }

        public Invoice invoice { get; set; }

        public void viewCartDetails() { }
        public bool addBookIntoCart(shoppingCart cart) { return true; }

        public bool deleteBookFromCart(int bookID) { return true; }

    }
}
using online_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online_Bookstore.Controllers
{
    public class SearchController : Controller
    {
        BookStoreEntities db = new BookStoreEntities();
        // GET: Search
        public ActionResult Index(String Searching)
        {

            var books = from s in db.Book_Inventory
                        select s;
            if (!String.IsNullOrEmpty(Searching))
            {
                books = books.Where(s => s.book_title.Contains(Searching));
            }
            return View(books.ToList());
        }
    }
}
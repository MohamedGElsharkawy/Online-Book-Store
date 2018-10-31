using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string BookTitle { get; set; }

        public string AuthorName { get; set; }

        public double Price { get; set; }

        public int quantity { get; set; }

        public string description { get; set; }

        public int ISBN { get; set; }

        public int numOFPages { get; set; }

        public string edition { get; set; }

        public string languageType { get; set; }
    }
}
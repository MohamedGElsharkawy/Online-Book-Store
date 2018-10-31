using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Item
    {
        public int itemID { get; set; }
        public int bookID { get; set; }

        public int quantity { get; set; }
        public float unitCost { get; set; }
        public float total { get; set; }

    }
}
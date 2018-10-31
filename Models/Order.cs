using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int customerID { get; set; }
        public string dateCreated { get; set; }
        
        public string status { get; set; }//Possible statuses include : PENDING , PROCESSING , SHIPPED , RETURNED , and CANCELED
        public List<Item> items { get; set; }//the details for every book into the order 

        public ShippingInfo shipping { get; set; }// information about order delivery to customer
    }
}
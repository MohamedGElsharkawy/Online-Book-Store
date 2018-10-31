using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{

    
    public class Customer:UserProfile
    {
        public shoppingCart cart { get; set; }

        //methods 
        public void makeOrderForBookBuying() { }
        public void rateBook(int bookID) { }

        public void sendFeedback(Feedback feedback) { }
    }
}
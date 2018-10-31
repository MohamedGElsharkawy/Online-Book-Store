using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Notification
    {
        public int notificationID { get; set; }

        public string description { get; set; }

        public string date { get; set; }

        public int customerID { get; set; } 
    }
}
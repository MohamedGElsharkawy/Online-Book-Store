using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Feedback
    {
        public int feedbackID { get; set; }

        public string feedbackSubject { get; set; }

        public string feedbackDescription { get; set; }
    }
}
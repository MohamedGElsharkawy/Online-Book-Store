//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace online_Bookstore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book_review
    {
        public int book_id { get; set; }
        public string comment { get; set; }
        public string rating { get; set; }
        public string user_name { get; set; }
        public System.DateTime review_date { get; set; }
    }
}
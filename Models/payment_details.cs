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
    
    public partial class payment_details
    {
        public string credit_username { get; set; }
        public string creditcard_number { get; set; }
        public string cardtype { get; set; }
        public int cvv_number { get; set; }
        public int user_id { get; set; }
    
        public virtual user user { get; set; }
    }
}

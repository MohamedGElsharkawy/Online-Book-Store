using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Catalog
    {
        public int CatalogID { get; set; }

        public string CatalogHeader { get; set; }

        public string CatalogDate { get; set; }

        public List<int> bookIDs { get; set; }
    }
}
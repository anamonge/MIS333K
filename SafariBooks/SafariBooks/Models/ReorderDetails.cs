using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafariBooks.Models
{
    public class ReorderDetails
    {

        public int ReorderID { get; set; }

        public int BookID { get; set; }

        public int Quantity { get; set; }

        public int ReorderDetailID { get; set; }

        public virtual Book Book { get; set; }

        public virtual Reorders Reorders { get; set; }

    }
}
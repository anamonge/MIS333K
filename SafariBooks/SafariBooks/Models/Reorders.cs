using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafariBooks.Models
{
    public class Reorders
    {

        public int ReorderID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public virtual List<ReorderDetails> ReorderDetails { get; set; }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SafariBooks.Models;


namespace SafariBooks.DAL
{
    public class SafariContext : DbContext
    {

        public SafariContext(): base ("MyDbConnection"){}
    }
}
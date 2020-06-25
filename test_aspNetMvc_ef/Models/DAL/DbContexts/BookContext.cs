using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Models.DAL.DbContexts
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
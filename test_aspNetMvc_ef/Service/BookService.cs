using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_aspNetMvc_ef.Models.DAL.DbContexts;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Service
{
    public class BookService
    {
        public IEnumerable<Book> GetAllBooks()
        {
            BookContext db = new BookContext();
            var result = db.Books;
            return result;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test_aspNetMvc_ef.Models.DAL.DbContexts;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Service
{
    public class BookService
    {
        private DataBaseContext db = new DataBaseContext();
        
        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            db.Dispose();
        }

        public void Delete(int bookid)
        {
            var book = db.Books.Find(bookid);
            if(book != null)
            {
                db.Entry(book).State = EntityState.Deleted;
                db.Books.Remove(book);
                db.SaveChanges();
                db.Dispose();
            }
        }

        public IEnumerable<Book> GetAll()
        {
            //BookContext db = new BookContext();
            var result = db.Books;
            db.Dispose();
            return result;
        }

        public Book GetById(int? bookid)
        {
            var result = db.Books.Find(bookid);
            db.Dispose();
            return result;
        }
    }
}
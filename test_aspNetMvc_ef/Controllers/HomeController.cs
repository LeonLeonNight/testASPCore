using System;
using System.Web.Mvc;
using test_aspNetMvc_ef.Models.DAL.Entity;
using test_aspNetMvc_ef.Service;

namespace test_aspNetMvc_ef.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bookService = new BookService();
            ViewBag.Books = bookService.GetAll();
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            var purchaseService = new PurchaseService();
            var result = purchaseService.Buy(purchase);
            return result;
        }

        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            var bookService = new BookService();
            if (id == null)
            {
                return HttpNotFound();
            }
            var book = bookService.GetById(id);
            if (book != null)
            {
                return View(book);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            var bookService = new BookService();
            bookService.Update(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            var bookService = new BookService();
            bookService.Create(book);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var bookService = new BookService();
            bookService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
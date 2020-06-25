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
            ViewBag.Books = bookService.GetAllBooks();
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_aspNetMvc_ef.Service;

namespace test_aspNetMvc_ef.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult Index()
        {
            var service = new PlayerService();
            return View(service.GetAll());
        }
    }
}
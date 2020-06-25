using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_aspNetMvc_ef.Util;

namespace test_aspNetMvc_ef.Controllers
{
    public class ExecuteResController : Controller
    {
        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_aspNetMvc_ef.Util;

namespace test_aspNetMvc_ef.Controllers
{
    public class ImgResController : Controller
    {
        public ActionResult GetImage()
        {
            string path = "../Images/visualstudio.png";
            return new ImageResult(path);
        }
    }
}
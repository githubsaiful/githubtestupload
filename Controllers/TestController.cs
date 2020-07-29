using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitubTest.Controllers
{
    public class TestController : Controller
    {
        // GET: new comment
        public ActionResult Index()
        {
            return View();
        }
    }
}

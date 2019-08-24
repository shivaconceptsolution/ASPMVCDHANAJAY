using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication31.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            int a = 100;
            int b = 200;
            int c = a + b;
            ViewBag.data = c;
            return View();
        }
    }
}
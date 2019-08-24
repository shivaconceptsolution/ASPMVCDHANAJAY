using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication31.Controllers
{
    public class SIController : Controller
    {
        // GET: SI
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            float p = float.Parse(obj["txtp"]);
            float r = float.Parse(obj["txtr"]); ;
            float t = float.Parse(obj["txtt"]); ;
            ViewBag.si = (p * r * t) / 100;
            return View();
        }
    }
}
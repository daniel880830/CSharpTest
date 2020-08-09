using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Models.students student1 = new Models.students();
            student1.ID = "1";
            ViewBag.name = "ethan";
            return View();
        }
    }
}
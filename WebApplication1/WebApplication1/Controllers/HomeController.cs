using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //所有
        public ActionResult Index()
        {
            return View();
        }
        //单页
        public ActionResult About()
        {
            return View();
        }
    }
}
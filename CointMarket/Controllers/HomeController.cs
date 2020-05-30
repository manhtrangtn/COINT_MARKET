using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CointMarket.Services;

namespace CointMarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            RealtimeDatabaseService.RealtimeCoin();
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HazeltreeMVC.Models;

namespace HazeltreeMVC.Controllers
{
    public class HomeController : Controller
    {
        Securities securities = new Securities();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult SearchSecurities(string SecurityCode, string SearchText)
        {
            var result = securities.Search(SecurityCode, SearchText);
            return PartialView("_SecurityLookup", result);
        }
    }
}
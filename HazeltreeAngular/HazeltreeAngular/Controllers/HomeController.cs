using HazeltreeAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HazeltreeAngular.Controllers
{
    public class HomeController : Controller
    {
        private ISecurities _Securities;

        public HomeController(ISecurities Securities)
        {
            _Securities = Securities;
        }
     
        [HttpGet]
        public JsonResult FetchData(string SecurityCode, string SearchText)
        {
            var result = _Securities.Search(SecurityCode ?? string.Empty, SearchText ?? string.Empty);
            return Json (result.ToList(),JsonRequestBehavior.AllowGet);

        }
        public ActionResult Index()
        {

            return View();
        }

      
    }
}
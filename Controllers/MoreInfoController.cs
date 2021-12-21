using AmirAbdullinWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmirAbdullinWeb.Controllers
{
    public class MoreInfoController : Controller
    {
        CoffeeContext CoffeeContext = new CoffeeContext();
        // GET: MoreInfo
        public ActionResult Info(int Id)
        {
            IEnumerable<Coffee> coffee = CoffeeContext.Coffees;
            ViewBag.Coffee = coffee;
            ViewBag.Id = Id;
            return View();
        }
    }
}
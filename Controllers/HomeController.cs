using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmirAbdullinWeb.Models;
namespace AmirAbdullinWeb.Controllers
{
    public class HomeController : Controller
    {
        CoffeeContext CoffeeContext = new CoffeeContext();
        public ActionResult Index()
        {
             
            IEnumerable<Coffee> coffee = CoffeeContext.Coffees;
            ViewBag.Coffee = coffee;
            return View();
        }

         
    }
}
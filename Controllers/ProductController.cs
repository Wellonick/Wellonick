using AmirAbdullinWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmirAbdullinWeb.Controllers
{
    public class ProductController : Controller
    {

        CoffeeContext CoffeeContext = new CoffeeContext();
        // GET: Product
        public ActionResult Products()
        {
            IEnumerable<Coffee> coffee = CoffeeContext.Coffees;
            ViewBag.Coffee = coffee;
            return View();
        }
    }
}
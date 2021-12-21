using AmirAbdullinWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmirAbdullinWeb.Controllers
{
    public class BuyCoffeeController : Controller
    {
        
        CoffeeContext CoffeeContext = new CoffeeContext();
        [HttpGet]
        public ActionResult BuyCoffee(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Account/Login");
            }
            IEnumerable<Coffee> coffee = CoffeeContext.Coffees;
            ViewBag.Coffee = coffee;
            ViewBag.Id = id;
            return View();
        }
         [HttpPost]
         public string BuyCoffee(Buy buy)
        {
            buy.DateTime = DateTime.Now;
            buy.UserName = User.Identity.Name;
            CoffeeContext.Buys.Add(buy);
            CoffeeContext.SaveChanges();
            return $"Поздравляем с покупкой!";
        }
         
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmirAbdullinWeb.Models
{
    public class CoffeeContext: DbContext
    {
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Buy> Buys { get; set; }    
    }
}
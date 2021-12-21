using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmirAbdullinWeb.Models
{
    public class Buy
    {
        public int BuyId { get; set; }
        public int CoffeeId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
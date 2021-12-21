using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmirAbdullinWeb.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }
       public string Desc { get; set; }
        public string AllDesc { get; set; }
       public bool isFav { get; set; }
    }
}
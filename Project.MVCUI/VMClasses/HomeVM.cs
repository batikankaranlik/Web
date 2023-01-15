using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Service> Services { get; set; }
        public List<Product> Products { get; set; }
        public List<Team> Teams { get; set; }
        public Contact Contact { get; set; }
        public AppUser AppUser { get; set; }
    }
}
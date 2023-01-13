using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class ServiceVM
    {
        public Service  Service { get; set; }
        public List<Service> Services { get; set; }
    }
}
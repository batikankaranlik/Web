using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class BannerVM
    {
        public Banner Banner { get; set; }
        public List<Banner> Banners { get; set; }
    }
}
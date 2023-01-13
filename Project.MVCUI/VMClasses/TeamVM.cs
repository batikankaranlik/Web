using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class TeamVM
    {
        public Team Team { get; set; }
        public List<Team> Teams { get; set; }
    }
}
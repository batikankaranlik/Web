using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Team:BaseEntity
    {
        

        public string ProfileImage { get; set; }

        public string NameSurname { get; set; }

        public string Title { get; set; }

        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
    }
}

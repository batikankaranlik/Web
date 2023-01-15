using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Team:BaseEntity
    {

        
        public string ProfileImage { get; set; }
        [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string Title { get; set; }

        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
    }
}

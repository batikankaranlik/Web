using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser:BaseEntity
    {
        public AppUser()
        {
            Role = UserRole.Member;
           
        }
       [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string Password { get; set; }


       
        public bool Active { get; set; }
       [Required(ErrorMessage = "Girilmesi Zorunludur")]
       [EmailAddress(ErrorMessage ="Düzgün formatta Mail giriniz")]
        public String Email { get; set; }
        public UserRole Role { get; set; }
    }
}

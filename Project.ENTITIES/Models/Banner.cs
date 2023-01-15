using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Banner:BaseEntity
    {
       [Display(Name = "Küçük Başlık")]
       [Required(ErrorMessage = "Girilmesi Zorunludur")]

        public string SmallTitle { get; set; }


      [Display(Name = "Büyük Başlık")]
        [Required(ErrorMessage = "Girilmesi Zorunludur")]

        public string BigTitle { get; set; }

        [Display(Name = "Buton Başlığı")]
        [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string ButtonText { get; set; }


        [Display(Name = "Buton Linki")]
        [Required(ErrorMessage = "Girilmesi Zorunludur")]
        public string ButtonUrl { get; set; }
    }
}

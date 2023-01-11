using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Banner:BaseEntity
    {
       // [Display(Name = "Küçük Başlık")]
       // [Required]
       // [StringLength(200)]
        public string SmallTitle { get; set; }


      //  [Display(Name = "Büyük Başlık")]
      //  [Required]
      //  [StringLength(200)]
        public string BigTitle { get; set; }

       // [Display(Name = "Buton Başlığı")]
       // [Required]
       // [StringLength(50)]
        public string ButtonText { get; set; }


       // [Display(Name = "Buton Linki")]
       // [Required]
        public string ButtonUrl { get; set; }
    }
}

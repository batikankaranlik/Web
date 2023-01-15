using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Service:BaseEntity
    {
       [Display(Name = "İkon")]
       
       // [StringLength(200, MinimumLength = 10, ErrorMessage = "Bu alana minimum 10 maksimum 200 karakter girebilirsiniz..")]
        public string Icon { get; set; }


       [Display(Name = "Başlık")]
       [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        
        public string Title { get; set; }

       [Display(Name = "Açıklama")]
       [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
       
        public string Description { get; set; }
    }
}

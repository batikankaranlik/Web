using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Service:BaseEntity
    {
       // [Display(Name = "İkon")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
       // [StringLength(200, MinimumLength = 10, ErrorMessage = "Bu alana minimum 10 maksimum 200 karakter girebilirsiniz..")]
        public string Icon { get; set; }


        //[Display(Name = "Başlık")]
        //[Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Bu alana minimum 20 maksimum 200 karakter girebilirsiniz..")]
        public string Title { get; set; }

       // [Display(Name = "Açıklama")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
       // [StringLength(500)]
        public string Description { get; set; }
    }
}

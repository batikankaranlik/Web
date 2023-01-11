using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Product:BaseEntity
    {
        


       // [Display(Name = "Resim")]
        public string ImageUrl { get; set; } = "";


        //[Display(Name = "Ürün Adı")]
        //[Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
       // [StringLength(100, MinimumLength = 5, ErrorMessage = "Bu alana minimum 20 maksimum 200 karakter girebilirsiniz..")]
        public string Name { get; set; }

       /// [Display(Name = "Açıklama")]
        //[Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
       // [StringLength(500)]
        public string Description { get; set; }

        //[Display(Name = "Alt Başlık")]
        //[Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string SubTitle { get; set; }

       // [Display(Name = "Kategori")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string Category { get; set; }
    }
}

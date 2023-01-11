using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Contact:BaseEntity
    {
       // [Display(Name = "Adı Soyadı")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string NameSurname { get; set; }


      //  [Display(Name = "Email")]
      //  [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string Email { get; set; }


       // [Display(Name = "Telefon")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string Phone { get; set; }


       // [Display(Name = "Mesaj")]
       // [Required(ErrorMessage = "Bu alanı boş geçemezsiniz..")]
        public string Message { get; set; }

      //  [Display(Name = "Oluşturma Tarihi")]
        

        public bool IsClosed { get; set; }
    }
}

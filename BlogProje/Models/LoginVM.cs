using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Models
{
    public class LoginVM
    {
        [Display(Name ="EMail Adresi")]
        [Required(ErrorMessage ="Lütfen E-Mail Adresinizi Giriniz!")]
        public string Email { get; set; }
        public bool IsRemember { get; set; }
    }
}

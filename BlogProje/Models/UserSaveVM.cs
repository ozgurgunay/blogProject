using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Models
{
    public class UserSaveVM
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen E-Mail Adresinizi Giriniz!")]
        public string Email { get; set; }
        public string Explanation { get; set; }
        public byte[] Picture { get; set; }
    }
}

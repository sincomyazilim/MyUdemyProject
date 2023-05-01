using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class AddRegisterDto
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        public string City { get; set; }
        [Required(ErrorMessage = "şehir alanı gereklidir")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar alanı gereklidir")]
        [Compare("Password",ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        //public int WorkLocationId { get; set; }//137
    }
}

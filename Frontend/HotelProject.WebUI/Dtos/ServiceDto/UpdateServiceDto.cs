using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {//v34
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Hizmet ikon link ekleyiniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karekter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet başlığı en fazla 500 karekter olabilir")]
        public string Description { get; set; }
    }
}

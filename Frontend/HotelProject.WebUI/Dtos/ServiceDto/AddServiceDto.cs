using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class AddServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikon link ekleyiniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karekter olabilir")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
